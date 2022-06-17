using Approval_management.DataModel.Entities;
using System.Collections.Generic;

namespace Approval_management.Services.Interface
{
    public interface IUserInfoService
    {
        List<UserInfo> GetAllUserInfo();
    }
}
