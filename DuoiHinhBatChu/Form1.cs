using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoiHinhBatChu
{
    public partial class DuoiHinhBatChu : Form
    {

        
        public DuoiHinhBatChu()
        {
            InitializeComponent();
        }

        XuLyUser ListUsr;
        User usr;
        string[] ListPtr;
        int index;
        int[] ListUsed;
        int indexUsed;
        string[] KetQua = {
                              "BAOLA",
                              "KINHDO",
                              "HUNGTHU",
                              "TINHTRUONG",
                              "BAOQUAT",
                              "CAUVONG",
                              "NHACCU",
                              "NOITHAT",
                              "DAUTHU",
                              "NOIGIAN",
                              "BADONG",
                              "AIMO",
                              "BAOTU",
                              "LUCLAC",
                              "THOO",
                              "CHIDIEM",
                              "CONGTRAI",
                              "OMAI",
                              "BIQUAN",
                              "BAODONG",
                              "NOKIA",
                              "GACHHOA",
                              "BAIBAC",
                              "GIACAY",
                              "TIEUTHUONG",
                              "GUONGCAU",
                              "TINHXO",
                              "MATTHIET",
                              "DACUOI",
                              "DAUGAU"                           
                          };
        double[,] Diem = { {10,2},
                            {20,3},
                            {30,4},
                            {40,5},
                            {50,6},
                            {60,7},
                            {70,8},
                            {80,9},
                            {90,10},
                            {100,15},
                            {120,20},
                            {150,25},
                            {180,30},
                            {220,40},
                            {250,50},
                            {300,60},
                            {400,70},
                            {500,80},
                            {650,100},
                            {800,120},
                            {1000,150},
                            {1250,200},
                            {1500,250},
                            {1800,300},
                            {2100,350},
                            {2450,420},
                            {2800,490},
                            {3200,570},
                            {3800,750},
                            {5000,1000}
                        };
        TextBox[] ListTxt;
        Button[] Listbtn;
        Random r;


        
        
        double TongDiem;
        double TongXu;
        int TimeLeft;

        private void GameStart()
        {
            
            TongDiem = 0;
            TongXu = 20000;
            indexUsed = 0;
            TimeLeft = 179;
            lblPoint.Text = "Tổng điểm : "+TongDiem.ToString();
            lblCoin.Text = "Tổng xu : " + TongXu.ToString();
            ListPtr = new string[30];
            ListUsed = new int[ListPtr.Length];

            timerLeft.Start();
           
            for (int i = 0; i < ListPtr.Length; i++)
            {
                ListPtr[i] = "image/" + (i + 1) + ".jpg";

            }

            r = new Random();
            index = r.Next(0, ListPtr.Length);

           

            ptrDHBC.Image = Image.FromFile(ListPtr[index]);
            ListUsed[indexUsed++] = index;
            ptrDHBC.SizeMode = PictureBoxSizeMode.StretchImage;

            lblQuestion.Text = "Câu hỏi số " + indexUsed.ToString() + " (" + Diem[indexUsed-1, 0].ToString() + " điểm, " + Diem[indexUsed-1, 1].ToString() + " xu)";
            Size size = new Size(50, 30);




            Listbtn = new Button[KetQua[index].Length * 2];
            Listbtn[0] = new Button();
            Listbtn[0].Location = new Point(ptrDHBC.Location.X + ptrDHBC.Size.Width + 30, ptrDHBC.Location.Y);
            Listbtn[0].Size = size;
            Listbtn[0].Click += DuoiHinhBatChu_Btn_Click;
            Listbtn[0].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDHBC.Controls.Add(Listbtn[0]);

            Listbtn[1] = new Button();
            Listbtn[1].Location = new Point(ptrDHBC.Location.X + ptrDHBC.Size.Width + 80, ptrDHBC.Location.Y);
            Listbtn[1].Size = size;
            Listbtn[1].Click += DuoiHinhBatChu_Btn_Click;
            Listbtn[1].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDHBC.Controls.Add(Listbtn[1]);

            for (int i = 2; i < Listbtn.Length; i++)
            {
                Listbtn[i] = new Button();
                Listbtn[i].Location = new Point(Listbtn[i - 2].Location.X, Listbtn[i - 2].Location.Y + 40);
                Listbtn[i].Size = size;
                Listbtn[i].Click += DuoiHinhBatChu_Btn_Click;
                Listbtn[i].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
                this.pnlDHBC.Controls.Add(Listbtn[i]);

            }
            Size size_txt = new Size(30, 30);

            ListTxt = new TextBox[KetQua[index].Length];
            ListTxt[0] = new TextBox();
            ListTxt[0].Location = new Point(ptrDHBC.Location.X, ptrDHBC.Location.Y + ptrDHBC.Size.Height + 20);
            ListTxt[0].Size = size_txt;
            ListTxt[0].Click += DuoiHinhBatChu_Click;
            ListTxt[0].ReadOnly = true;
            ListTxt[0].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            ListTxt[0].TextAlign = HorizontalAlignment.Center;

            this.pnlDHBC.Controls.Add(ListTxt[0]);

            for (int i = 1; i < ListTxt.Length; i++)
            {
                ListTxt[i] = new TextBox();
                ListTxt[i].Location = new Point(ListTxt[i - 1].Location.X + 40, ptrDHBC.Location.Y + ptrDHBC.Size.Height + 20);
                
                ListTxt[i].Size = size_txt;
                ListTxt[i].TextAlign = HorizontalAlignment.Center;
                ListTxt[i].Click += DuoiHinhBatChu_Click;
                ListTxt[i].ReadOnly = true;
                ListTxt[i].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
                this.pnlDHBC.Controls.Add(ListTxt[i]);
            }

            int ChuCaiNgauNhien;
            bool KiemTraTrung;
            for (int i = 0; i < KetQua[index].Length; i++)
            {
                do
                {
                    KiemTraTrung = true;
                    ChuCaiNgauNhien = r.Next(0, Listbtn.Length);
                    if (Listbtn[ChuCaiNgauNhien].Text == "") Listbtn[ChuCaiNgauNhien].Text = KetQua[index][i].ToString();
                    else KiemTraTrung = false;

                } while (!KiemTraTrung);
            }

            foreach (Button btn in Listbtn)
            {
                if (btn.Text == "")
                {
                    ChuCaiNgauNhien = r.Next(65, 91);
                    char chucai = (char)ChuCaiNgauNhien;
                    btn.Text = chucai.ToString();

                }
            }
            Button Exit = new Button();
            Exit.Size = new System.Drawing.Size(100, 50);
            Exit.Location = new Point(560, 389);
            Exit.Text = "Bỏ cuộc";
            Exit.BackColor = Color.Goldenrod;
            Exit.ForeColor = Color.Fuchsia;
            Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Exit.Click += Exit_Click;
            pnlDHBC.Controls.Add(Exit);
        }

        void Exit_Click(object sender, EventArgs e)
        {
            
            pnlDHBC.Visible = false;
            foreach (TextBox txt in ListTxt)
            {
                pnlDHBC.Controls.Remove(txt);
            }

            foreach (Button btn in Listbtn)
            {
                pnlDHBC.Controls.Remove(btn);
            }

            Label lblThanhTich = new Label();
            lblThanhTich.Size = new System.Drawing.Size(300, 35);

            lblThanhTich.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblThanhTich.Location = new Point(130, 200);
            lblThanhTich.Text = "Thành tích: " + TongDiem.ToString() + " điểm!";

            Label lblName = new Label();
            lblName.Size = new System.Drawing.Size(80, 25);
            
            lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new Point(130, 250);
            lblName.Text = "Họ & tên :";

            TextBox Name = new TextBox();
            Name.Multiline = true;
            Name.MaxLength = 18;
            Name.Size = new System.Drawing.Size(200, 25);
            Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name.Location = new Point(250, 250);
            Name.KeyPress += Name_KeyPress;
            Controls.Add(lblThanhTich);
            Controls.Add(lblName);
            Controls.Add(Name);
        }

        void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar==Keys.Enter)
            {
                
                ListUsr = new XuLyUser();
                
                ListUsr.List = ListUsr.DocFile("ListPlayer.bat");
                usr = new User(ListUsr.List.Count, ((TextBox)sender).Text, TongDiem);
                ListUsr.them(usr);
                for (int i = 0; i < Controls.Count; i++)
                {
                    if ( Controls[i] == sender || Controls[i].Name == "pnlDHBC") continue;
                    else if (Controls[i] is Button)
                    {
                        if (Controls[i].Name == "btnPlay" || Controls[i].Name == "btnRanKing") Controls[i].Visible = false;
                        else if (Controls[i].Name == "btnBack") Controls[i].Visible = true;
                    }
                    
                    else
                    {
                        Controls.Remove(Controls[i]);
                        i--;
                    }
                }
                

                 Label Ranking = new Label();
                 Ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                 Ranking.Location = new Point(229, 93);
                 Ranking.Size = new Size(175, 38);
                 Ranking.Text = "BẢNG XẾP HẠNG";
                 Ranking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                 Controls.Add(Ranking);
                 //Tạo phụ dề


                 Label Hang = new Label();
                 Hang.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 Hang.Size = new System.Drawing.Size(100, 30);
                 Hang.Location = new System.Drawing.Point(85, 143);
                 Hang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                 Hang.Text = "Hạng";
                 Controls.Add(Hang);

                 Label TenNgChoi = new Label();
                 TenNgChoi.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 TenNgChoi.Size = new System.Drawing.Size(120, 30);
                 TenNgChoi.Location = new System.Drawing.Point(244, 143);
                 TenNgChoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                 TenNgChoi.Text = "Tên người chơi";
                 Controls.Add(TenNgChoi);

                 Label Diem = new Label();
                 Diem.Size = new System.Drawing.Size(100, 30);
                 Diem.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 Diem.Location = new System.Drawing.Point(417, 143);
                 Diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                 Diem.Text = "Điểm";
                 Controls.Add(Diem);
                 //Tạo bảng chứa
                 Panel BangChua = new Panel();
                 BangChua.Name = "pnlRankPoint";

                 BangChua.AutoScroll = true;
                 BangChua.Location = new System.Drawing.Point(69, 174);
                 BangChua.Size = new System.Drawing.Size(470, 225);
                 Controls.Add(BangChua);

                 ListUsr.List = ListUsr.SapXep();

                 int CanChinh = 0;
                 for (int i = 0; i < ListUsr.List.Count; i++)
                 {                     
                     Label Rank = new Label();                
                     Rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
                     Rank.Location = new System.Drawing.Point(5, 13 + CanChinh);
                     Rank.Size = new System.Drawing.Size(120, 30);
                     Rank.Text = (i + 1).ToString();
                     Rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                     Label Name = new Label();
                     Name.Location = new System.Drawing.Point(125, 13 + CanChinh);
                     Name.Size = new System.Drawing.Size(205, 30);
                     Name.Text = ListUsr.List[i].Ten;
                     Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                     Label Point = new Label();
                     Point.Location = new System.Drawing.Point(330, 13 + CanChinh);                   
                     Point.Size = new System.Drawing.Size(120, 30);
                     Point.Text = ListUsr.List[i].Diem.ToString();
                     Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                     if (i == 0)
                     {
                         Rank.ForeColor = Color.Red;
                         Rank.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Name.ForeColor = Color.Red;
                         Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Point.ForeColor = Color.Red;
                         Point.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                     }
                     else if(i==1)
                     {
                         Rank.ForeColor = Color.YellowGreen;
                         Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Name.ForeColor = Color.YellowGreen;
                         Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Point.ForeColor = Color.YellowGreen;
                         Point.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                     }
                     else if(i==2)
                     {
                         Rank.ForeColor = Color.BlueViolet;
                         Rank.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Name.ForeColor = Color.BlueViolet;
                         Name.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                         Point.ForeColor = Color.BlueViolet;
                         Point.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                     }
                     else{
                         Rank.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                         Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                         Point.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                     }

                     if(ListUsr.List[i].Ma==usr.Ma)
                     {
                         Rank.BackColor = Color.Orange;
                         Point.BackColor = Color.Orange;
                         Name.BackColor = Color.Orange;
                     }
                     BangChua.Controls.AddRange(new Control[] { Name, Point, Rank });
                     CanChinh += 30;
                     // 
                 }

                 ListUsr.GhiFile("ListPlayer.bat");
                 Controls.Remove((Control)sender);
            }

        }
        
        void DuoiHinhBatChu_Click(object sender, EventArgs e)
        {
            
            foreach (Button btn in Listbtn)
            {
                if (!btn.Visible && btn.Text == ((TextBox)sender).Text)
                {
                    btn.Visible = true; break;
                }
            }
            ((TextBox)sender).ResetText();
            
            
        }

        void DuoiHinhBatChu_Btn_Click(object sender, EventArgs e)
        {
            int EndPoint=0;
            for(int i=0;i<ListTxt.Length;i++)
            {
                if (ListTxt[i].Text == "")
                {
                    ListTxt[i].Text = ((Button)sender).Text;
                    EndPoint=i;
                    break;
                }
            }
            
            ((Button)sender).Visible = false;
            if(EndPoint==ListTxt.Length-1)
            {
                CheckResult(sender, e);                                         
            }            
          }

        private void CheckResult(object sender, EventArgs e)
        {
            string Kq = "";
            foreach (TextBox txt in ListTxt)
            {
                Kq += txt.Text;
            }
            if (Kq == KetQua[index])
            {
                if (indexUsed == ListPtr.Length)
                {
                   
                    TongDiem += Diem[indexUsed - 1, 0];
                    TongXu += Diem[indexUsed - 1, 1];
                    lblCoin.Text = "Tổng xu : " + TongXu.ToString();
                    lblPoint.Text = "Tổng điểm : " + TongDiem.ToString();
                    MessageBox.Show("You Won with ToTal Point: " + TongDiem.ToString() + ",Tổng xu còn dư: "+TongXu.ToString()+"!");
                    Exit_Click(sender, e);
                }
                else
                {
                    
                    
                    lblCoin.Text = "Tổng xu : " + TongXu.ToString();
                    TongDiem += Diem[indexUsed - 1, 0];
                    TongXu += Diem[indexUsed - 1, 1];
                    MessageBox.Show("Đúng rồi!");
                    lblPoint.Text = "Tổng điểm : " + TongDiem.ToString();
                    
                    NextQuestion();
                }
            }
            else   MessageBox.Show("Sai rồi!");                         
        }

       

        private void NextQuestion()
        {
            bool Check;
            r = new Random();
            do
            {
                Check = true;
                index = r.Next(0, ListPtr.Length);

                for (int i = 0; i < indexUsed; i++)
                {
                    if (ListUsed[i] == index)
                    {
                        Check = false;
                        break;
                    }
                }
            } while (!Check);

            TimeLeft = 179;
            timerLeft.Start();
            
            foreach (TextBox txt in ListTxt)
            {
                pnlDHBC.Controls.Remove(txt);
            }

            foreach (Button btn in Listbtn)
            {
                pnlDHBC.Controls.Remove(btn);
            }

            Size size = new Size(50, 30);


            Listbtn = new Button[KetQua[index].Length * 2];
            Listbtn[0] = new Button();
            Listbtn[0].Location = new Point(ptrDHBC.Location.X + ptrDHBC.Size.Width + 30, ptrDHBC.Location.Y);
            Listbtn[0].Size = size;
            Listbtn[0].Click += DuoiHinhBatChu_Btn_Click;
            Listbtn[0].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            this.pnlDHBC.Controls.Add(Listbtn[0]);

            Listbtn[1] = new Button();
            Listbtn[1].Location = new Point(ptrDHBC.Location.X + ptrDHBC.Size.Width + 80, ptrDHBC.Location.Y);
            Listbtn[1].Size = size;
            Listbtn[1].Click += DuoiHinhBatChu_Btn_Click;
            Listbtn[1].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            this.pnlDHBC.Controls.Add(Listbtn[1]);

            

            for (int i = 2; i < Listbtn.Length; i++)
            {
                Listbtn[i] = new Button();
                Listbtn[i].Location = new Point(Listbtn[i - 2].Location.X, Listbtn[i - 2].Location.Y + 30);
                Listbtn[i].Size = size;
                Listbtn[i].Click += DuoiHinhBatChu_Btn_Click;
                Listbtn[i].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
                this.pnlDHBC.Controls.Add(Listbtn[i]);

            }

            System.Drawing.Size size_txt = new Size(30, 30);
            ListTxt = new TextBox[KetQua[index].Length];
            ListTxt[0] = new TextBox();
            ListTxt[0].Location = new Point(ptrDHBC.Location.X, ptrDHBC.Location.Y + ptrDHBC.Size.Height + 20);
            ListTxt[0].Size = size_txt;
            ListTxt[0].Click += DuoiHinhBatChu_Click;
            ListTxt[0].TextAlign = HorizontalAlignment.Center;
            ListTxt[0].ReadOnly = true;
            ListTxt[0].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           

            this.pnlDHBC.Controls.Add(ListTxt[0]);

            for (int i = 1; i < ListTxt.Length; i++)
            {
                ListTxt[i] = new TextBox();
                ListTxt[i].Location = new Point(ListTxt[i - 1].Location.X + 40, ptrDHBC.Location.Y + ptrDHBC.Size.Height + 20);
                ListTxt[i].Size = size_txt;
                ListTxt[i].Click += DuoiHinhBatChu_Click;
                ListTxt[i].TextAlign = HorizontalAlignment.Center;
                ListTxt[i].ReadOnly = true;
                ListTxt[i].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                this.pnlDHBC.Controls.Add(ListTxt[i]);
            }


            int ChuCaiNgauNhien;
            bool KiemTraTrung;
            for (int i = 0; i < KetQua[index].Length; i++)
            {
                do
                {
                    KiemTraTrung = true;
                    ChuCaiNgauNhien = r.Next(0, Listbtn.Length);
                    if (Listbtn[ChuCaiNgauNhien].Text == "") Listbtn[ChuCaiNgauNhien].Text = KetQua[index][i].ToString();
                    else KiemTraTrung = false;

                } while (!KiemTraTrung);
            }

            foreach (Button btn in Listbtn)
            {
                if (btn.Text == "")
                {
                    ChuCaiNgauNhien = r.Next(65, 91);
                    char chucai = (char)ChuCaiNgauNhien;
                    btn.Text = chucai.ToString();

                }
            }

            ptrDHBC.Image = Image.FromFile(ListPtr[index]);
            ptrDHBC.SizeMode = PictureBoxSizeMode.StretchImage;
            ListUsed[indexUsed++] = index;
            lblQuestion.Text = "Câu hỏi số " + indexUsed.ToString() + " (" + Diem[indexUsed - 1, 0].ToString() + " điểm, " + Diem[indexUsed - 1, 1].ToString() + " xu)";
        }
      

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameStart();
            pnlDHBC.Visible = true;
            pnlDHBC.Dock = DockStyle.Fill;
            btnRanKing.Visible = false;
            btnPlay.Visible = false;                    
        }

        private void btnRanKing_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
           
            ListUsr = new XuLyUser();
            ListUsr.List = ListUsr.DocFile("ListPlayer.bat");
            
            for(int i=0;i<Controls.Count;i++)
            {
                
                if (Controls[i] is Button)
                {
                    if (Controls[i].Name == "btnPlay" || Controls[i] == sender) Controls[i].Visible = false;
                    else if (Controls[i].Name == "btnBack") Controls[i].Visible = true;
                }
                else if (Controls[i] is Panel) Controls[i].Visible = false;
                else
                {
                    Controls.Remove(Controls[i]);
                    i--;
                }
            }
            
            
            //Tạo bảng xếp hạng = code

            //Tạo tiêu đề
       

            Label Ranking = new Label();
            Ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            Ranking.Location = new Point(229, 93);
            Ranking.Size = new Size(175, 38);
            Ranking.Text = "BẢNG XẾP HẠNG";
            Ranking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(Ranking);
            //Tạo phụ dề

            
            Label Hang = new Label();
            Hang.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Hang.Size = new System.Drawing.Size(100, 30);
            Hang.Location = new System.Drawing.Point(85, 143);
            Hang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Hang.Text = "Hạng";
            Controls.Add(Hang);

            Label TenNgChoi = new Label();
            TenNgChoi.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TenNgChoi.Size = new System.Drawing.Size(120, 30);
            TenNgChoi.Location = new System.Drawing.Point(244, 143);
            TenNgChoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TenNgChoi.Text = "Tên người chơi";
            Controls.Add(TenNgChoi);

            Label Diem = new Label();
            Diem.Size = new System.Drawing.Size(100, 30);
            Diem.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Diem.Location = new System.Drawing.Point(417, 143);
            Diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Diem.Text = "Điểm";
            Controls.Add(Diem);
            //Tạo bảng chứa
            Panel BangChua = new Panel();
            BangChua.Name = "pnlRankPoint";

            BangChua.AutoScroll = true;
            BangChua.Location = new System.Drawing.Point(69, 174);
            BangChua.Size = new System.Drawing.Size(470, 225);
            Controls.Add(BangChua);

            ListUsr.List = ListUsr.SapXep();

            int CanChinh = 0;
            for (int i = 0; i < ListUsr.List.Count;i++ )
            {
                Label Rank = new Label();
                Rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
                Rank.Location = new System.Drawing.Point(5, 13 + CanChinh);
                Rank.Size = new System.Drawing.Size(120, 30);
                Rank.Text = (i + 1).ToString();
                Rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                Label Name = new Label();
                Name.Location = new System.Drawing.Point(125, 13 + CanChinh);
                Name.Size = new System.Drawing.Size(205, 30);
                Name.Text = ListUsr.List[i].Ten;
                Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                Label Point = new Label();
                Point.Location = new System.Drawing.Point(330, 13 + CanChinh);
                Point.Size = new System.Drawing.Size(120, 30);
                Point.Text = ListUsr.List[i].Diem.ToString();
                Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                if (i == 0)
                {
                    Rank.ForeColor = Color.Red;
                    Rank.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Name.ForeColor = Color.Red;
                    Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Point.ForeColor = Color.Red;
                    Point.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (i == 1)
                {
                    Rank.ForeColor = Color.YellowGreen;
                    Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Name.ForeColor = Color.YellowGreen;
                    Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Point.ForeColor = Color.YellowGreen;
                    Point.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (i == 2)
                {
                    Rank.ForeColor = Color.BlueViolet;
                    Rank.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Name.ForeColor = Color.BlueViolet;
                    Name.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Point.ForeColor = Color.BlueViolet;
                    Point.Font = this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    Rank.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Point.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                

                BangChua.Controls.AddRange(new Control[] { Name, Point, Rank });
                CanChinh += 30;
                // 
            }
           
            ListUsr.GhiFile("ListPlayer.bat");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {                
                if (ctr is Button && (ctr.Name == "btnPlay" || ctr.Name == "btnRanKing"))
                    ctr.Visible = true;
                else if (ctr is Panel && ctr.Name == "pnlRankPoint") Controls.Remove(ctr);
                else ctr.Visible = false;


            }
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Tomato;
            btnPlay.BackColor = Color.BlueViolet;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Aqua;
            btnPlay.BackColor = Color.Yellow;
        }

        private void btnRanKing_MouseHover(object sender, EventArgs e)
        {
            btnRanKing.ForeColor = Color.Turquoise;
            btnRanKing.BackColor = Color.Olive;
        }

        private void btnRanKing_MouseLeave(object sender, EventArgs e)
        {
            btnRanKing.ForeColor = Color.Blue;
            btnRanKing.BackColor = Color.Red;
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Magenta;
            btnBack.BackColor = Color.Khaki;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Maroon;
            btnBack.BackColor = Color.Lime;
        }

        private bool KiemTraTextBoxDay()
        {
            foreach (TextBox txt in ListTxt)
            {
                if (txt.Text == "") return false;
            }
            return true;
        }
        private void btnGoiY_Click(object sender, EventArgs e)
        {
            
            if (TongXu >= 20)
            {
                TongXu -= 20;
                for (int i = 0; i < ListTxt.Length; i++)
                {
                    if (ListTxt[i].Text == "")
                    {
                        foreach (Button btn in Listbtn)
                        {
                            if (btn.Text == KetQua[index][i].ToString()&&btn.Visible)
                            {
                                ListTxt[i].Text = btn.Text;
                                btn.Visible = false;                              
                                break;
                            }
                        }
                        if (ListTxt[i].Text == "")  ListTxt[i].Text = KetQua[index][i].ToString();

                        ListTxt[i].Click -= DuoiHinhBatChu_Click;
                        ListTxt[i].ForeColor = Color.White;
                        ListTxt[i].BackColor = Color.Black;
                        ListTxt[i].Enabled = false;
                        
                        if (KiemTraTextBoxDay()) CheckResult(sender,e);
                        
                        

                        break;
                    }
                }
                lblCoin.Text = "Tổng xu : " + TongXu.ToString();
            }
            else MessageBox.Show("Không đủ đồng xu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            lblTimeLeft.Text = "Thời gian: " + TimeLeft.ToString()+" giây";
            
            if (TimeLeft == 0)
            {
                timerLeft.Stop();
                MessageBox.Show("Hết thời gian!");
                Exit_Click(sender, e);
            }
            TimeLeft--;    
        }

  
   
    }
}
