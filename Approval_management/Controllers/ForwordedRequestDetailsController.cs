using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Approval_management.DataModel.Entities;
using Approval_management.Services.Interface;
using AutoMapper;
using Approval_management.ServiceModel.DTO.Request;
using Approval_management.ServiceModel.DTO.Response;

namespace Approval_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForwordedRequestDetailsController : ControllerBase
    {
        private readonly IForwardRequestService _forwardRequestService ;
        private readonly IMapper _mapper;
        public ForwordedRequestDetailsController(IForwardRequestService forwardRequestService, IMapper mapper)
        {
            _forwardRequestService = forwardRequestService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<ForwordedRequestDetail> addForwardRequest(forwardDto request)
        {
            var response = _mapper.Map<ForwordedRequestDetail>(request);
            return await _forwardRequestService.addForwardRequest(response);
            
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<GetForwadedRequestDto>>> GetAllRequest(int id)
        {
        //    return await _forwardRequestService.GetAllRequest();
            var user = await _forwardRequestService.GetAllRequest( id);
            var mappingResponse = _mapper.Map<List<GetForwadedRequestDto>>(user);

            return mappingResponse;

            // var mappingResponse = _mapper.Map<List<RequestDetailDto>>(user);


        }
        [HttpPut("{ForwadedRequestId}/{Status}")]
        public async Task<int> changeStatus(int ForwadedRequestId, int Status)
        {
            //   var response = _mapper.Map<RequestDetail>(id,status);

            return await _forwardRequestService.changeStatus(ForwadedRequestId, Status);
        }
        [HttpPut("RejectionCommentBySuperManager/{ForwadedRequestId}/{Comment}")]

        public async Task<int> RejectionCommentBySuperManager(int ForwadedRequestId, string Comment)
        {
            return await _forwardRequestService.RejectionCommentBySuperManager(ForwadedRequestId, Comment);
        }
    }
}
