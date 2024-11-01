using HomeOutlays.Enums;
using HomeOutlays.Services;
using HomeOutlays.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeOutlays.Controllers
{
    public class OutlaysController : Controller
    {
        private readonly IOutlayService _outlayService;

        public OutlaysController(IOutlayService outlayService)
        {
            _outlayService = outlayService;
        }

        // GET: Outlays
        public async Task<IActionResult> Index()
        {
            return View(_outlayService.GetAll());
        }

        [HttpPost]
        public IActionResult GetFilteredOutlays(FilterRequest request)
        {
            var filteredOutlays = _outlayService.GetFilteredOutlays(request.Type);
            return Json(filteredOutlays);
        }


        // GET: Outlays/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var outlay = _outlayService.GetById(id);
            if (outlay == null)
            {
                return NotFound();
            }

            return View(outlay);
        }

        // GET: Outlays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Outlays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateOutlayVM createOutlayVM)
        {
            if (ModelState.IsValid)
            {
                _outlayService.Add(createOutlayVM.MapToModel());
                return RedirectToAction(nameof(Index));
            }
            return View(createOutlayVM);
        }

        // GET: Outlays/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var outlay = _outlayService.GetById(id);
            if (outlay == null)
            {
                return NotFound();
            }

            var editOutlayVM = new EditOutlayVM(outlay);
            return View(editOutlayVM);
        }

        // POST: Outlays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditOutlayVM editOutlayVM)
        {
            if (id != editOutlayVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _outlayService.Update(editOutlayVM.MapToModel());
                return RedirectToAction(nameof(Index));
            }
            return View(editOutlayVM);
        }

        // GET: Outlays/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var outlay = _outlayService.GetById(id);
            if (outlay == null)
            {
                return NotFound();
            }

            return View(outlay);
        }

        // POST: Outlays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var outlay = _outlayService.GetById(id);
            if (outlay != null)
            {
                _outlayService.Delete(outlay);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
