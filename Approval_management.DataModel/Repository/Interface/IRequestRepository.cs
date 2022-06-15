using Approval_management.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Repository.Interface
{
    public interface IRequestRepository
    {
        List<RequestDetail> GetAllRequest();
        List<RequestDetail> GetRequestbyID(int id);
        RequestDetail GetRequest(int id);
       int AddRequest(RequestDetail request);
        RequestDetail UpdateRequest(RequestDetail request);
        int DeleteRequest(int id);
    }
}
