using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        System.Timers.Timer t;
        int h, q, s;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\WindowsFormsApplication1\WindowsFormsApplication1\Resources\music.wav");
        System.Media.SoundPlayer melo = new System.Media.SoundPlayer(@"d:\WindowsFormsApplication1\WindowsFormsApplication1\Resources\musicf.wav");

        Button[] b = new Button[9];
        int i, clk, pi, pf, aux, nr = 0;

        private void btnstart_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
            btnstart.Visible = false;
            button4.Visible = false;
            button3.Visible = true;
            textBox1.Visible = true;
            txtresult.Visible = true;
            for (i = 0; i < 9; i++)
            {
                b[i] = new Button();
                b[i].Height = 106;
                b[i].Width = 106;
                b[i].Top = 100 + i / 3 * 100;
                b[i].Left = 100 + i % 3 * 100;
                this.Controls.Add(b[i]);
                b[i].FlatStyle = buttonn.FlatStyle;
                b[i].BackgroundImageLayout = buttona.BackgroundImageLayout;
                b[i].BackgroundImage = gol.BackgroundImage;
                b[i].BackColor = Color.Orange;
                m[i] = 0;
                b[i].Tag = i;
                b[i].Click += new EventHandler(b_Click);
            }
            b[0].BackgroundImage = WindowsFormsApplication1.Properties.Resources.alb;
            b[2].BackgroundImage = WindowsFormsApplication1.Properties.Resources.alb;
            b[6].BackgroundImage = WindowsFormsApplication1.Properties.Resources.negru;
            b[8].BackgroundImage = WindowsFormsApplication1.Properties.Resources.negru;
            m[0] = 1;
            m[2] = 1;
            m[6] = 2;
            m[8] = 2;
            clk = 0;

            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();

            button6.Visible = true;

        }

        int[] m = new int[9];

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Play();
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Stop();
            button3.Visible = false;
            button4.Visible = true;
            for (i = 0; i < 9; i++)
                b[i].Enabled = false;
            txtresult.Enabled = false;
            textBox1.Enabled = false;
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void necgruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void rosuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visiuniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkMagenta;
        }

        private void carminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Lime;
        }

        private void vernilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGreen;
        }

        private void verzuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void albastruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void rozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void deschisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
        }

        private void inchisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkOrange;
        }

        private void bejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Khaki;
        }

        private void inchisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gold;
        }

        private void deschisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
        }

        private void albToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void optiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jocNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void schimbareStilToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 settingsForm = new Form3();
            settingsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t.Stop();
            for (i = 0; i < 9; i++)
                b[i].Enabled = false;
            txtresult.Enabled = false;
            button4.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Enabled = false;
            button5.Visible = false;
            button6.Visible = false;
            label3.Visible = true;
            b[0].BackgroundImage = WindowsFormsApplication1.Properties.Resources.negru;
            b[2].BackgroundImage = WindowsFormsApplication1.Properties.Resources.negru;
            b[6].BackgroundImage = WindowsFormsApplication1.Properties.Resources.alb;
            b[8].BackgroundImage = WindowsFormsApplication1.Properties.Resources.alb;
            b[1].BackgroundImage = gol.BackgroundImage;
            b[3].BackgroundImage = gol.BackgroundImage;
            b[5].BackgroundImage = gol.BackgroundImage;
            b[7].BackgroundImage = gol.BackgroundImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Start();
            button4.Visible = false;
            button3.Visible = true;
            for (i = 0; i < 9; i++)
                    b[i].Enabled = true;
            txtresult.Enabled = true;
            textBox1.Enabled = true;
        }

        private int valid(int pozi, int pozf)
        {
            if (m[pozi] != 0 && m[pozf] == 0)
                if ((pozi == 0 && pozf == 5) || (pozi == 0 && pozf == 7) || (pozi == 1 && pozf == 6) || (pozi == 1 && pozf == 8) || (pozi == 2 && pozf == 3) || (pozi == 2 && pozf == 7) || (pozi == 3 && pozf == 8) || (pozi == 5 && pozf == 0) || (pozi == 5 && pozf == 6) || (pozi == 7 && pozf == 0) || (pozi == 7 && pozf == 2) || (pozi == 8 && pozf == 1) || (pozi == 8 && pozf == 3)|| (pozi == 6 && pozf == 1)||(pozi == 6 && pozf == 5)|| (pozi == 3 && pozf == 2))
                    return 1;
                else
                    return 0;
            return 1;
        }

        private void b_Click(object sender, EventArgs e)
        {
            int q = (int)((Button)(sender)).Tag;
            if (clk == 0 && m[q] != 0)
            {
                for (i = 0; i <= 8; i++)
                {
                    if (valid(q, i) == 1)
                        b[i].BackColor = Color.LightBlue;
                }
                clk = 1;
                pi = q;
            }
            else
            {
                if (clk == 1 && m[q] == 0)
                {
                    for (i = 0; i <= 8; i++)
                    {
                        b[i].BackColor = Color.Orange;
                    }
                    clk = 0;
                    pf = q;
                    if (valid(pi, pf) != 0)
                    {
                        aux = m[pi];
                        m[pi] = m[pf];
                        m[pf] = aux;
                        b[pf].BackgroundImage = b[pi].BackgroundImage;
                        b[pi].BackgroundImage = gol.BackgroundImage;
                        nr++;
                        textBox1.Text = "Numar de miscari = " + nr;
                    }
                }
            }

            if ( m[0] == 2 && m[2] == 2 && m[6] == 1 && m[8] == 1)
            {
                t.Stop();
                txt.Visible = true;
                label1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                if (nr == 16)
                    label2.Visible = true;
                for (i = 0; i < 9; i++)
                    b[i].Enabled = false;
                txtresult.Enabled = false;
                textBox1.Enabled = false;
                button5.Visible = false;
                button6.Visible = false;
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = false;
            txtresult.Visible = false;
            button6.Visible = false;
            BackColor = Color.Black;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
          {
              s += 1;
              if (s == 60)
              {
                  s = 0;
                  q += 1;

              }
              txtresult.Text = String.Format("{0}:{1}", q.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

          } 
            ));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.DoEvents();
        }
    }
}
