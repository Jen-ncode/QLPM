﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPMDAL;
using QLPMDTO;
namespace QLPMBUS
{
    public class ToathuocBUS
    {
        private ToathuocDAL ttDAL;
        public ToathuocBUS()
        {
            ttDAL = new ToathuocDAL();
        }
        public bool them(ToathuocDTO tt)
        {
            bool re = ttDAL.them(tt);
            return re;
        }
        public int autogenerate_matoa()
        {
            return ttDAL.autogenerate_matoa();
        }
        public List<ToathuocDTO> select()
        {
            return ttDAL.select();
        }
    }
}
