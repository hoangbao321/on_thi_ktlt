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
    public class MH_THEM_SAN_PHAMModel : PageModel
    {
        [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public string price { get; set; }
        public void OnPost()
        {
            var sp = new product();
            sp.name = name;
            sp.price = int.Parse(price);
            var ds = XL_product.add(sp);
            Response.Redirect("/MH_SAN_PHAM");
        }
    }
}
