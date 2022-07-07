using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.ServiceModel.DTO.Request
{
    public class changeStatusDto
    {
        public int RequestId { get; set; }
      
        public int? RequestStatus { get; set; }
     
    }
}
