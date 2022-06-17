using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository
{
    public class UserInfoRepository: IUserInfoRepository
    {
        private readonly BudgetRequestContext _context;
        public UserInfoRepository(BudgetRequestContext UserInfo_RequestContext)
        {
            _context = UserInfo_RequestContext;
        }


        List<UserInfo> IUserInfoRepository.GetAllUserInfo()
        {
            return _context.UserInfos.ToList();
        }
    }
}
