using Approval_management.DataModel.Entities;

namespace Approval_management.Services.Interface
{
    public interface ITokenService
    {
        string CreateToken(UserInfo userInfo);
    }
}
