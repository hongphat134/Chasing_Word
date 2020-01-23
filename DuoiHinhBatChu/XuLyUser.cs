using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DuoiHinhBatChu
{
    class XuLyUser
    {
        private List<User> list;

        internal List<User> List
        {
            get { return list; }
            set { list = value; }
        }

        public XuLyUser()
        {
            list = new List<User>();
        }

        public void them(User usr)
        {
            list.Add(usr);
        }

        public List<User> SapXep()
        {
            List<User> dsct=new List<User>();
            
            int vitrixoa;
            double Max;
            do
            {
                vitrixoa = 0;
                Max= list[0].Diem;
                User usr = new User();
                usr = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (Max< list[i].Diem)
                    {
                        Max = list[i].Diem;
                        usr = list[i];
                        vitrixoa = i;
                    }
                }
                dsct.Add(usr);
                list.RemoveAt(vitrixoa);

            } while (list.Count!=0);
            return dsct;
        }

        public List<User> DocFile(string tenfile)
        {
            FileStream fs = new FileStream(tenfile, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            list = (List<User>)bf.Deserialize(fs);
            fs.Close();
            return list;

        }

        public void GhiFile(string tenfile)
        {
            FileStream fs = new FileStream(tenfile, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();           
        }
    }
}
