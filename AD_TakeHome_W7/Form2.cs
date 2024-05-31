using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_TakeHome_W7
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // IRON MAN 1
            Label LB_IRONMAN1 = new Label();
            LB_IRONMAN1.AutoSize = true;
            LB_IRONMAN1.Location = new Point(112, 141);
            LB_IRONMAN1.Name = "LB_IRONMAN";
            LB_IRONMAN1.Size = new Size(49, 13);
            LB_IRONMAN1.TabIndex = 0;
            LB_IRONMAN1.Text = "Iron Man";
            Controls.Add(LB_IRONMAN1);

            Button BTN_IRONMAN1 = new Button();
            BTN_IRONMAN1.Location = new Point(112, 157);
            BTN_IRONMAN1.Name = "BTN_IRONMAN";
            BTN_IRONMAN1.Size = new Size(91, 23);
            BTN_IRONMAN1.TabIndex = 2;
            BTN_IRONMAN1.Text = "Watch Movie";
            BTN_IRONMAN1.UseVisualStyleBackColor = true;
            Controls.Add(BTN_IRONMAN1);

            PictureBox PB_IRONMAN1 = new PictureBox();
            PB_IRONMAN1.Image = Properties.Resources.IRON_MAN_1;
            PB_IRONMAN1.Location = new Point(112, 12);
            PB_IRONMAN1.Name = "PB_IRONMAN1";
            PB_IRONMAN1.Size = new Size(91, 126);
            PB_IRONMAN1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_IRONMAN1.TabIndex = 1;
            PB_IRONMAN1.TabStop = false;
            Controls.Add(PB_IRONMAN1);

            BTN_IRONMAN1.Click += (BTN_IRONMAN1_Click);


            //IRON MAN 2
            Label LB_IRONMAN2 = new Label();
            LB_IRONMAN2.AutoSize = true;
            LB_IRONMAN2.Location = new Point(218, 141);
            LB_IRONMAN2.Name = "LB_IRONMAN2";
            LB_IRONMAN2.Size = new Size(49, 13);
            LB_IRONMAN2.TabIndex = 0;
            LB_IRONMAN2.Text = "Iron Man 2";
            Controls.Add(LB_IRONMAN2);

            Button BTN_IRONMAN2 = new Button();
            BTN_IRONMAN2.Location = new Point(218, 157);
            BTN_IRONMAN2.Name = "BTN_IRONMAN2";
            BTN_IRONMAN2.Size = new Size(91, 23);
            BTN_IRONMAN2.TabIndex = 2;
            BTN_IRONMAN2.Text = "Watch Movie";
            BTN_IRONMAN2.UseVisualStyleBackColor = true;
            Controls.Add(BTN_IRONMAN2);

            BTN_IRONMAN2.Click += (BTN_IRONMAN2_Click);

            PictureBox PB_IRONMAN2 = new PictureBox();
            PB_IRONMAN2.Image = Properties.Resources.IRON_MAN_2;
            PB_IRONMAN2.Location = new Point(218, 12);
            PB_IRONMAN2.Name = "PB_IRONMAN2";
            PB_IRONMAN2.Size = new Size(91, 126);
            PB_IRONMAN2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_IRONMAN2.TabIndex = 1;
            PB_IRONMAN2.TabStop = false;
            Controls.Add(PB_IRONMAN2);


            // IRON MAN 3
            Label LB_IRONMAN3 = new Label();
            LB_IRONMAN3.AutoSize = true;
            LB_IRONMAN3.Location = new Point(327, 141);
            LB_IRONMAN3.Name = "LB_IRONMAN3";
            LB_IRONMAN3.Size = new Size(49, 13);
            LB_IRONMAN3.TabIndex = 0;
            LB_IRONMAN3.Text = "Iron Man 3";
            Controls.Add(LB_IRONMAN3);

            Button BTN_IRONMAN3 = new Button();
            BTN_IRONMAN3.Location = new Point(327, 157);
            BTN_IRONMAN3.Name = "BTN_IRONMAN3";
            BTN_IRONMAN3.Size = new Size(91, 23);
            BTN_IRONMAN3.TabIndex = 2;
            BTN_IRONMAN3.Text = "Watch Movie";
            BTN_IRONMAN3.UseVisualStyleBackColor = true;
            Controls.Add(BTN_IRONMAN3);

            BTN_IRONMAN3.Click += (BTN_IRONMAN3_Click);

            PictureBox PB_IRONMAN3 = new PictureBox();
            PB_IRONMAN3.Image = Properties.Resources.IRON_MAN_3;
            PB_IRONMAN3.Location = new Point(327, 12);
            PB_IRONMAN3.Name = "PB_IRONMAN3";
            PB_IRONMAN3.Size = new Size(91, 126);
            PB_IRONMAN3.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_IRONMAN3.TabIndex = 1;
            PB_IRONMAN3.TabStop = false;
            Controls.Add(PB_IRONMAN3);

            // JOHN WICK
            Label LB_JOHNWIK = new Label();
            LB_JOHNWIK.AutoSize = true;
            LB_JOHNWIK.Location = new Point(442, 141);
            LB_JOHNWIK.Name = "LB_JOHNWIK";
            LB_JOHNWIK.Size = new Size(49, 13);
            LB_JOHNWIK.TabIndex = 0;
            LB_JOHNWIK.Text = "John Wick: Chapter 4";
            Controls.Add(LB_JOHNWIK);

            Button BTN_JOHNWIK = new Button();
            BTN_JOHNWIK.Location = new Point(442, 157);
            BTN_JOHNWIK.Name = "BTN_JOHNWIK";
            BTN_JOHNWIK.Size = new Size(91, 23);
            BTN_JOHNWIK.TabIndex = 2;
            BTN_JOHNWIK.Text = "Watch Movie";
            BTN_JOHNWIK.UseVisualStyleBackColor = true;
            Controls.Add(BTN_JOHNWIK);

            BTN_JOHNWIK.Click += (BTN_JOHNWIK_Click);

            PictureBox PB_JOHNWIK = new PictureBox();
            PB_JOHNWIK.Image = Properties.Resources.JOHN_WIK;
            PB_JOHNWIK.Location = new Point(442, 12);
            PB_JOHNWIK.Name = "PB_JOHNWIK";
            PB_JOHNWIK.Size = new Size(91, 126);
            PB_JOHNWIK.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_JOHNWIK.TabIndex = 1;
            PB_JOHNWIK.TabStop = false;
            Controls.Add(PB_JOHNWIK);

            //HTTYD 1
            Label LB_HTTYD1 = new Label();
            LB_HTTYD1.AutoSize = true;
            LB_HTTYD1.Location = new Point(112, 327);
            LB_HTTYD1.Name = "LB_HTTYD1";
            LB_HTTYD1.Size = new Size(49, 13);
            LB_HTTYD1.TabIndex = 0;
            LB_HTTYD1.Text = "HTTYD 1";
            Controls.Add(LB_HTTYD1);

            Button BTN_HTTYD1 = new Button();
            BTN_HTTYD1.Location = new Point(112, 343);
            BTN_HTTYD1.Name = "BTN_HTTYD1";
            BTN_HTTYD1.Size = new Size(91, 23);
            BTN_HTTYD1.TabIndex = 2;
            BTN_HTTYD1.Text = "Watch Movie";
            BTN_HTTYD1.UseVisualStyleBackColor = true;
            Controls.Add(BTN_HTTYD1);

            BTN_HTTYD1.Click += (BTN_HTTYD1_Click);

            PictureBox PB_HTTYD1 = new PictureBox();
            PB_HTTYD1.Image = Properties.Resources.HTTYD_1;
            PB_HTTYD1.Location = new Point(112, 198);
            PB_HTTYD1.Name = "PB_HTTYD1";
            PB_HTTYD1.Size = new Size(91, 126);
            PB_HTTYD1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_HTTYD1.TabIndex = 1;
            PB_HTTYD1.TabStop = false;
            Controls.Add(PB_HTTYD1);

            //HTTYD 2
            Label LB_HTTYD2 = new Label();
            LB_HTTYD2.AutoSize = true;
            LB_HTTYD2.Location = new Point(218, 327);
            LB_HTTYD2.Name = "LB_HTTYD2";
            LB_HTTYD2.Size = new Size(49, 13);
            LB_HTTYD2.TabIndex = 0;
            LB_HTTYD2.Text = "HTTYD 2";
            Controls.Add(LB_HTTYD2);

            Button BTN_HTTYD2 = new Button();
            BTN_HTTYD2.Location = new Point(218, 343);
            BTN_HTTYD2.Name = "BTN_HTTYD2";
            BTN_HTTYD2.Size = new Size(91, 23);
            BTN_HTTYD2.TabIndex = 2;
            BTN_HTTYD2.Text = "Watch Movie";
            BTN_HTTYD2.UseVisualStyleBackColor = true;
            Controls.Add(BTN_HTTYD2);

            BTN_HTTYD2.Click += (BTN_HTTYD2_Click);

            PictureBox PB_HTTYD2 = new PictureBox();
            PB_HTTYD2.Image = Properties.Resources.HTTYD_2;
            PB_HTTYD2.Location = new Point(218, 198);
            PB_HTTYD2.Name = "PB_HTTYD2";
            PB_HTTYD2.Size = new Size(91, 126);
            PB_HTTYD2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_HTTYD2.TabIndex = 1;
            PB_HTTYD2.TabStop = false;
            Controls.Add(PB_HTTYD2);

            //HTTYD 3
            Label LB_HTTYD3 = new Label();
            LB_HTTYD3.AutoSize = true;
            LB_HTTYD3.Location = new Point(327, 327);
            LB_HTTYD3.Name = "LB_HTTYD3";
            LB_HTTYD3.Size = new Size(49, 13);
            LB_HTTYD3.TabIndex = 0;
            LB_HTTYD3.Text = "HTTYD 3";
            Controls.Add(LB_HTTYD3);

            Button BTN_HTTYD3 = new Button();
            BTN_HTTYD3.Location = new Point(327, 343);
            BTN_HTTYD3.Name = "BTN_HTTYD3";
            BTN_HTTYD3.Size = new Size(91, 23);
            BTN_HTTYD3.TabIndex = 2;
            BTN_HTTYD3.Text = "Watch Movie";
            BTN_HTTYD3.UseVisualStyleBackColor = true;
            Controls.Add(BTN_HTTYD3);

            BTN_HTTYD3.Click += (BTN_HTTYD3_Click);

            PictureBox PB_HTTYD3 = new PictureBox();
            PB_HTTYD3.Image = Properties.Resources.HHTYD_3;
            PB_HTTYD3.Location = new Point(327, 198);
            PB_HTTYD3.Name = "PB_HTTYD3";
            PB_HTTYD3.Size = new Size(91, 126);
            PB_HTTYD3.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_HTTYD3.TabIndex = 1;
            PB_HTTYD3.TabStop = false;
            Controls.Add(PB_HTTYD3);

            //TOP GUN MAVERICK
            Label LB_TOPGUN = new Label();
            LB_TOPGUN.AutoSize = true;
            LB_TOPGUN.Location = new Point(442, 327);
            LB_TOPGUN.Name = "LB_TOPGUN";
            LB_TOPGUN.Size = new Size(49, 13);
            LB_TOPGUN.TabIndex = 0;
            LB_TOPGUN.Text = "Top Gun: Maverick";
            Controls.Add(LB_TOPGUN);

            Button BTN_TOPGUN = new Button();
            BTN_TOPGUN.Location = new Point(442, 343);
            BTN_TOPGUN.Name = "BTN_TOPGUN";
            BTN_TOPGUN.Size = new Size(91, 23);
            BTN_TOPGUN.TabIndex = 2;
            BTN_TOPGUN.Text = "Watch Movie";
            BTN_TOPGUN.UseVisualStyleBackColor = true;
            Controls.Add(BTN_TOPGUN);

            BTN_TOPGUN.Click += (BTN_TOPGUN_Click);

            PictureBox PB_TOPGUN = new PictureBox();
            PB_TOPGUN.Image = Properties.Resources.TOP_GUN_MAV;
            PB_TOPGUN.Location = new Point(442, 198);
            PB_TOPGUN.Name = "PB_TOPGUN";
            PB_TOPGUN.Size = new Size(91, 126);
            PB_TOPGUN.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_TOPGUN.TabIndex = 1;
            PB_TOPGUN.TabStop = false;
            Controls.Add(PB_TOPGUN);

            //KNIVES OUT
            Label LB_KNIVES1 = new Label();
            LB_KNIVES1.AutoSize = true;
            LB_KNIVES1.Location = new Point(555, 141);
            LB_KNIVES1.Name = "LB_KNIVES1";
            LB_KNIVES1.Size = new Size(49, 13);
            LB_KNIVES1.TabIndex = 0;
            LB_KNIVES1.Text = "Knives Out";
            Controls.Add(LB_KNIVES1);

            Button BTN_KNIVES1 = new Button();
            BTN_KNIVES1.Location = new Point(555, 157);
            BTN_KNIVES1.Name = "BTN_KNIVES1";
            BTN_KNIVES1.Size = new Size(91, 23);
            BTN_KNIVES1.TabIndex = 2;
            BTN_KNIVES1.Text = "Watch Movie";
            BTN_KNIVES1.UseVisualStyleBackColor = true;
            Controls.Add(BTN_KNIVES1);

            BTN_KNIVES1.Click += (BTN_KNIVES1_Click);

            PictureBox PB_KNIVES1 = new PictureBox();
            PB_KNIVES1.Image = Properties.Resources.KNIVES_OUT_1;
            PB_KNIVES1.Location = new Point(555, 12);
            PB_KNIVES1.Name = "PB_KNIVES1";
            PB_KNIVES1.Size = new Size(91, 126);
            PB_KNIVES1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_KNIVES1.TabIndex = 1;
            PB_KNIVES1.TabStop = false;
            Controls.Add(PB_KNIVES1);

            //GLASS ONION
            Label LB_KNIVES2 = new Label();
            LB_KNIVES2.AutoSize = true;
            LB_KNIVES2.Location = new Point(558, 327);
            LB_KNIVES2.Name = "LB_KNIVES2";
            LB_KNIVES2.Size = new Size(49, 13);
            LB_KNIVES2.TabIndex = 0;
            LB_KNIVES2.Text = "Glass Onion";
            Controls.Add(LB_KNIVES2);

            Button BTN_KNIVES2 = new Button();
            BTN_KNIVES2.Location = new Point(558, 343);
            BTN_KNIVES2.Name = "BTN_KNIVES2";
            BTN_KNIVES2.Size = new Size(91, 23);
            BTN_KNIVES2.TabIndex = 2;
            BTN_KNIVES2.Text = "Watch Movie";
            BTN_KNIVES2.UseVisualStyleBackColor = true;
            Controls.Add(BTN_KNIVES2);

            BTN_KNIVES2.Click += (BTN_KNIVES2_Click);

            PictureBox PB_KNIVES2 = new PictureBox();
            PB_KNIVES2.Image = Properties.Resources.KNIVES_OUT_2;
            PB_KNIVES2.Location = new Point(558, 198);
            PB_KNIVES2.Name = "PB_KNIVES2";
            PB_KNIVES2.Size = new Size(91, 126);
            PB_KNIVES2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_KNIVES2.TabIndex = 1;
            PB_KNIVES2.TabStop = false;
            Controls.Add(PB_KNIVES2);

            
        }

        private void BTN_IRONMAN1_Click(object sender, EventArgs e)
        {
            Form3 IRONMAN1 = new Form3();
            form1.setForm(IRONMAN1);

        }

        private void BTN_IRONMAN2_Click(object sender, EventArgs e) 
        {
            IRONMAN2 IRONMAN2 = new IRONMAN2();
            form1.setForm(IRONMAN2);
        }

        private void BTN_IRONMAN3_Click(object sender, EventArgs e)
        {
            IRONMAN3 IRONMAN3 = new IRONMAN3();
            form1.setForm(IRONMAN3);
        }

        private void BTN_JOHNWIK_Click(object sender, EventArgs e)
        {
            JOHNWICK JOHNWICK = new JOHNWICK();
            form1.setForm(JOHNWICK);
        }

        private void BTN_TOPGUN_Click(object sender, EventArgs e)
        {
            TOPGUN TOPGUN = new TOPGUN();
            form1.setForm(TOPGUN);
        }

        private void BTN_HTTYD1_Click(object sender, EventArgs e)
        {
            HTTYD1 HTTYD1 = new HTTYD1();
            form1.setForm(HTTYD1);
        }

        private void BTN_HTTYD2_Click(object sender, EventArgs e)
        {
            HTTYD2 HTTYD2 = new HTTYD2();
            form1.setForm(HTTYD2);
        }

        private void BTN_HTTYD3_Click(object sender, EventArgs e)
        {
            HTTYD3 HTTYD3 = new HTTYD3();
            form1.setForm(HTTYD3);
        }

        private void BTN_KNIVES1_Click(object sender, EventArgs e)
        {
            KNIVES1 KNIVES1 = new KNIVES1();
            form1.setForm(KNIVES1);
        }

        private void BTN_KNIVES2_Click(object sender, EventArgs e)
        {
            KNIVES2 KNIVES2 = new KNIVES2();
            form1.setForm(KNIVES2);
        }

    }
}
