using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BudgetRequestContext _context;
        public RequestRepository(BudgetRequestContext budget_RequestContext)
        {
            _context = budget_RequestContext;
        }
        public List<RequestDetail> GetAllRequest()
        {
           return _context.RequestDetails.ToList();
        }
        public RequestDetail GetRequest(int id)
        {
            return _context.RequestDetails.FirstOrDefault(x=>x.RequestId==id);
        }
        public List<RequestDetail> GetRequestbyID(int id)
        {
            return _context.RequestDetails.Where(x=>x.UserId == id).ToList();
        }
        public int AddRequest(RequestDetail request)
        {
            _context.RequestDetails.Add(request);
            _context.SaveChanges();
            return 1;
        }
        public RequestDetail UpdateRequest(RequestDetail request)
        {
            _context.RequestDetails.Update(request);
            _context.SaveChanges();
            return null;
        }
        public int DeleteRequest(int id)
        {
            RequestDetail requestDetail = GetRequest(id);
            if (requestDetail != null)
            {
                _context.RequestDetails.Remove(requestDetail);
                _context.SaveChanges(true);
                return 1;
            }
            return 0;
        }
    }
}
