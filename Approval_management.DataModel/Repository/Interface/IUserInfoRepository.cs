using Approval_management.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository.Interface
{
    public interface IUserInfoRepository
    {
        List<UserInfo> GetAllUserInfo();
    }
}
