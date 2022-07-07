using Approval_management.DataModel.Entities;
using Approval_management.DataModel.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository
{
    public class ForwardRequest:IForwardRequest
    {
        private readonly BudgetRequestContext _context;
        public ForwardRequest(BudgetRequestContext budget_RequestContext)
        {
            _context = budget_RequestContext;
        }
        public async Task<ForwordedRequestDetail> addForwardRequest(ForwordedRequestDetail request)
        {
            _context.ForwordedRequestDetails.Add(request);
         
            //Emailnotification.EmailNotification();
            await _context.SaveChangesAsync();
            return request;
        }

        public async Task<int> changeStatus(int id, int status)
        {
            var requestDetail = new ForwordedRequestDetail { ForwordedRequestId = id, RequestStatus = status };
            _context.ForwordedRequestDetails.Attach(requestDetail).Property(x => x.RequestStatus).IsModified = true;
            await _context.SaveChangesAsync();
            return 1;
        }

      

        public async Task<List<ForwordedRequestDetail>> GetAllRequest(int id)
        {

            return await _context.ForwordedRequestDetails.Where(x=>x.SuperManagerId==id && x.IsDeleted==false).ToListAsync();
        }

        public async Task<int> RejectionCommentBySuperManager(int Id, string Comment)
        {
            var requestDetail = new ForwordedRequestDetail { ForwordedRequestId = Id, Comments = Comment };
            _context.ForwordedRequestDetails.Attach(requestDetail).Property(x => x.Comments).IsModified = true;
            await _context.SaveChangesAsync();
            return 1;
        }
    }
}
