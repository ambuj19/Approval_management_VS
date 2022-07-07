using Approval_management.DataModel.Email;
using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<RequestDetail>> GetAllRequest()
        {
            return await _context.RequestDetails.ToListAsync();
        }
        public RequestDetail GetRequest(int id)
        {
            return  _context.RequestDetails.FirstOrDefault(x => x.RequestId == id);
        }
        public async Task<List<RequestDetail>> GetRequestbyID(int id)
        {
            return await _context.RequestDetails.Where(x => x.UserId == id).ToListAsync();
        }
        public async Task<RequestDetail> AddRequest(RequestDetail request)
        {
            _context.RequestDetails.Add(request);
            Emailnotification.EmailNotification();
            await _context.SaveChangesAsync();
            return request;
        }
        public async Task<int> UpdateRequest(RequestDetail request)
        {
            _context.RequestDetails.Update(request);
            await _context.SaveChangesAsync();
            return 1;
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

        public async Task<List<RequestDetail>> Managerlogin(int id)
        {
           return await _context.RequestDetails.Where(x=>x.ManagerId==id).ToListAsync();
        }

        public async Task<List<RequestDetail>> RequestStatus(int id,int status)
        {
            return await _context.RequestDetails.Where(x => x.UserId == id && x.RequestStatus == status).ToListAsync();
        }

        public async Task<int> changeStatus(int id, int status)
        {
            var requestDetail = new RequestDetail { RequestId = id, RequestStatus = status };
            _context.RequestDetails.Attach(requestDetail).Property(x => x.RequestStatus).IsModified = true;
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> RejectionCommentByManager(int Id, string Comment)
        {
            var requestDetail = new RequestDetail { RequestId = Id, Comments = Comment };
            _context.RequestDetails.Attach(requestDetail).Property(x => x.Comments).IsModified = true;
            await _context.SaveChangesAsync();
            return 1;
        }
    }
}
