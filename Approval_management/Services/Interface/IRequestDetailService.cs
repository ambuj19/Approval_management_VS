using Approval_management.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Approval_management.Services.Interface
{
    public interface IRequestDetailService
    {
        List<RequestDetail> GetAllRequest();
        List<RequestDetail> GetRequestbyID(int id);
      int AddRequest(RequestDetail request);
        RequestDetail UpdateRequest(RequestDetail request);

        int DeleteRequest(int id);
    
    }
}
