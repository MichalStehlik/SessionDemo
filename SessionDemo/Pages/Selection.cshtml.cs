using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionDemo.Services;

namespace SessionDemo
{
    public class SelectionModel : PageModel
    {
        private SessionStorage<List<int>> _ss;
        public List<int> SelectedIds { get; set; }

        public SelectionModel(SessionStorage<List<int>> ss)
        {
            _ss = ss;
        }

        public void OnGet()
        {
            SelectedIds = _ss.LoadOrCreate("sd.s.key");
        }
    }
}