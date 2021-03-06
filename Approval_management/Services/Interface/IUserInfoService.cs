using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Services.Interface
{
    public interface IUserInfoService
    {
        List<UserInfo> GetAllUserInfo();
        Task<List<UserInfo>> GetUserbyID(int id);
        UserInfo AuthenticateUser(LoginDetailsDto loginCredentials);
        int RegisterUser(UserInfo userData);
        bool CheckUserAvailabity(string userName);

        bool isUserExists(int userId);
    }
}
