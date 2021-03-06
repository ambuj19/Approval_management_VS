using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.ServiceModel.DTO.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private readonly BudgetRequestContext _context;
        public UserInfoRepository(BudgetRequestContext UserInfo_RequestContext)
        {
            _context = UserInfo_RequestContext;
        }

        public UserInfo AuthenticateUser(LoginDetailsDto loginCredentials)
        {
            UserInfo userMaster = new UserInfo();
            var userDetails = _context.UserInfos.FirstOrDefault(u => u.UserName == loginCredentials.UserName

            && u.Password == loginCredentials.Password);
            if (userDetails != null)
            {
                var user = new UserInfo
                {
                    UserName = userDetails.UserName,
                    UserId = userDetails.UserId,
                    ManagerId = userDetails.ManagerId,
                    IsManager=userDetails.IsManager,

                };

                return user;
            }

            else
            {
                return userDetails;
            }
        }

        public bool CheckUserAvailabity(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserInfo>> GetUserbyID(int id)
        {
            return await _context.UserInfos.Where(x => x.UserId == id).ToListAsync();
        }

        public bool isUserExists(int userId)
        {
            throw new NotImplementedException();
        }

        public int RegisterUser(UserInfo userData)
        {
            throw new NotImplementedException();
        }

        List<UserInfo> IUserInfoRepository.GetAllUserInfo()
        {
            return _context.UserInfos.ToList();
        }


    }
}
