using com.btc.dataaccess.Generic.Abstract;
using com.btc.manager.Generic.Concrete;
using com.btc.manager.System.Abstract;
using com.btc.type.Entity.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.btc.manager.System.Concrete
{
    public class UserManager : Manager<User>, IUserManager
    {
        IUnitOfWork _unitOfWork;
        public UserManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string GetName(int id)
        {
            return _unitOfWork.UserDAO.GetName(id);
        }
    }
}
