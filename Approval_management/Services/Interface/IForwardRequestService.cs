using Approval_management.DataModel.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Services.Interface
{
    public interface IForwardRequestService
    {
        Task<ForwordedRequestDetail> addForwardRequest(ForwordedRequestDetail request);
        Task<List<ForwordedRequestDetail>> GetAllRequest(int id);
        Task<int> changeStatus(int id, int status);
        Task<int> RejectionCommentBySuperManager(int Id, string Comment);
    }
}
