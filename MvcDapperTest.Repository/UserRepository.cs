using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using MvcDapperTest.Core;
using Dapper;

namespace MvcDapperTest.Repository
{
  public class UserRepository : IUserRepository
  {
    public string ConnectionString { get; private set; }

    private IDbConnection OpenConnection()
    {
      var connection = new SqlConnection(ConnectionString);
      connection.Open();
      return connection;
    }

    public UserRepository(string connectionString)
    {
      if (string.IsNullOrEmpty(connectionString)) 
        throw new ArgumentNullException("connectionString");
      this.ConnectionString = connectionString;
    }

    public User Select(Guid id)
    {
      using (var conn = OpenConnection())
      {
        string sql = "SELECT * FROM Users WHERE Id = @Id;";
        return conn.Query<User>(sql, new { Id = id }).SingleOrDefault();
      }
    }

    public IEnumerable<User> All()
    {
      using (var conn = OpenConnection())
      {
        string sql = "SELECT * FROM Users;";
        return conn.Query<User>(sql);
      }
    }

    public IList<User> AllAsList()
    {
      using (var conn = OpenConnection())
      {
        string sql = "SELECT * FROM Users;";
        var users = conn.Query<User>(sql);
        if (users == null)
          return null;
        return users.ToList();
      }
    }

    public void Insert(User user)
    {
      throw new NotImplementedException();
    }
  }
}
