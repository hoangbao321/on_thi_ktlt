using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace on_thi_ktlt.Pages
{
    public class MH_DANG_XUATModel : PageModel
    {
        public void OnGet ()
        {
            HttpContext.Session.Remove("user");
            Response.Redirect("/MH_DANG_NHAP");
        }
    }
}
