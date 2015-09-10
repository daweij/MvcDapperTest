using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDapperTest.Core
{
  public interface IUserRepository
  {
    User Select(Guid id);
    IEnumerable<User> All();
    IList<User> AllAsList();
    void Insert(User user);
  }
}
