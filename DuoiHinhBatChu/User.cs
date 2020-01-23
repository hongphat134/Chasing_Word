using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoiHinhBatChu
{
    [Serializable]
    class User
    {
        private int ma;

        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        private double diem;

        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        public User() { }
        public User(int code,string name,double point)
        {
            ma = code;
            ten = name;
            diem = point;
        }
    }
}
