using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DaoLibrary.Dao
{
    /**
     * This class is the DAO Implementation for the SQL Server database and
     * I really do wish this class used a ORM solution similar to what I am 
     * more familiar with in the Java tech stack with JPA and Hibernate. But 
     * I am just getting back into .NET technologies after a long break and
     * it was felt that a safer approach would be to use the Dapper NuGet
     * Package and then to invoke some simple stored procedures instead. I 
     * should however give credit to "Tim Corey" as it was his instruction 
     * on how to use Dapper made that it all possible. 
     */
    class SqlServerDao : IDataAccess
    {
        private readonly IConfiguration _config;

        /**
         * Class construction
         */ 
        public SqlServerDao(IConfiguration config)
        {
            _config = config;
        }

        /**
		 * Invokes stored procedure to load data from the underlying data source. 
		 * @param storedProcName specifies the name of stored procedure to invoke.
		 * @param parameters specifies the parameters to be passed to stored proc.
		 * @param connectionStringName specifies the name of the connection string.
		 * @return List representing the collection of data from the data source
		 */
        public async Task<List<T>> Load<T, U>(string storedProcName, U parameters, string connectionStringName)
        {
            // This block of code ensures the connection is closed even if an Exception gets thrown
            string connectionString = _config.GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(storedProcName,
                                                          parameters,
                                                          commandType: CommandType.StoredProcedure);
                return rows.ToList();
            }
        }

        /**
		 * Invokes stored procedure to save data into the underlying data source. 
		 * @param storedProcName specifies the name of stored procedure to invoke.
		 * @param parameters specifies the parameters to be passed to stored proc.
		 * @param connectionStringName specifies the name of the connection string.
		 * @return int representing how many rows were affected.
		 */
        public async Task<int> Save<T>(string storedProcName, T parameters, string connectionStringName)
        {
            // This block of code ensures the connection is closed even if an Exception gets thrown
            string connectionString = _config.GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return await connection.ExecuteAsync(storedProcName,
                                                     parameters,
                                                     commandType: CommandType.StoredProcedure);
            }
        }
    }
}
