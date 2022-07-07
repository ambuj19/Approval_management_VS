using Approval_management.DataModel.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository.Interface
{
    public interface IRequestRepository
    {
        Task<List<RequestDetail>> GetAllRequest();
        Task<List<RequestDetail>> GetRequestbyID(int id);
        RequestDetail GetRequest(int id);
        Task<RequestDetail> AddRequest(RequestDetail request);
        Task<int> UpdateRequest(RequestDetail request);
        Task<List<RequestDetail>> Managerlogin(int id);
        Task<List<RequestDetail>> RequestStatus(int id, int status);
        Task<int> changeStatus(int id, int status);
        Task<int> RejectionCommentByManager(int Id, string Comment);
        int DeleteRequest(int id);
    }
}
