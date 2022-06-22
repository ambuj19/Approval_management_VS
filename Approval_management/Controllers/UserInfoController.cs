using Approval_management.DataModel.DTO;
using Approval_management.DataModel.Entities;
using Approval_management.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Approval_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService _context;
        private readonly IMapper _mapper;

        public UserInfoController(IUserInfoService context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Books
        [Authorize]
        [HttpGet]
        //[Route("api/Requests")]
        public ActionResult<List<UserInfoDto>> GetAllRequest()
        {
            var user = _context.GetAllUserInfo();
            var mappingResponse = _mapper.Map<List<UserInfoDto>>(user);
            return mappingResponse;
        }

        // GET: UserInfo/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var userInfo = await _context.UserInfos
        //            .FirstOrDefaultAsync(m => m.UserId == id);
        //        if (userInfo == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(userInfo);
        //    }

        //    // GET: UserInfo/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: UserInfo/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("UserId,UserName,Password,FullName,EmailId,Designation,ManagerId,IsManager,IsDeleted")] UserInfo userInfo)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(userInfo);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(userInfo);
        //    }

        //    // GET: UserInfo/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var userInfo = await _context.UserInfos.FindAsync(id);
        //        if (userInfo == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(userInfo);
        //    }

        //    // POST: UserInfo/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password,FullName,EmailId,Designation,ManagerId,IsManager,IsDeleted")] UserInfo userInfo)
        //    {
        //        if (id != userInfo.UserId)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(userInfo);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!UserInfoExists(userInfo.UserId))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(userInfo);
        //    }

        //    // GET: UserInfo/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var userInfo = await _context.UserInfos
        //            .FirstOrDefaultAsync(m => m.UserId == id);
        //        if (userInfo == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(userInfo);
        //    }

        //    // POST: UserInfo/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var userInfo = await _context.UserInfos.FindAsync(id);
        //        _context.UserInfos.Remove(userInfo);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool UserInfoExists(int id)
        //    {
        //        return _context.UserInfos.Any(e => e.UserId == id);
        //    }
    }
}
