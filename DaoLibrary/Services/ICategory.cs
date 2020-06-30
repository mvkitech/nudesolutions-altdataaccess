using DaoLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DaoLibrary.Services
{
    interface ICategory
    {
        /**
         * Used to extract the collection of all Category instances from the DAO.
         * @return List representing the collection of all Category instances.
         */
        Task<List<CategoryModel>> GetCategories();
    }
}
