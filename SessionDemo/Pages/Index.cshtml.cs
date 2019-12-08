using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SessionDemo.Models;
using SessionDemo.Services;

namespace SessionDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DataStorage _ds;
        private SessionStorage<List<int>> _ss;

        public List<Student> Students { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DataStorage ds, SessionStorage<List<int>> ss)
        {
            _logger = logger;
            _ds = ds;
            _ss = ss;
        }

        public void OnGet()
        {
            Students = _ds.FetchStudents();
        }

        public IActionResult OnGetStore(int id)
        {
            List<int> sel = _ss.LoadOrCreate("sd.s.key");
            sel.Add(id);
            _ss.Save("sd.s.key", sel);
            return RedirectToPage("Index");
        }
    }
}
