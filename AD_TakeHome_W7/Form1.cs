using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_TakeHome_W7
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        public void setForm(object form)
        {
            Panel_Kiri.Controls.Clear();
            if (form.GetType().ToString().Contains("Form3"))
            {
                var obj = form as Form3;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("IRONMAN2"))
            {
                var obj = form as IRONMAN2;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("IRONMAN3"))
            {
                var obj = form as IRONMAN3;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("JOHNWICK"))
            {
                var obj = form as JOHNWICK;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("TOPGUN"))
            {
                var obj = form as TOPGUN;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("HTTYD1"))
            {
                var obj = form as HTTYD1;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("HTTYD2"))
            {
                var obj = form as HTTYD2;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("HTTYD3"))
            {
                var obj = form as HTTYD3;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("KNIVES1"))
            {
                var obj = form as KNIVES1;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("KNIVES2"))
            {
                var obj = form as KNIVES2;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                Panel_Kiri.Controls.Add(obj);
                obj.Show();
            }

        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2(this);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Panel_Kiri.Controls.Add(myForm);
            myForm.AutoSize = true;
            myForm.Show();

        }
    }
}
