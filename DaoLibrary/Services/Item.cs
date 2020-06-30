using Dapper;
using DaoLibrary.Dao;
using DaoLibrary.Models;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DaoLibrary.Services
{
    /**
     * Item service layer tasked with interacting with the DAO layer.
     */
    class Item
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        private const string getItemById = "dbo.spItem_GetById";
        private const string insertItem  = "dbo.spItem_Insert";
        private const string updateItem  = "dbo.spItem_Update";
        private const string deleteItem  = "dbo.spItem_Delete";

        /**
         * Class constructor 
         */
        public Item(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        /**
         * Used to extract a target Item entity via the DAO layer.
         * @param item specifies the target Item to be retrieved.
         * @return ItemModel representing the target Item entity.
         */
        public async Task<ItemModel> GetItemById(int itemId)
        {
            // Invoke the DAO's Load method to extract the target Item entity
            var result = await _dataAccess.Load<ItemModel, dynamic>(getItemById,
                                    new
                                    {
                                        Id = itemId
                                    },
                                    _connectionString.Name);

            // We should only ever expect to retrieve one result from DAO.
            // But just in case no result is returned, use "FirstOrDefault()" 
            // as its use should prevent any exceptions from being thrown.
            return result.FirstOrDefault();
        }

        /**
         * Used to create a new Item entity instance via the DAO layer.
         * @param item specifies the new Item that is to be created.
         * @return int representing the primary Id of the new entity.
         */
        public async Task<int> CreateItem(ItemModel item)
        {
            // Setup the request parameters
            DynamicParameters p = new DynamicParameters();
            p.Add("CategoryId", item.CategoryId);
            p.Add("Description", item.Description);
            p.Add("Limit", item.Limit);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            // Invoke the DAO's Save method to insert a new Item entity
            await _dataAccess.Save(insertItem, p, _connectionString.Name);
            return p.Get<int>("Id");
        }

        /**
         * Used to update an existing Item entity instance via the DAO layer.
         * @param itemId specifies the primary Id of the Item to be updated.
         * @param description specifies the Item's description value to update.
         * @param limit specifies the Item's limit value to update.
		 * @return int representing how many rows were affected.
         */
        public Task<int> UpdateItem(int itemId, string description, int limit)
        {
            // Invoke the DAO's Save method to update the Item entity
            return _dataAccess.Save(updateItem, 
                                    new 
                                    { 
                                        Id = itemId, 
                                        Description = description, 
                                        Limit = limit
                                    }, 
                                    _connectionString.Name);
        }

        /**
         * Used to delete an existing Item entity instance via the DAO layer.
         * @param itemId specifies the primary Id of the Item to be deleted.
		 * @return int representing how many rows were affected.
         */
        public Task<int> DeleteItem(int itemId)
        {
            // Invoke the DAO's Save method to delete the Item entity
            return _dataAccess.Save(deleteItem,
                                    new 
                                    {
                                        Id = itemId
                                    },
                                    _connectionString.Name);
        }
    }
}
