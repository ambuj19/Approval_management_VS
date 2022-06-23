using Approval_management.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Services.Interface
{
    public interface IRequestDetailService
    {
       Task< List<RequestDetail> >GetAllRequest();
       Task< List<RequestDetail>> GetRequestbyID(int id);
      int AddRequest(RequestDetail request);
        RequestDetail UpdateRequest(RequestDetail request);

        int DeleteRequest(int id);
    
    }
}
