using Approval_management.DataModel.Entities;
using Approval_management.ServiceModel.DTO.Request;
using Approval_management.ServiceModel.DTO.Response;
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
        //[Authorize()]
        //[Route("api/Requests")]
        public async Task<ActionResult<List<RequestDetailDto>>> GetAllRequest()
        {
            var user = await _context.GetAllRequest();
            var mappingResponse = _mapper.Map<List<RequestDetailDto>>(user);

            return mappingResponse;
        }


        //GET: api/RequestDetail/5
       
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<RequestDetail>>> GetRequestbyID(int id)
        {
            var req = await _context.GetRequestbyID(id);
            return req;
        }


        //GET: api/RequestDetail/5

        [HttpGet("GetRequest/{id}")]
        public RequestDetail GetRequest(int id)
        {
            var req = _context.GetRequest(id);
            return req;
        }
        [HttpGet("GetRequest/{id}/{status}")]
        public async Task<ActionResult<IEnumerable<RequestDetail>>> RequestStatus(int id,int status)
        {
            var req = await _context.RequestStatus(id, status);
            return req;
        }

        
        [HttpPut("{RequestId}/{Status}")]
        public async  Task<int> changeStatus(int RequestId, int Status)
        {
         //   var response = _mapper.Map<RequestDetail>(id,status);
         
            return await _context.changeStatus(RequestId, Status);
        }

        [HttpGet("Managerlogin/{id}")]
        public async Task<ActionResult<List<RequestDetail>>> Managerlogin(int id)
        {
            var req =await _context.Managerlogin(id);
            return req;
        }

        //// PUT: api/RequestDetail/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        //public async Task<RequestUpdateDto> UpdateRequest(RequestUpdateDto requestDetail)
        //{

        //    var response = _mapper.Map<RequestDetail>(requestDetail);
        //    var requestNew = await _context.UpdateRequest(response);
        //    var requestDetails = _mapper.Map<RequestUpdateResponse>(requestNew);

        //    return Ok
        //    //return _context.UpdateRequest(requestDetail);
        //}
        public async Task<int> UpdateRequest([FromBody] RequestUpdateDto requestDetail)
        {
            var response = _mapper.Map<RequestDetail>(requestDetail);
            return await _context.UpdateRequest(response);
        }

        [HttpPut("RejectionCommentByManager/{RequestId}/{Comment}")]

    public async Task<int> RejectionCommentByManager(int RequestId, string Comment)
        {
            return await _context.RejectionCommentByManager(RequestId, Comment);
        }


        // POST: api/RequestDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RequestAddDto>> AddRequest(RequestAddDto requestDetail)
        {
            var response = _mapper.Map<RequestDetail>(requestDetail);
            var requestNew = await _context.AddRequest(response);
            var requestDetails = _mapper.Map<RequestDetailResponseDto>(requestNew);
            return Ok(requestDetails);

            //var user = await _context.AddRequest(requestDetail);
            //var mappingResponse = _mapper.Map<List<RequestDetailDto>>(user);
            //return _context.AddRequest(requestDetail);



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
