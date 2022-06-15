using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.Services.Interface;
using System.Collections.Generic;

namespace Approval_management.Services
{
    public class RequestDetailService : IRequestDetailService
    {
        private readonly IRequestRepository _request;
        public RequestDetailService(IRequestRepository budget_RequestContext)
        {
            _request = budget_RequestContext;
        }
        public List<RequestDetail> GetAllRequest()
        {
            return _request.GetAllRequest();
        }
        public List<RequestDetail> GetRequestbyID(int id)
        {
            return _request.GetRequestbyID(id);
        }
        public int AddRequest(RequestDetail request)
        {
            return _request.AddRequest(request);
        }
        public RequestDetail UpdateRequest(RequestDetail request)
        {
            return _request.UpdateRequest(request);
        }
        public int DeleteRequest(int id)
        {
            return (_request.DeleteRequest(id));
        }
    }
}
