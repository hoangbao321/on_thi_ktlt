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

namespace on_thi_ktlt.Pages
{
    public class MH_SAN_PHAMModel : PageModel
    {
        public product[] ds;
        [BindProperty]
        public string tu_khoa { get; set; }
        public void OnGet()
        {
            ds = XL_product.tim_san_pham(tu_khoa);
        }
        public void OnPost()
        {
            ds = XL_product.tim_san_pham(tu_khoa);
        }
    }
}
