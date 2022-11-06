using BlazorDatabase.Server.DbContext;
using BlazorDatabase.Shared;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BlazorDatabase.Server.IService
{
    public class PersonService /*: IPersonService*/
    {
        /*private readonly SqlConnectionConfig _connection;
        public PersonService(SqlConnectionConfig connection)
        {
            _connection = connection;
        }

        public async Task<bool> CreatePerson(Person person)
        {
            using (var conn = new SqlConnection(_connection.Value))
            {
                const string query = @"insert into Person (Name,SurName) values (@Name,@SurName)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
              
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                
            }
            return true;
        }

        public async Task<bool> DeletePerson(int id)
        {
            using (var conn = new SqlConnection(_connection.Value))
            {
                const string query = @"delete from Person where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            return true;
        }

        public async Task<bool> EditPerson(int id, Person person)
        {
            using (var conn = new SqlConnection(_connection.Value))
            {
                const string query = @"update Person set Name = @Name, SurName = @SurName where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
          
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }

        public async Task<IEnumerable<Person>> GetPeople()
        {
            IEnumerable<Person> person;
            using (var conn = new SqlConnection(_connection.Value))
            {
                const string query = @"select * from Person";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    person = await conn.QueryAsync<Person>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }

            }
            return person;
        }

        public async Task<Person> SinglePerson(int id)
        {
            Person person = new Person();

            using (var conn = new SqlConnection(_connection.Value))
            {
                const string query = @"select * from Person where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    person = await conn.QueryFirstOrDefaultAsync<Person>(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return person;
        }
*/

    }
}
