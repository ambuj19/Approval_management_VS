﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Approval_management.Services.Interface;
using Approval_management.DataModel.Entities;

namespace Approval_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestDetailController : ControllerBase
    {
        private readonly IRequestDetailService _context;

        public RequestDetailController(IRequestDetailService Request_DetailService)
        {
            _context = Request_DetailService;
        }

        // GET: api/Books
        [HttpGet]
        //[Route("api/Requests")]
        public ActionResult<IEnumerable<RequestDetail>> GetAllRequest()
        {
            return _context.GetAllRequest();
        }


        //GET: api/RequestDetail/5
        [HttpGet("{id}")]
        public  ActionResult<IEnumerable<RequestDetail>>GetRequestbyID(int id)
        {
           



            return _context.GetRequestbyID(id);
        }

        //// PUT: api/RequestDetail/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public ActionResult<RequestDetail> UpdateRequest( RequestDetail requestDetail)
        {


            return _context.UpdateRequest(requestDetail);
        }

        // POST: api/RequestDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public int AddRequest(RequestDetail requestDetail)
        {
          return  _context.AddRequest(requestDetail);
           

            
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