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
    public partial class KNIVES2 : Form
    {
        Panel Panel_Seats_KNIVES2 = new Panel();
        List<Button> list_KNIVES2_Seats_1230 = new List<Button>();
        List<Button> list_KNIVES2_Seats_1505 = new List<Button>();
        List<Button> list_KNIVES2_Seats_2000 = new List<Button>();

        int location1 = 10;
        int location2 = 10;

        int counter = 0;
        int choose = 0;

        Label seatschoosen = new Label();
        Random Seasts = new Random();

        public KNIVES2()
        {
            InitializeComponent();
        }

        private void KNIVES2_Load(object sender, EventArgs e)
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

            // GLASS ONION
            Label LB_KNIVES2 = new Label();
            LB_KNIVES2.AutoSize = true;
            LB_KNIVES2.BackColor = SystemColors.Control;
            LB_KNIVES2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            LB_KNIVES2.Location = new Point(12, 94);
            LB_KNIVES2.Name = "LB_KNIVES2";
            LB_KNIVES2.Size = new Size(112, 23);
            LB_KNIVES2.TabIndex = 2;
            LB_KNIVES2.Text = "GLASS ONION";
            Controls.Add(LB_KNIVES2);

            // GLASS ONION BANNER
            PictureBox PB_KNIVES2 = new PictureBox();
            PB_KNIVES2.BackColor = SystemColors.Control;
            PB_KNIVES2.Image = Properties.Resources.KNIVES_OUT_2;
            PB_KNIVES2.Location = new Point(12, 120);
            PB_KNIVES2.Name = "PB_KNIVES2";
            PB_KNIVES2.Size = new Size(167, 202);
            PB_KNIVES2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_KNIVES2.TabIndex = 3;
            PB_KNIVES2.TabStop = false;
            Controls.Add(PB_KNIVES2);

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
            Button BTN_KNIVES21230 = new Button();
            BTN_KNIVES21230.BackColor = SystemColors.WindowFrame;
            BTN_KNIVES21230.ForeColor = Color.Bisque;
            BTN_KNIVES21230.Location = new Point(185, 147);
            BTN_KNIVES21230.Name = "BTN_KNIVES21230";
            BTN_KNIVES21230.Size = new Size(116, 41);
            BTN_KNIVES21230.TabIndex = 5;
            BTN_KNIVES21230.Text = "12:30";
            BTN_KNIVES21230.UseVisualStyleBackColor = false;
            Controls.Add(BTN_KNIVES21230);
            BTN_KNIVES21230.Click += (BTN_KNIVES21230_CLICK);

            // 15:50
            Button BTN_KNIVES21505 = new Button();
            BTN_KNIVES21505.BackColor = SystemColors.WindowFrame;
            BTN_KNIVES21505.ForeColor = Color.Bisque;
            BTN_KNIVES21505.Location = new Point(185, 241);
            BTN_KNIVES21505.Name = "BTN_KNIVES21505";
            BTN_KNIVES21505.Size = new Size(116, 41);
            BTN_KNIVES21505.TabIndex = 6;
            BTN_KNIVES21505.Text = "15:05";
            BTN_KNIVES21505.UseVisualStyleBackColor = false;
            Controls.Add(BTN_KNIVES21505);
            BTN_KNIVES21505.Click += (BTN_KNIVES21505_CLICK);

            // 20:00
            Button BTN_KNIVES22000 = new Button();
            BTN_KNIVES22000.BackColor = SystemColors.WindowFrame;
            BTN_KNIVES22000.ForeColor = Color.Bisque;
            BTN_KNIVES22000.Location = new Point(185, 194);
            BTN_KNIVES22000.Name = "BTN_KNIVES22000";
            BTN_KNIVES22000.Size = new Size(116, 41);
            BTN_KNIVES22000.TabIndex = 7;
            BTN_KNIVES22000.Text = "20:00";
            BTN_KNIVES22000.UseVisualStyleBackColor = false;
            Controls.Add(BTN_KNIVES22000);
            BTN_KNIVES22000.Click += (BTN_KNIVES22000_CLICK);

            // SEATS GLASS ONION
            Panel_Seats_KNIVES2.BackColor = SystemColors.ActiveBorder;
            Panel_Seats_KNIVES2.Location = new Point(435, 94);
            Panel_Seats_KNIVES2.Name = "Panel_Seats_KNIVES1";
            Panel_Seats_KNIVES2.Size = new Size(318, 275);
            Panel_Seats_KNIVES2.TabIndex = 8;
            Controls.Add(Panel_Seats_KNIVES2);

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
            Button BTN_KNIVES2_Reserve = new Button();
            BTN_KNIVES2_Reserve.BackColor = SystemColors.WindowFrame;
            BTN_KNIVES2_Reserve.ForeColor = Color.Bisque;
            BTN_KNIVES2_Reserve.Location = new Point(300, 324);
            BTN_KNIVES2_Reserve.Name = "button2";
            BTN_KNIVES2_Reserve.Size = new Size(116, 41);
            BTN_KNIVES2_Reserve.TabIndex = 7;
            BTN_KNIVES2_Reserve.Text = "Reserve";
            BTN_KNIVES2_Reserve.UseVisualStyleBackColor = false;
            Controls.Add(BTN_KNIVES2_Reserve);
            BTN_KNIVES2_Reserve.Click += (BTN_KNIVES2_Reserve_Click);

            // RESET BUTTON
            Button BTN_KNIVES2_Reset = new Button();
            BTN_KNIVES2_Reset.BackColor = SystemColors.WindowFrame;
            BTN_KNIVES2_Reset.ForeColor = Color.Bisque;
            BTN_KNIVES2_Reset.Location = new Point(300, 277);
            BTN_KNIVES2_Reset.Name = "button2";
            BTN_KNIVES2_Reset.Size = new Size(116, 41);
            BTN_KNIVES2_Reset.TabIndex = 7;
            BTN_KNIVES2_Reset.Text = "Reset";
            BTN_KNIVES2_Reset.UseVisualStyleBackColor = false;
            Controls.Add(BTN_KNIVES2_Reset);
            BTN_KNIVES2_Reset.Click += (BTN_KNIVES2_Reset_Click);

            // SEAT BUTTONS 12:30
            Panel_Seats_KNIVES2.Controls.Clear();
            Seats_KNIVES2_Generate_1230();

            // RANDOM SEATS12:30
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_KNIVES2_Seats_1230[random].BackColor = Color.Red;
                list_KNIVES2_Seats_1230[random].Enabled = false;
            }

            // SEAT BUTTONS 15:05
            Panel_Seats_KNIVES2.Controls.Clear();
            Seats_KNIVES2_Generate_1505();


            // RANDOM SEATS 15:05
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_KNIVES2_Seats_1505[random].BackColor = Color.Red;
                list_KNIVES2_Seats_1505[random].Enabled = false;
            }

            // SEATS BUTTONS 20:00
            Panel_Seats_KNIVES2.Controls.Clear();
            Seats_KNIVES2_Generate_2000();


            // RANDOM SEATS 20:00
            for (int i = 0; i < 70; i++)
            {
                int random = Seasts.Next(0, 100);
                list_KNIVES2_Seats_2000[random].BackColor = Color.Red;
                list_KNIVES2_Seats_2000[random].Enabled = false;
            }
        }
        private void BTN_BACK_CLICK(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_KNIVES21230_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            choose = 1;
            foreach (Button seat in list_KNIVES2_Seats_1230)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }
        }

        private void BTN_KNIVES21505_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            choose = 2;
            foreach (Button seat in list_KNIVES2_Seats_1505)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }

        }

        private void BTN_KNIVES22000_CLICK(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            choose = 3;
            foreach (Button seat in list_KNIVES2_Seats_2000)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }
        }

        private void BTN_KNIVES2_Reserve_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                foreach (Button button in list_KNIVES2_Seats_1230)
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
                foreach (Button button in list_KNIVES2_Seats_1505)
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
                foreach (Button button in list_KNIVES2_Seats_2000)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
        }

        private void Tombol_Click_KNIVES2_Seats1(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();

            foreach (Button seat in list_KNIVES2_Seats_1230)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void Tombol_Click_KNIVES2_Seats2(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            foreach (Button seat in list_KNIVES2_Seats_1505)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void Tombol_Click_KNIVES2_Seats3(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            foreach (Button seat in list_KNIVES2_Seats_2000)
            {
                Panel_Seats_KNIVES2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatschoosen.Text += button.Tag.ToString();
            }

        }

        private void BTN_KNIVES2_Reset_Click(object sender, EventArgs e)
        {
            Panel_Seats_KNIVES2.Controls.Clear();
            list_KNIVES2_Seats_1230.Clear();
            list_KNIVES2_Seats_2000.Clear();
            list_KNIVES2_Seats_2000.Clear();
            Seats_KNIVES2_Generate_1230();
            Seats_KNIVES2_Generate_1505();
            Seats_KNIVES2_Generate_2000();
        }

        public void Seats_KNIVES2_Generate_1230()
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
                    tombol.Click += new EventHandler(Tombol_Click_KNIVES2_Seats1);
                    Panel_Seats_KNIVES2.Controls.Add(tombol);
                    list_KNIVES2_Seats_1230.Add(tombol);
                }
            }
        }

        public void Seats_KNIVES2_Generate_1505()
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
                    tombol.Click += new EventHandler(Tombol_Click_KNIVES2_Seats2);
                    Panel_Seats_KNIVES2.Controls.Add(tombol);
                    list_KNIVES2_Seats_1505.Add(tombol);
                }
            }
        }

        public void Seats_KNIVES2_Generate_2000()
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
                    tombol.Click += new EventHandler(Tombol_Click_KNIVES2_Seats3);
                    Panel_Seats_KNIVES2.Controls.Add(tombol);
                    list_KNIVES2_Seats_2000.Add(tombol);
                }
            }
        }
    }
}
