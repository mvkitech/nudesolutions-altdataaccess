using System.Collections.Generic;
using System.Threading.Tasks;

namespace DaoLibrary.Dao
{
	/**
	 * Interface used to define the "Data Access" APIs in case the decision is made 
	 * to include more that one DAO implentation for various different databases.
	 */
	interface IDataAccess
    {
		/**
		 * Invokes stored procedure to load data from the underlying data source. 
		 * @Param storedProcName specifies the name of stored procedure to invoke.
		 * @Param parameters specifies the parameters to be passed to stored proc.
		 * @Param connectionStringName specifies the name of the connection string.
		 * @Return List representing the collection of data from the data source
		 */
		Task<List<T>> Load<T, U>(string storedProcName, U parameters, string connectionStringName);

		/**
		 * Invokes stored procedure to save data into the underlying data source. 
		 * @Param storedProcName specifies the name of stored procedure to invoke.
		 * @Param parameters specifies the parameters to be passed to stored proc.
		 * @Param connectionStringName specifies the name of the connection string.
		 * @Return int representing how many rows were affected.
		 */
		Task<int> Save<T>(string storedProcName, T parameters, string connectionStringName);
    }
}
