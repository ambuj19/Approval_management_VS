using Approval_management.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository.Interface
{
    public interface IForwardRequest
    {
        Task<ForwordedRequestDetail> addForwardRequest(ForwordedRequestDetail request);
        Task<List<ForwordedRequestDetail>> GetAllRequest(int id);
        Task<int> changeStatus(int id, int status);
        Task<int> RejectionCommentBySuperManager(int Id, string Comment);
    }
}
