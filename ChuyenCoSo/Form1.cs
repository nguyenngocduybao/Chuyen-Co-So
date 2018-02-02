using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenCoSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Count(int N)
        {
            int t = 0;
            while (N > 0)
            {
                t++;
                N = N / 10;
            }
            return t;
        }

        void Result (int x)
        {
            tb_Xuat.Text = x.ToString();
        }

        int Checkc (char a)
        {
            int b;

            switch (a)
            {
                case 'A':
                    b = 10;
                    break;
                case 'B':
                    b = 11;
                    break;
                case 'C' :
                    b = 12;
                    break;
                case 'D':
                    b = 13;
                    break;
                case 'E':
                    b = 14;
                    break;
                case 'F':
                    b = 15;
                    break;
                default:
                    b = (int)a - 48;
                    break;
            }

            return b;
        }

        string Checki (int x)
        {
            string a;

            switch (x)
            {
                case 10:
                    a = "A";
                    break;
                case 11:
                    a = "B";
                    break;
                case 12:
                    a = "C";
                    break;
                case 13:
                    a = "D";
                    break;
                case 14:
                    a = "E";
                    break;
                case 15:
                    a = "F";
                    break;
                default:
                    a = x.ToString();
                    break;
            }

            return a;
        }

        string Reverse(string a)
        {
            char[] c = a.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        int bindec()
        {
            int a = Convert.ToInt32(tb_Nhap.Text);
            int x = 0, y = 0, k = Count(a);

            for (int i = k; i >= 0; i--)
            {
                y = (int)(Math.Pow(2, i)) * (int)(a / Math.Pow(10, i));
                x += y;
                a = a % (int)(Math.Pow(10, i));
            }

            return x;
        }

        private void binTodec_Click(object sender, EventArgs e)
        {
            int x = bindec();

            Result(x);
        }

        int octdec()
        {
            int a = Convert.ToInt32(tb_Nhap.Text);
            int x = 0, y = 0, k = Count(a);

            for (int i = k; i >= 0; i--)
            {
                y = (int)(Math.Pow(8, i)) * (int)(a / Math.Pow(10, i));
                x += y;
                a = a % (int)(Math.Pow(10, i));
            }

            return x;
        }

        private void octTodec_Click(object sender, EventArgs e)
        {
            int x = octdec();

            Result(x);
        }

        int hexdec()
        {
            string a = tb_Nhap.Text;
            int x = 0, y = 0, k = a.Length;

            for (int i = k - 1; i >= 0; i--)
            {
                y = (int)(Math.Pow(16, k - i - 1)) * Checkc(a[i]);
                x += y;
            }

            return x;
        }

        private void hexTodec_Click(object sender, EventArgs e)
        {
            int x = hexdec();

            Result(x);
        }
                
        private void decTobin_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_Nhap.Text), b;
            string c = "";            

            do
            {
                b = (int)(a % 2);
                c += b.ToString();                
                a = a / 2;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }
                
        private void decTooct_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_Nhap.Text), b;
            string c = "";

            do
            {
                b = (int)(a % 8);
                c += b.ToString();
                a = a / 8;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void decTohex_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_Nhap.Text), b;
            string c = "", d;

            do
            {
                b = (int)(a % 16);
                d = Checki(b);
                c += d;
                a = a / 16;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void octTobin_Click(object sender, EventArgs e)
        {
            int a = octdec(), b;
            string c = "";

            do
            {
                b = (int)(a % 2);
                c += b.ToString();
                a = a / 2;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void octTohex_Click(object sender, EventArgs e)
        {
            int a = octdec(), b;
            string c = "";

            do
            {
                b = (int)(a % 16);
                c += b.ToString();
                a = a / 16;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void hexTobin_Click(object sender, EventArgs e)
        {
            int a = hexdec(), b;
            string c = "";

            do
            {
                b = (int)(a % 2);
                c += b.ToString();
                a = a / 2;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void hexTooct_Click(object sender, EventArgs e)
        {
            int a = hexdec(), b;
            string c = "";

            do
            {
                b = (int)(a % 8);
                c += b.ToString();
                a = a / 8;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void binTooct_Click(object sender, EventArgs e)
        {
            int a = bindec(), b;
            string c = "";

            do
            {
                b = (int)(a % 8);
                c += b.ToString();
                a = a / 8;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }

        private void binTohex_Click(object sender, EventArgs e)
        {
            int a = bindec(), b;            
            string c = "", d;

            do
            {
                b = (int)(a % 16);
                d = Checki(b);
                c += d;
                a = a / 16;
            } while (a != 0);
            c = Reverse(c);

            tb_Xuat.Text = c;
        }
    }
}
