using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using on_thi_ktlt.ENTITY;
using on_thi_ktlt.DAS;
using System.IO;
using Newtonsoft.Json;

namespace on_thi_ktlt.BUSSINESS
{
    public class XL_product
    {
        public static void ghi_san_pham(product[] sp)
        {
            LT_product.ghi_san_pham(sp);
        }
        public static product[] doc_san_pham()
        {
            return LT_product.doc_san_pham();
        }
        public static product[] tim_san_pham(string tu_khoa = "")
        {
            var ds = doc_san_pham();
            product[] kq;
            int N = 0;
            if (tu_khoa == null)
            {
                kq = new product[ds.Length];
                for (int i = 0; i < ds.Length; i++)
                {
                    kq[i] = ds[i];
                }
            }
            else
            {
                for (int i = 0; i < ds.Length; i++)
                {
                    if (ds[i].name.Contains(tu_khoa))
                    {
                        N++;
                    }
                }
                kq = new product[N];
                int j = 0;
                for (int i = 0; i < ds.Length; i++)
                {
                    if (ds[i].name.Contains(tu_khoa))
                    {
                        kq[j] = ds[i];
                        j++;
                    }
                }
            }
            return kq;
        }
        public static product[] add(product sp)
        {
            product[] ds = doc_san_pham();
            product[] kq = new product[ds.Length + 1];
            int j = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                kq[j] = ds[i];
                j++;
            }
            if (ds.Length == 0)
            {
                sp.id = 1;
            }
            else
            {
                //sp.id = ds[ds.Length - 1].id + 1;
                //kq[kq.Length - 1] = sp;
                //kq[kq.Length - 1].id = ds[ds.Length-1].id + 1;

                kq[kq.Length - 1] = new product();
                kq[kq.Length - 1].name =sp.name;
                kq[kq.Length - 1].id = ds[ds.Length-1].id + 1;
                kq[kq.Length - 1].price = sp.price;
            }
            ghi_san_pham(kq);
            return kq;

        }
        public static product[] xoa(string Pid)
        {
            var ds = doc_san_pham();
            product[] kq = new product[ds.Length - 1];
            int j = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].id != int.Parse(Pid))
                {
                    kq[j] = ds[i];
                    j++;
                }
            }
            ghi_san_pham(kq);
            return kq;
        }
        public static product hien_thi_xoa(string Pid)
        {
            var ds = doc_san_pham();
            product kq = new product();
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].id.ToString().Contains(Pid))
                {
                    kq.name = ds[i].name;
                }
            }
            return kq;
        }
        public static product hien_thi_sua(string Pid)
        {
            var ds = doc_san_pham();
            product kq = new product();
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].id.ToString().Contains(Pid))
                {
                    kq.name = ds[i].name;
                    kq.price = ds[i].price;
                }
            }
            return kq;
        }
        public static product[] sua(string name, string price, string Pid)
        {
            product[] ds = doc_san_pham();
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].id.ToString().Contains(Pid))
                {
                    ds[i].name = name;
                    ds[i].price = int.Parse(price);
                }
            }
            ghi_san_pham(ds);
            return ds;
        }
    }
}
