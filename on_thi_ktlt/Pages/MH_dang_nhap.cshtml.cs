using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using on_thi_ktlt.ENTITY;
using on_thi_ktlt.BUSSINESS;
using Microsoft.AspNetCore.Http;

namespace on_thi_ktlt.Pages
{
    public class MH_dang_nhapModel : PageModel
    {
        public nguoidung ds;
        public string chuoi;
        [BindProperty]
        public string id { get; set; }
        [BindProperty]
        public string pass { get; set; }
        public void OnGet()
        {
            chuoi = string.Empty;
        }
        public void OnPost()
        {
            ds = new nguoidung
            {
                id = id,
                pass = pass
            };
            nguoidung? user = XL_dangnhap.check_new(id, pass);

            if (user != null)
            {
                HttpContext.Session.SetString("user", user.id);
                Response.Redirect("/MH_SAN_PHAM");
            }

        }

    }

}