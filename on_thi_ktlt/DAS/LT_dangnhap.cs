using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using on_thi_ktlt.ENTITY;
using System.IO;
using Newtonsoft.Json;

namespace on_thi_ktlt.DAS
{
    public class LT_dangnhap
    {
        public static nguoidung[] doc()
        {
            var duongdan = ".\\du_lieu\\dangnhap.json";
            StreamReader f = new StreamReader(duongdan);
            string content = f.ReadLine();
            var user = JsonConvert.DeserializeObject<nguoidung[]>(content);
            f.Close();
            return user;
        }
        public static void ghi(nguoidung[] user)
        {
            var duongdan = ".\\du_lieu\\dangnhap.json";
            StreamWriter f = new StreamWriter(duongdan);
            string content = JsonConvert.SerializeObject(user);
            f.WriteLine(content);
            f.Close();
        }
    }
}
