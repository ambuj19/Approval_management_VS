using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Services
{
    public class RequestDetailService : IRequestDetailService
    {
        private readonly IRequestRepository _request;
        public RequestDetailService(IRequestRepository budget_RequestContext)
        {
            _request = budget_RequestContext;
        }
        public Task< List<RequestDetail>> GetAllRequest()
        {
            return _request.GetAllRequest();
        }
        public Task< List<RequestDetail>> GetRequestbyID(int id)
        {
            return _request.GetRequestbyID(id);
        }
        public async Task<RequestDetail> AddRequest(RequestDetail request)
        {
            return await _request.AddRequest(request);
        }
        public async Task<int>  UpdateRequest(RequestDetail request)
        {
            return await _request.UpdateRequest(request);
        }
        public int DeleteRequest(int id)
        {
            return (_request.DeleteRequest(id));
        }

        public  RequestDetail GetRequest(int id)
        {
           return  _request.GetRequest(id);
        }

        public async Task<List<RequestDetail>> Managerlogin(int id)
        {
            return await (_request.Managerlogin(id));
        }

        public async Task<List<RequestDetail>> RequestStatus(int id, int status)
        {
            return await(_request.RequestStatus(id, status));
        }

        public async Task<int> changeStatus(int id, int status)
        {
          return await _request.changeStatus(id,status);
        }

        public async Task<int> RejectionCommentByManager(int Id, string Comment)
        {
           return await _request.RejectionCommentByManager(Id, Comment);
        }
    }
}
