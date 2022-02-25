using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using on_thi_ktlt.ENTITY;
using on_thi_ktlt.BUSSINESS;
using System.IO;
using Newtonsoft.Json;

namespace on_thi_ktlt.Pages.XOA_SUA
{
    public class MH_XOA_SAN_PHAMModel : PageModel
    {
        public product[] xoa;
        public product hien_thi_xoa;
        [BindProperty(SupportsGet = true)]
        public string Pid { get; set; }
        public void OnGet()
        {
            hien_thi_xoa = XL_product.hien_thi_xoa(Pid);

        }
        public void OnPost()
        {
            hien_thi_xoa = new product();
            xoa = XL_product.xoa(Pid);
            Response.Redirect("/MH_SAN_PHAM");
        }
    }
}
