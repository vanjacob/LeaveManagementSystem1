using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem1.Web.Data;
using AutoMapper;
using LeaveManagementSystem1.Web.Services;
using System.Runtime.InteropServices;


namespace LeaveManagementSystem1.Web.Controllers
{
    [Authorize(Roles = Roles.Supervisor)]
    public class LeaveTypesController(ILeaveTypesServices _leaveTypesServices) : Controller
    {
        private const string NameExistValidationMessage = "This leave type already exist in the database";
       


        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var viewData = await _leaveTypesServices.GetAllLeaveTypes();
            return View(viewData);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }         
            var leaveType = await _leaveTypesServices.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }
                return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {   
         
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreate)
        {
            //Adding custom validation and model state error 
            if (await _leaveTypesServices.CheckIfLeaveTypeNameExists(leaveTypeCreate.Name)) 
            {
                ModelState.AddModelError(nameof(leaveTypeCreate.Name), "This leave type already exist in the database");
            }
            
            if (ModelState.IsValid)
            {
                await _leaveTypesServices.Create(leaveTypeCreate);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeCreate);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypesServices.Get<LeaveTypeEditVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }
            return View(leaveType);
           
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeEditVM leaveTypeEdit)
        {
            if (id != leaveTypeEdit.Id)
            {
                return NotFound();
            }
            //Adding custom validation and model state error 
            if (await _leaveTypesServices.CheckIfLeaveTypeNameExistsForEdit(leaveTypeEdit))
            {
                ModelState.AddModelError(nameof(leaveTypeEdit.Name), NameExistValidationMessage);
            }

            if (ModelState.IsValid)      
            {
                try
                {
                    await _leaveTypesServices.Edit(leaveTypeEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_leaveTypesServices.LeaveTypeExists(leaveTypeEdit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeEdit);
        }

        


        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypesServices.Get<LeaveTypeDeleteVM>(id.Value);
            if (leaveType == null) 
            {
                return NotFound();
            }
            return View(leaveType);
            
            
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypesServices.Remove(id);
            return RedirectToAction(nameof(Index));
        }


        
    

}
}
