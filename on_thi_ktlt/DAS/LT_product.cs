using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using on_thi_ktlt.ENTITY;
using System.IO;
using Newtonsoft.Json;


namespace on_thi_ktlt.DAS
{
    public class LT_product
    {
        public static product[] doc_san_pham()
        {
            var duong_dan = ".\\du_lieu\\product.json";
            StreamReader f = new StreamReader(duong_dan);
            string content = f.ReadLine();
            product[] sp = JsonConvert.DeserializeObject<product[]>(content);
            f.Close();
            return sp;
        }
        public static void ghi_san_pham(product[] sp)
        {
            var duong_dan = ".\\du_lieu\\product.json";
            StreamWriter f = new StreamWriter(duong_dan);
            string content = JsonConvert.SerializeObject(sp);
            f.WriteLine(content);
            f.Close();
        }
    }
}
