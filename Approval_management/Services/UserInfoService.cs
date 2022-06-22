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

        public UserInfo AuthenticateUser(UserInfo loginCredentials)
        {
            return _request.AuthenticateUser(loginCredentials);
        }

        public bool CheckUserAvailabity(string userName)
        {
            throw new System.NotImplementedException();
        }

        public List<UserInfo> GetAllUserInfo()
        {
          return _request.GetAllUserInfo();
        }

        public bool isUserExists(int userId)
        {
            throw new System.NotImplementedException();
        }

        public int RegisterUser(UserInfo userData)
        {
            throw new System.NotImplementedException();
        }
    }
}
