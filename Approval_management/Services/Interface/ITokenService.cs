using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;

namespace Approval_management.Services.Interface
{
    public interface ITokenService
    {
        string CreateToken(UserInfo  userInfo);
    }
}
