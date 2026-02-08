using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void disable()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;

            tabControl1.Visible = false;

        }
        int i = 0, a = 1, r = 2, d = 3, c = 4, f = 5, h = 6, l = 7, m = 8, n = 9,q;
        bool b = true;
        int ran()
        {
            Random rand = new Random();
            int x = rand.Next(10);
            return x;
        }
        void chang(int q)
        {
            if (q == 1)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox1.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox1.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((a == m && a == l) || (a == r && a == d) || (a == n && a == f))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 2)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox2.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox2.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((r == h && r == n) || (a == r && a == d))
                {
                    disable();

                    MessageBox.Show("you won");
                }

            }
            else if (q == 3)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox3.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox3.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((d == c && d == f) || (a == r && a == d) || (d == n && d == l))
                {
                    disable();

                    MessageBox.Show("you won");
                }

            }
            else if (q == 5)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox5.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox5.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((r == h && r == n) || (f == h && f == l))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 4)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox4.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox4.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((d == c && d == f) || (c == n && c == m))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 6)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox6.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox6.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((a == m && a == l) || (m == n && m == c))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 7)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox7.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox7.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((f == h && f == l) || (f == c && f == d) || (f == n && f == a))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 9)
            {
                if (!b)
                {
                    i = 1;
                    a = 1;
                    b = true;
                    pictureBox9.Image = imageList1.Images[i];

                }
                else
                {
                    b = false;
                    i = 0;
                    pictureBox9.Image = imageList1.Images[i];
                    a = 0;
                }
                if ((a == m && a == l) || (l == n && n == d) || (l == h && l == f))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
            else if (q == 8)
            {
                if (!b)
                {
                    i = 1;
                    b = true;
                    pictureBox8.Image = imageList1.Images[i];
                    h = 1;

                }
                else
                {
                    b = false;
                    i = 0;
                    h = 0;
                    pictureBox8.Image = imageList1.Images[i];
                }
                if ((r == h && r == n) || (f == h && f == l))
                {
                    disable();

                    MessageBox.Show("you won");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 10000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            q = ran();
            chang(q);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!b)
            {
                i = 1;
                a = 1;
                b = true;
                pictureBox1.Image = imageList1.Images[i];

            }
            else
            {
                b = false;
                i = 0;
                pictureBox1.Image = imageList1.Images[i];
                a = 0;
            }
            if ((a == m && a == l) || (a == r && a == d) || (a == n && a == f))
            {
                disable();

                MessageBox.Show("you won");
            }

        } 
    
        private void pictureBox6_Click(object sender, EventArgs e)
    {

        if (!b)
        {
            i = 1;
            b = true;
            pictureBox6.Image = imageList1.Images[i];
            m = 1;

        }
        else
        {
            b = false;
            i = 0;
            pictureBox6.Image = imageList1.Images[i];
            m = 0;
        }
        if ((a == m && a == l) || (m == n && m == c))
        {
            disable();

            MessageBox.Show("you won");
        }
    } 

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox9.Image = imageList1.Images[i];
                l = 1;

            }
            else
            {
                b = false;
                i = 0;
                pictureBox9.Image = imageList1.Images[i];
                l = 0;
            }
            if ((a == m && a == l) || (l == n && n == d)||(l==h&&l==f))
            {
                disable();

                MessageBox.Show("you won");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox2.Image = imageList1.Images[i];
                r = 1;
                

            }
            else
            {
                b = false;
                i = 0;
                pictureBox2.Image = imageList1.Images[i];
                r = 0;
                
            }
            if ((r== h&& r == n) || (a == r && a == d))
            {
                disable();

                MessageBox.Show("you won");
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox5.Image = imageList1.Images[i];
                n = 1;

            }
            else
            {
                b = false;
                i = 0;
                pictureBox5.Image = imageList1.Images[i];
                n = 0;
            }
            if ((n== m && n == c) || (n== r && n == h)||(a==n&&a==f))
            {
                disable();

                MessageBox.Show("you won");
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox8.Image = imageList1.Images[i];
                h = 1;

            }
            else
            {
                b = false;
                i = 0;
                h = 0;
                pictureBox8.Image = imageList1.Images[i];
            }
            if ((r == h && r== n) || (f == h && f == l))
            {
                disable();

                MessageBox.Show("you won");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox3.Image = imageList1.Images[i];
                d = 1;

            }
            else
            {
                b = false;
                i = 0;
                pictureBox3.Image = imageList1.Images[i];
                d = 0;
                
            }
            if ((d == c && d == f) || (a == r && a == d)||(d==n&&d==l))
            {
                disable();

                MessageBox.Show("you won");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox4.Image = imageList1.Images[i];
                c = 1;

            }
            else
            {
                b = false;
                i = 0;
                pictureBox4.Image = imageList1.Images[i];
                c = 0;
            }
            if ((d== c && d == f) || (c == n && c == m))
            {
                disable();

                MessageBox.Show("you won");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (!b)
            {
                i = 1;
                b = true;
                pictureBox7.Image = imageList1.Images[i];
                f = 1;
            }
            else
            {
                b = false;
                i = 0;
                pictureBox7.Image = imageList1.Images[i];
                f = 0;
            }
            if ((f == h && f == l) || (f== c && f == d)||(f==n&&f==a))
            {
                disable();

                MessageBox.Show("you won");
            }
        }
    }
}
