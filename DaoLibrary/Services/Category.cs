using DaoLibrary.Dao;
using DaoLibrary.Dto;
using DaoLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DaoLibrary.Services
{
    /**
     * Category service layer tasked with interacting with the DAO layer.
     */
    class Category : ICategory
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        private const string getAllCategories = "dbo.spCategories_GetAll";

        /**
         * Class constructor 
         */
        public Category(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        /**
         * Used to extract the collection of all Category instances from the DAO.
         * @return List representing the collection of all Category instances.
         */
        public  Task<List<CategoryModel>> GetCategories()
        {
            //FUBAR still need to come up with a way to retrieve the collection of Items assigned to each Category
//            List<>
//            List<CategoryDto> categoryDtoList = await _dataAccess.Load<CategoryDto, dynamic>(getAllCategories, new {}, _connectionString.Name);
//            foreach(dto in categoryDtoList)
//            {
//
//            }

            return await _dataAccess.Load<CategoryModel, dynamic>(getAllCategories, new { }, _connectionString.Name);
        }
    }
}
