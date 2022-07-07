using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Services
{
    public class ForwardRequestService : IForwardRequestService
    {
        private readonly IForwardRequest _request;
        public ForwardRequestService(IForwardRequest budget_RequestContext)
        {
            _request = budget_RequestContext;
        }
        public async Task<ForwordedRequestDetail> addForwardRequest(ForwordedRequestDetail request)
        {
            return await _request.addForwardRequest(request); 
        }

        public Task<int> changeStatus(int id, int status)
        {
            return _request.changeStatus(id, status);
        }

        public async Task<List<ForwordedRequestDetail>> GetAllRequest(int id)
        {
            return await _request.GetAllRequest( id);
        }

        public async Task<int> RejectionCommentBySuperManager(int Id, string Comment)
        {
          return await _request.RejectionCommentBySuperManager(Id, Comment);
        }
    }
}
