using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;
using Approval_management.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Approval_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestDetailController : ControllerBase
    {
        private readonly IRequestDetailService _context;
        private readonly IMapper _mapper;

        public RequestDetailController(IRequestDetailService Request_DetailService, IMapper mapper)
        {
            _context = Request_DetailService;
            _mapper = mapper;

        }

        // GET: api/Books
        [HttpGet]
        //[Route("api/Requests")]
        public async Task< ActionResult<List<RequestDetailDto>>> GetAllRequest()
        {
            var user = await _context.GetAllRequest();
            var mappingResponse = _mapper.Map<List<RequestDetailDto>>(user);

            return mappingResponse;
        }


        //GET: api/RequestDetail/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task< ActionResult<IEnumerable<RequestDetail>>> GetRequestbyID(int id)
        {




            var req= await _context.GetRequestbyID(id);
            return req;
        }

        //// PUT: api/RequestDetail/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public ActionResult<RequestDetail> UpdateRequest(RequestDetail requestDetail)
        {


            return _context.UpdateRequest(requestDetail);
        }

        // POST: api/RequestDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public int AddRequest(RequestDetail requestDetail)
        {
            return _context.AddRequest(requestDetail);



        }

        //// DELETE: api/RequestDetail/5
        [HttpDelete("{id}")]
        public int DeleteRequest(int id)
        {
            return _context.DeleteRequest(id);

        }

        //private bool RequestDetailExists(int id)
        //{
        //    return _context.RequestDetails.Any(e => e.RequestId == id);
        //}
    }
}
