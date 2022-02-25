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
    public class MH_SUA_SAN_PHAMModel : PageModel
    {
        public product[] ds;
        public product hien_thi_sua;

        [BindProperty(SupportsGet =true)]
        public string Pid { get; set; }
        [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public string price { get; set; }
        public void OnGet()
        {
            hien_thi_sua = XL_product.hien_thi_sua(Pid);
        }
        public void OnPost()
        {
            hien_thi_sua = new product();
            ds = XL_product.sua(name, price, Pid);
            Response.Redirect("/MH_SAN_PHAM");
        }
    }
}
