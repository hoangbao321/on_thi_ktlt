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
    public class MH_dang_kyModel : PageModel
    {
        public int kiem_tra;
        public string chuoi;

        [BindProperty]
        public string pass { get; set; }
        [BindProperty]
        public string id { get; set; }
        public void OnPost()
        {
            var nguoidung = new nguoidung()
            {
                id=id,
                pass=pass
            };

            kiem_tra = XL_dangnhap.them_user(nguoidung);
            if (kiem_tra == 0)
            {
                chuoi = "co khoang trang";
            }
            else if (kiem_tra == 1)
            {
                chuoi = "bi trung";
            }
            else if (kiem_tra == 3)
            {
                chuoi = "dang ky thanh cong";
            }

        }
    }
}
