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
    public partial class HTTYD3 : Form
    {
        Panel Panel_Seats_HTTYD3 = new Panel();
        List<Button> list_HTTYD3_Seats_1230 = new List<Button>();
        List<Button> list_HTTYD3_Seats_1505 = new List<Button>();
        List<Button> list_HTTYD3_Seats_2000 = new List<Button>();

        int location1 = 10;
        int location2 = 10;

        int counter = 0;
        int choose = 0;

        Label seatschoosen = new Label();
        Random Seasts = new Random();

        public HTTYD3()
        {
            InitializeComponent();
        }

        private void HTTYD3_Load(object sender, EventArgs e)
        {
            // BANNER
            PictureBox PB_BANNER = new PictureBox();
            PB_BANNER.BackColor = SystemColors.WindowFrame;
            PB_BANNER.Location = new Point(-2, 0);
            PB_BANNER.Name = "PB_BANNER";
            PB_BANNER.Size = new Size(767, 69);
            PB_BANNER.TabIndex = 0;
            PB_BANNER.TabStop = false;
            Controls.Add(PB_BANNER);

            // HOW TO TRAIN YOUR DRAGON 3
            Label LB_HTTYD3 = new Label();
            LB_HTTYD3.AutoSize = true;
            LB_HTTYD3.BackColor = SystemColors.Control;
            LB_HTTYD3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            LB_HTTYD3.Location = new Point(12, 94);
            LB_HTTYD3.Name = "LB_HTTYD3";
            LB_HTTYD3.Size = new Size(112, 23);
            LB_HTTYD3.TabIndex = 2;
            LB_HTTYD3.Text = "HOW TO TRAIN YOUR DRAGON 3";
            Controls.Add(LB_HTTYD3);

            // HTTYD 3 BANNER
            PictureBox PB_HTTYD3 = new PictureBox();
            PB_HTTYD3.BackColor = SystemColors.Control;
            PB_HTTYD3.Image = Properties.Resources.HHTYD_3;
            PB_HTTYD3.Location = new Point(12, 120);
            PB_HTTYD3.Name = "PB_HTTYD3";
            PB_HTTYD3.Size = new Size(167, 202);
            PB_HTTYD3.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_HTTYD3.TabIndex = 3;
            PB_HTTYD3.TabStop = false;
            Controls.Add(PB_HTTYD3);

            // CIPUTRA UNIVERSITY THEATER
            Label LB_PLAYINGAT = new Label();
            LB_PLAYINGAT.AutoSize = true;
            LB_PLAYINGAT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            LB_PLAYINGAT.Location = new Point(185, 120);
            LB_PLAYINGAT.Name = "LB_PLAYINGAT";
            LB_PLAYINGAT.Size = new Size(244, 16);
            LB_PLAYINGAT.TabIndex = 4;
            LB_PLAYINGAT.Text = "CIPUTRA UNIVERSITY THEATER";
            Controls.Add(LB_PLAYINGAT);

            // 12:30
            Button BTN_HHTYD31230 = new Button();
            BTN_HHTYD31230.BackColor = SystemColors.WindowFrame;
            BTN_HHTYD31230.ForeColor = Color.Bisque;
            BTN_HHTYD31230.Location = new Point(185, 147);
            BTN_HHTYD31230.Name = "BTN_HTTYD31230";
            BTN_HHTYD31230.Size = new Size(116, 41);
            BTN_HHTYD31230.TabIndex = 5;
            BTN_HHTYD31230.Text = "12:30";
            BTN_HHTYD31230.UseVisualStyleBackColor = false;
            Controls.Add(BTN_HHTYD31230);
            BTN_HHTYD31230.Click += (BTN_HTTYD31230_CLICK);

            // 15:50
            Button BTN_HTTYD31505 = new Button();
            BTN_HTTYD31505.BackColor = SystemColors.WindowFrame;
            BTN_HTTYD31505.ForeColor = Color.Bisque;
            BTN_HTTYD31505.Location = new Point(185, 241);
            BTN_HTTYD31505.Name = "BTN_HTTYD31505";
            BTN_HTTYD31505.Size = new Size(116, 41);
            BTN_HTTYD31505.TabIndex = 6;
            BTN_HTTYD31505.Text = "15:05";
            BTN_HTTYD31505.UseVisualStyleBackColor = false;
            Controls.Add(BTN_HTTYD31505);
            BTN_HTTYD31505.Click += (BTN_HTTYD31505_CLICK);

            // 20:00
            Button BTN_HTTYD32000 = new Button();
            BTN_HTTYD32000.BackColor = SystemColors.WindowFrame;
            BTN_HTTYD32000.ForeColor = Color.Bisque;
            BTN_HTTYD32000.Location = new Point(185, 194);
            BTN_HTTYD32000.Name = "BTN_HTTYD32000";
            BTN_HTTYD32000.Size = new Size(116, 41);
            BTN_HTTYD32000.TabIndex = 7;
            BTN_HTTYD32000.Text = "20:00";
            BTN_HTTYD32000.UseVisualStyleBackColor = false;
            Controls.Add(BTN_HTTYD32000);
            BTN_HTTYD32000.Click += (BTN_HTTYD32000_CLICK);

            // SEATS HTTYD 3
            Panel_Seats_HTTYD3.BackColor = SystemColors.ActiveBorder;
            Panel_Seats_HTTYD3.Location = new Point(435, 94);
            Panel_Seats_HTTYD3.Name = "Panel_Seats_HTTYD3";
            Panel_Seats_HTTYD3.Size = new Size(318, 275);
            Panel_Seats_HTTYD3.TabIndex = 8;
            Controls.Add(Panel_Seats_HTTYD3);

            //BACK BUTTON
            Button BTN_BACK = new Button();
            BTN_BACK.Location = new Point(12, 344);
            BTN_BACK.Name = "BTN_BACK";
            BTN_BACK.Size = new Size(51, 25);
            BTN_BACK.TabIndex = 18;
            BTN_BACK.Text = "<";
            BTN_BACK.UseVisualStyleBackColor = true;
            Controls.Add(BTN_BACK);
            BTN_BACK.Click += (BTN_BACK_CLICK);

            // RESERVE SEAT
            Button BTN_HTTYD3_Reserve = new Button();
            BTN_HTTYD3_Reserve.BackColor = SystemColors.WindowFrame;
            BTN_HTTYD3_Reserve.ForeColor = Color.Bisque;
            BTN_HTTYD3_Reserve.Location = new Point(300, 324);
            BTN_HTTYD3_Reserve.Name = "button2";
            BTN_HTTYD3_Reserve.Size = new Size(116, 41);
            BTN_HTTYD3_Reserve.TabIndex = 7;
            BTN_HTTYD3_Reserve.Text = "Reserve";
            BTN_HTTYD3_Reserve.UseVisualStyleBackColor = false;
            Controls.Add(BTN_HTTYD3_Reserve);
            BTN_HTTYD3_Reserve.Click += (BTN_HTTYD3_Reserve_Click);

            // RESET BUTTON
            Button BTN_HTTYD3_Reset = new Button();
            BTN_HTTYD3_Reset.BackColor = SystemColors.WindowFrame;
            BTN_HTTYD3_Reset.ForeColor = Color.Bisque;
            BTN_HTTYD3_Reset.Location = new Point(300, 277);
            BTN_HTTYD3_Reset.Name = "button2";
            BTN_HTTYD3_Reset.Size = new Size(116, 41);
            BTN_HTTYD3_Reset.TabIndex = 7;
            BTN_HTTYD3_Reset.Text = "Reset";
            BTN_HTTYD3_Reset.UseVisualStyleBackColor = false;
            Controls.Add(BTN_HTTYD3_Reset);
            BTN_HTTYD3_Reset.Click += (BTN_HTTDY3_Reset_Click);

            // SEAT BUTTONS 12:30
            Panel_Seats_HTTYD3.Controls.Clear();
            Seats_HTTYD3_Generate_1230();

            // RANDOM SEATS12:30
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_HTTYD3_Seats_1230[random].BackColor = Color.Red;
                list_HTTYD3_Seats_1230[random].Enabled = false;
            }

            // SEAT BUTTONS 15:05
            Panel_Seats_HTTYD3.Controls.Clear();
            Seats_HTTDY3_Generate_1505();


            // RANDOM SEATS 15:05
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_HTTYD3_Seats_1505[random].BackColor = Color.Red;
                list_HTTYD3_Seats_1505[random].Enabled = false;
            }

            // SEATS BUTTONS 20:00
            Panel_Seats_HTTYD3.Controls.Clear();
            Seats_HTTYD3_Generate_2000();


            // RANDOM SEATS 20:00
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_HTTYD3_Seats_2000[random].BackColor = Color.Red;
                list_HTTYD3_Seats_2000[random].Enabled = false;
            }
        }
        private void BTN_BACK_CLICK(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_HTTYD31230_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            choose = 1;
            foreach (Button seat in list_HTTYD3_Seats_1230)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }

        }

        private void BTN_HTTYD31505_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            choose = 2;
            foreach (Button seat in list_HTTYD3_Seats_1505)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }

        }

        private void BTN_HTTYD32000_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            choose = 3;
            foreach (Button seat in list_HTTYD3_Seats_2000)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }
        }

        private void BTN_HTTYD3_Reserve_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                foreach (Button button in list_HTTYD3_Seats_1230)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (choose == 2)
            {
                foreach (Button button in list_HTTYD3_Seats_1505)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (choose == 3)
            {
                foreach (Button button in list_HTTYD3_Seats_2000)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
        }

        private void Tombol_Click_HTTYD3_Seats1(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();

            foreach (Button seat in list_HTTYD3_Seats_1230)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void Tombol_Click_HTTDY3_Seats2(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            foreach (Button seat in list_HTTYD3_Seats_1505)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void Tombol_Click_HTTDY3_Seats3(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            foreach (Button seat in list_HTTYD3_Seats_2000)
            {
                Panel_Seats_HTTYD3.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void BTN_HTTDY3_Reset_Click(object sender, EventArgs e)
        {
            Panel_Seats_HTTYD3.Controls.Clear();
            list_HTTYD3_Seats_1230.Clear();
            list_HTTYD3_Seats_2000.Clear();
            list_HTTYD3_Seats_2000.Clear();
            Seats_HTTYD3_Generate_1230();
            Seats_HTTDY3_Generate_1505();
            Seats_HTTYD3_Generate_2000();
        }

        public void Seats_HTTYD3_Generate_1230()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button tombol = new Button();
                    tombol.Size = new Size(25, 25);
                    tombol.Location = new Point(location1 + 30 * i, location2 + 25 * j);
                    tombol.Tag = j.ToString() + "," + i.ToString();
                    tombol.BackColor = Color.LightGreen;
                    tombol.Click += new EventHandler(Tombol_Click_HTTYD3_Seats1);
                    Panel_Seats_HTTYD3.Controls.Add(tombol);
                    list_HTTYD3_Seats_1230.Add(tombol);
                }
            }
        }

        public void Seats_HTTDY3_Generate_1505()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button tombol = new Button();
                    tombol.Size = new Size(25, 25);
                    tombol.Location = new Point(location1 + 30 * i, location2 + 25 * j);
                    tombol.Tag = j.ToString() + "," + i.ToString();
                    tombol.BackColor = Color.LightGreen;
                    tombol.Click += new EventHandler(Tombol_Click_HTTDY3_Seats2);
                    Panel_Seats_HTTYD3.Controls.Add(tombol);
                    list_HTTYD3_Seats_1505.Add(tombol);
                }
            }
        }

        public void Seats_HTTYD3_Generate_2000()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button tombol = new Button();
                    tombol.Size = new Size(25, 25);
                    tombol.Location = new Point(location1 + 30 * i, location2 + 25 * j);
                    tombol.Tag = j.ToString() + "," + i.ToString();
                    tombol.BackColor = Color.LightGreen;
                    tombol.Click += new EventHandler(Tombol_Click_HTTDY3_Seats3);
                    Panel_Seats_HTTYD3.Controls.Add(tombol);
                    list_HTTYD3_Seats_2000.Add(tombol);
                }
            }
        }
    }
}
