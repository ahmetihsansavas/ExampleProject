using com.btc.dataaccess.Context;
using com.btc.dataaccess.Dao.System.Abstract;
using com.btc.dataaccess.Generic.Abstract;
using com.btc.dataaccess.Generic.Concerete;
using com.btc.type.Entity.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.btc.dataaccess.Dao.System.Concrete
{
    public class UserDAO : GenericRepositoryDAO<User>, IUserDAO
    {
        ExampleContext _context;
        public UserDAO(ExampleContext context) : base(context)
        {
            _context = context;
        }

        public string GetName(int id)
        {
            return _context.Set<User>().Where(u => u.Id == id).FirstOrDefault().Name;
        }
    }
}
