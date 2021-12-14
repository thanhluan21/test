using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wepchamcongversion1.Models;
using static wepchamcongversion1.Helper;

namespace wepchamcongversion1.Controllers
{
    public class MauNghiPhepsController : Controller
    {
        private readonly QLCHAMCONGContext _context = new QLCHAMCONGContext();

        // GET: MauNghiPheps
        public async Task<IActionResult> Index()
        {
            var qLCHAMCONGContext = _context.MauNghiPheps.Include(m => m.MaLoaiNghiPhepNavigation).Include(m => m.MaQuyTrinhPheDuyetNavigation);
            return View(await qLCHAMCONGContext.ToListAsync());
        }

        // GET: MauNghiPheps/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mauNghiPhep = await _context.MauNghiPheps
                .Include(m => m.MaLoaiNghiPhepNavigation)
                .Include(m => m.MaQuyTrinhPheDuyetNavigation)
                .FirstOrDefaultAsync(m => m.MaMauNghiPhep == id);
            if (mauNghiPhep == null)
            {
                return NotFound();
            }

            return View(mauNghiPhep);
        }

        // GET: MauNghiPheps/Create
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(string id = null)
        {
            if (id == null)
            {
                ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep");
                ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet");
                return View(new MauNghiPhep());
            }
            else
            {
                var mauNghiPhep = await _context.MauNghiPheps.FindAsync(id);
                if (mauNghiPhep == null)
                {
                    return NotFound();
                }
                ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep", mauNghiPhep.MaLoaiNghiPhep);
                ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet", mauNghiPhep.MaQuyTrinhPheDuyet);
                return View(mauNghiPhep);
            }
        }

        // POST: MauNghiPheps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: MauNghiPheps/Edit/5


        // POST: MauNghiPheps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(String id, [Bind("MaMauNghiPhep,TenMauNghiPhep,MaLoaiNghiPhep,YeuCauPheDuyet,MaQuyTrinhPheDuyet,GioiHanNgayNghi,ThoiHanXuLy,SoNgayTruocNgayNghi,GioiHanSoNgayNghi,QuiDinh,Xoa")] MauNghiPhep mauNghiPhep)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    _context.Add(mauNghiPhep);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(mauNghiPhep);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MauNghiPhepExists(mauNghiPhep.MaMauNghiPhep))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.MauNghiPheps.ToList()) });
            }
            ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep", mauNghiPhep.MaLoaiNghiPhep);
            ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet", mauNghiPhep.MaQuyTrinhPheDuyet);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", mauNghiPhep) });
        }

        /*      [NoDirectAccess]
              public async Task<IActionResult> AddOrEdit(string id = null)
              {
                  if (id == null)
                  {
                      ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep");
                      ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet");
                      return View(new MauNghiPhep());
                  }
                  else
                  {
                      var transactionModel = await _context.MauNghiPheps.FindAsync(id);
                      if (transactionModel == null)
                      {
                          return NotFound();
                      }
                      ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep");
                      ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet");
                      return View(transactionModel);
                  }
              }

              [HttpPost]
              [ValidateAntiForgeryToken]
              public async Task<IActionResult> AddOrEdit( string id,[Bind("TransactionId,AccountNumber,BeneficiaryName,BankName,SWIFTCode,Amount,Date")] MauNghiPhep transactionModel)
              {
                  if (ModelState.IsValid)
                  {
                      //Insert
                      if (id == null)
                      {
                          _context.Add(transactionModel);
                          await _context.SaveChangesAsync();

                      }
                      //Update
                      else
                      {
                          try
                          {
                              _context.Update(transactionModel);
                              await _context.SaveChangesAsync();
                          }
                          catch (DbUpdateConcurrencyException)
                          {
                              if (!MauNghiPhepExists(transactionModel.MaLoaiNghiPhep))
                              { return NotFound(); }
                              else
                              { throw; }
                          }
                      }
                      return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.MauNghiPheps.ToList()) });
                  }
                  ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep", transactionModel.MaLoaiNghiPhep);
                  ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet", transactionModel.MaQuyTrinhPheDuyet);
                  return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", transactionModel) });
              }






      */
        // GET: MauNghiPheps/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mauNghiPhep = await _context.MauNghiPheps
                .Include(m => m.MaLoaiNghiPhepNavigation)
                .Include(m => m.MaQuyTrinhPheDuyetNavigation)
                .FirstOrDefaultAsync(m => m.MaMauNghiPhep == id);
            if (mauNghiPhep == null)
            {
                return NotFound();
            }

            return View(mauNghiPhep);
        }

        // POST: MauNghiPheps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var mauNghiPhep = await _context.MauNghiPheps.FindAsync(id);
            _context.MauNghiPheps.Remove(mauNghiPhep);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.MauNghiPheps.ToList()) });
        }

        private bool MauNghiPhepExists(string id)
        {
            return _context.MauNghiPheps.Any(e => e.MaMauNghiPhep == id);
        }



        // POST: MauNghiPheps/Delete1/
        public async Task<IActionResult> Delete1(string id = null)
        {
            if (id == null)
            {
                ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep");
                ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet");
                return View(new MauNghiPhep());
            }
            else
            {
                var mauNghiPhep = await _context.MauNghiPheps.FindAsync(id);
                if (mauNghiPhep == null)
                {
                    return NotFound();
                }
                ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep", mauNghiPhep.MaLoaiNghiPhep);
                ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet", mauNghiPhep.MaQuyTrinhPheDuyet);
                return View(mauNghiPhep);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete1(String id, [Bind("MaMauNghiPhep,Xoa")] MauNghiPhep mauNghiPhep)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    _context.Add(mauNghiPhep);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        mauNghiPhep.Xoa = false;
                        _context.Update(mauNghiPhep);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MauNghiPhepExists(mauNghiPhep.MaMauNghiPhep))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.MauNghiPheps.ToList()) });
            }
            ViewData["TenLoaiNghiPhep"] = new SelectList(_context.LoaiNghiPheps, "MaLoaiNghiPhep", "TenLoaiNghiPhep", mauNghiPhep.MaLoaiNghiPhep);
            ViewData["TenQuyTrinhPheDuyet"] = new SelectList(_context.QuyTrinhPheDuyets, "MaQuyTrinhPheDuyet", "TenQuyTrinhPheDuyet", mauNghiPhep.MaQuyTrinhPheDuyet);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", mauNghiPhep) });
        }





















    }
}

