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
    public class XL_dangnhap
    {
        public static nguoidung[] doc()
        {
            return LT_dangnhap.doc();
        }
        public static void ghi(nguoidung[] user)
        {
            LT_dangnhap.ghi(user);
        }
        public static nguoidung? check_new(string id, string password)
        {
           nguoidung[] ds_user = doc();
            for (int i = 0; i < ds_user.Length; i++)
            {
                if (ds_user[i].id == id && ds_user[i].pass == password)
                {
                    return ds_user[i];
                }
            }
            return null;
        }
        public static int them_user(nguoidung user)
        {
            var ds = doc();
            if (string.IsNullOrWhiteSpace(user.id) || string.IsNullOrWhiteSpace(user.pass))
            {
                return 0;
            }

            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].id == user.id)
                {
                    return 1;
                }
            }

            var kq_add = new nguoidung[ds.Length + 1];
            for (int i = 0; i < ds.Length; i++)
            {
                kq_add[i] = ds[i];
            }
            user.stt = ds.Length + 1;
            kq_add[kq_add.Length - 1] = new nguoidung();

            kq_add[^1].id = user.id;
            kq_add[kq_add.Length - 1].stt = user.stt;
            kq_add[kq_add.Length - 1].pass = user.pass;
            ghi(kq_add);
            return 3;
        }
    }
}
