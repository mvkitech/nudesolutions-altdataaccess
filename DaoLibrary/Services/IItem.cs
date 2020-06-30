using DaoLibrary.Models;
using System.Threading.Tasks;

namespace DaoLibrary.Services
{
    interface IItem
    {
        /**
         * Used to extract a target Item entity via the DAO layer.
         * @param item specifies the target Item to be retrieved.
         * @return ItemModel representing the target Item entity.
         */
        Task<ItemModel> GetItemById(int itemId);

        /**
         * Used to create a new Item entity instance via the DAO layer.
         * @param item specifies the new Item that is to be created.
         * @return int representing the primary Id of the new entity.
         */
        Task<int> CreateItem(ItemModel item);

        /**
         * Used to update an existing Item entity instance via the DAO layer.
         * @param itemId specifies the primary Id of the Item to be updated.
         * @param description specifies the Item's description value to update.
         * @param limit specifies the Item's limit value to update.
		 * @return int representing how many rows were affected.
         */
        Task<int> UpdateItem(int itemId, string description, int limit);

        /**
         * Used to delete an existing Item entity instance via the DAO layer.
         * @param itemId specifies the primary Id of the Item to be deleted.
		 * @return int representing how many rows were affected.
         */
        Task<int> DeleteItem(int itemId);
    }
}
