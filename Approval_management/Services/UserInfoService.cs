using Approval_management.Services.Interface;
using Approval_management.DataModel.Repository.Interface;
using System.Collections.Generic;
using Approval_management.DataModel.Entities;

namespace Approval_management.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _request;
        public UserInfoService(IUserInfoRepository UserInfo_RequestContext)
        {
            _request = UserInfo_RequestContext;
        }

        public List<UserInfo> GetAllUserInfo()
        {
          return _request.GetAllUserInfo();
        }
    }
}
