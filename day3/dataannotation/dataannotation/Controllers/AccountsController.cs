using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dataannotation.Models.EF;

namespace dataannotation.Controllers
{
    public class AccountsController : Controller
    {
        private readonly bankingDBContext _context = new bankingDBContext();

        //public AccountsController(bankingDBContext context)
        //{
        //    _context = context;
        //}

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
              return View(await _context.AccountInfos.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AccountInfos == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos
                .FirstOrDefaultAsync(m => m.AccNo == id);
            if (accountInfo == null)
            {
                return NotFound();
            }

            return View(accountInfo);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccNo,AccName,AccType,AccBalance,AccEmail,AccIsActive")] AccountInfo accountInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountInfo);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AccountInfos == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos.FindAsync(id);
            if (accountInfo == null)
            {
                return NotFound();
            }
            return View(accountInfo);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccNo,AccName,AccType,AccBalance,AccEmail,AccIsActive")] AccountInfo accountInfo)
        {
            if (id != accountInfo.AccNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountInfoExists(accountInfo.AccNo))
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
            return View(accountInfo);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AccountInfos == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos
                .FirstOrDefaultAsync(m => m.AccNo == id);
            if (accountInfo == null)
            {
                return NotFound();
            }

            return View(accountInfo);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AccountInfos == null)
            {
                return Problem("Entity set 'bankingDBContext.AccountInfos'  is null.");
            }
            var accountInfo = await _context.AccountInfos.FindAsync(id);
            if (accountInfo != null)
            {
                _context.AccountInfos.Remove(accountInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountInfoExists(int id)
        {
          return _context.AccountInfos.Any(e => e.AccNo == id);
        }
    }
}
