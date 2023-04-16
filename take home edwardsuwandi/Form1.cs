using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace take_home_edwardsuwandi
{

    public partial class Form1 : Form
    {
        PictureBox foto1 = new PictureBox();
        PictureBox foto2 = new PictureBox();
        PictureBox foto3 = new PictureBox();
        PictureBox foto4 = new PictureBox();
        PictureBox foto5 = new PictureBox();
        PictureBox foto6 = new PictureBox();
        PictureBox foto7 = new PictureBox();
        PictureBox foto8 = new PictureBox();
        PictureBox foto9 = new PictureBox();
        PictureBox foto10 = new PictureBox();

        //list dari txt
        List<string> movielist = new List<string>();

        //list buy button
        List<Button> buttonbeli = new List<Button>();

        //list judul film
        List<Label> labelbeli = new List<Label>();

        //list tempat duduk
        List<Button> listseat = new List<Button>();

        //list text jam
        List<string> listjam = new List<string>();

        //list button semua jam
        List<Button> listbuttongabungan = new List<Button>();

        //list hasil random
        List<int> listhasilrandom = new List<int>();


        List<List<Button>> listgabungantempatduduk = new List<List<Button>>();

        Button buttonfilm;
        Label label;
        Button buttonasu;
        Label label2;

        Font font = new Font("rockwell", 11);
        Random rnd = new Random();

        string tampung = Properties.Resources.movies;
        string[] movies;
        int jam;
        int menit;
        string jamku;
        string menitku;
        string waktuku;
        int randomberapakali;
        int hasilrandom;
        char[] abjad = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        bool check = false;
        int counter = 0;
        Button current = new Button();

        public Form1()
        {
            InitializeComponent();

            movies = tampung.Split('\n');
            for (int i = 0; i < movies.Length; i++)
            {
                movielist.Add(movies[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelseat.Hide();
            paneljam.Hide();
            panel1.Show();
            panel1.BackColor = Color.Black;

            //foto poster film
            {
                foto1.Location = new Point(30, 80);
                foto1.Size = new Size(160, 200);
                foto1.Image = Properties.Resources.toystory;
                foto1.SizeMode = PictureBoxSizeMode.StretchImage;

                foto2.Location = new Point(250, 80);
                foto2.Size = new Size(160, 200);
                foto2.Image = Properties.Resources.iron_man_3;
                foto2.SizeMode = PictureBoxSizeMode.StretchImage;

                foto3.Location = new Point(470, 80);
                foto3.Size = new Size(160, 200);
                foto3.Image = Properties.Resources.avengers_end_game;
                foto3.SizeMode = PictureBoxSizeMode.StretchImage;

                foto4.Location = new Point(690, 80);
                foto4.Size = new Size(160, 200);
                foto4.Image = Properties.Resources.coco;
                foto4.SizeMode = PictureBoxSizeMode.StretchImage;

                foto5.Location = new Point(910, 80);
                foto5.Size = new Size(160, 200);
                foto5.Image = Properties.Resources.kingsman;
                foto5.SizeMode = PictureBoxSizeMode.StretchImage;

                foto6.Location = new Point(30, 375);
                foto6.Size = new Size(160, 200);
                foto6.Image = Properties.Resources.conjuring;
                foto6.SizeMode = PictureBoxSizeMode.StretchImage;

                foto7.Location = new Point(250, 375);
                foto7.Size = new Size(160, 200);
                foto7.Image = Properties.Resources.insidious;
                foto7.SizeMode = PictureBoxSizeMode.StretchImage;

                foto8.Location = new Point(470, 375);
                foto8.Size = new Size(160, 200);
                foto8.Image = Properties.Resources.aquaman;
                foto8.SizeMode = PictureBoxSizeMode.StretchImage;

                foto9.Location = new Point(690, 375);
                foto9.Size = new Size(160, 200);
                foto9.Image = Properties.Resources.thor;
                foto9.SizeMode = PictureBoxSizeMode.StretchImage;

                foto10.Location = new Point(910, 375);
                foto10.Size = new Size(160, 200);
                foto10.Image = Properties.Resources.the_greatest_showman;
                foto10.SizeMode = PictureBoxSizeMode.StretchImage;

                panel1.Controls.Add(foto1);
                panel1.Controls.Add(foto2);
                panel1.Controls.Add(foto3);
                panel1.Controls.Add(foto4);
                panel1.Controls.Add(foto5);
                panel1.Controls.Add(foto6);
                panel1.Controls.Add(foto7);
                panel1.Controls.Add(foto8);
                panel1.Controls.Add(foto9);
                panel1.Controls.Add(foto10);
            }
            //label judul film
            {
                for (int i = 0; i < 10; i++)
                {
                    label = new Label();
                    label.Location = new Point(i * 220 + 65, 290);
                    label.Size = new Size(150, 30);
                    label.Font = font;
                    if (i == 2)
                        label.Location = new Point(i * 200 + 75, 290);
                    if (i == 3)
                        label.Location = new Point(i * 225 + 75, 290);
                    if (i == 5)
                        label.Location = new Point((i - 5) * 215 + 50, 585);
                    if (i == 6)
                        label.Location = new Point((i - 5) * 215 + 50, 585);
                    if (i == 7)
                        label.Location = new Point((i - 5) * 230 + 50, 585);
                    if (i == 8)
                        label.Location = new Point((i - 5) * 220 + 50, 585);
                    if (i == 9)
                    {
                        label.Location = new Point((i - 5) * 215 + 50, 585);
                        label.Size = new Size(180, 30);
                    }
                    label.ForeColor = Color.White;
                    this.panel1.Controls.Add(label);
                    labelbeli.Add(label);
                }
                for (int i = 0; i < movielist.Count; i++)
                {
                    labelbeli[i].Text = movielist[i];
                }
                //label judul web
                {
                    label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(panel1.Left, 15);
                    label.Size = new Size(1080, 50);
                    label.Font = new Font("bebas neue", 20);
                    label.Text = "WAKFLIX";
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Red;
                    panel1.Controls.Add(label);
                }
            }
            //button beli
            {
                for (int i = 0; i < 10; i++)
                {
                    buttonfilm = new Button();
                    buttonfilm.Size = new Size(80, 30);
                    buttonfilm.Location = new Point(i * 220 + 65, 320);
                    if (i > 4)
                    {
                        buttonfilm.Location = new Point((i - 5) * 220 + 65, 615);
                    }
                    buttonfilm.Text = "Buy";
                    buttonfilm.Font = font;
                    buttonfilm.BackColor = Color.Red;
                    buttonfilm.ForeColor = Color.White;

                    this.panel1.Controls.Add(buttonfilm);
                    buttonbeli.Add(buttonfilm);
                    buttonfilm.Click += button_Click;
                }
            }
            //set text jam
            {
                check = false;
                for (int i = 0; i < 30; i++)
                {
                ulang:
                    jam = rnd.Next(0, 24);
                    menit = rnd.Next(0, 60);
                    jamku = jam.ToString();
                    menitku = menit.ToString();
                    if (jam < 10)
                    {
                        jamku = "0" + jam;
                    }
                    if (menit < 10)
                    {
                        menitku = "0" + menit;
                    }
                    waktuku = jamku + ":" + menitku;
                    for (int j = 0; j < listjam.Count; j++)
                    {
                        if (waktuku == listjam[j])
                        {
                            check = true;
                        }
                    }
                    if (check == true)
                    {
                        goto ulang;
                    }
                    else
                    {
                        listjam.Add(waktuku);
                    }
                }
            }

            //buat buttonjam
            {
                for (int i = 0; i < 30; i++)
                {
                    if (i % 3 == 0)
                    {
                        counter = 0;
                    }
                    buttonasu = new Button();
                    buttonasu.Text = listjam[i];
                    buttonasu.Location = new Point((counter * 80) + paneljam.Width / 2 - 120, 80);
                    buttonasu.Size = new Size(70, 30);
                    buttonasu.BackColor = Color.Red;

                    buttonasu.Click += buttonjam_Click;
                    buttonasu.Tag = i;
                    counter++;
                    listbuttongabungan.Add(buttonasu);
                }
            }
            //randomize tempat duduk
            {
                for (int a = 0; a < 30; a++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            buttonfilm = new Button();
                            buttonfilm.Location = buttonfilm.Location = new Point(160 + (55 * i), +(50 * j));
                            if (3 <= i && i <= 6)
                            {
                                buttonfilm.Location = buttonfilm.Location = new Point(180 + (55 * i), +(50 * j));
                            }
                            if (i >= 7 && i <= 9)
                            {
                                buttonfilm.Location = buttonfilm.Location = new Point(200 + (55 * i), +(50 * j));
                            }
                            buttonfilm.Size = new Size(50, 50);
                            buttonfilm.BackColor = Color.White;
                            buttonfilm.Text = abjad[j] + (i + 1).ToString();
                            buttonfilm.Click += buttonseat_Click;
                            listseat.Add(buttonfilm);
                        }
                    }
                    randomberapakali = rnd.Next(71);
                    for (int b = 0; b <= randomberapakali; b++)
                    {
                        hasilrandom = rnd.Next(listseat.Count);
                        listhasilrandom.Add(hasilrandom);
                    }
                    for (int i = 0; i < listhasilrandom.Count; i++)
                    {
                        listseat[listhasilrandom[i]].BackColor = Color.Red;
                        listseat[listhasilrandom[i]].Enabled = false;
                    }
                    listgabungantempatduduk.Add(listseat);
                }
            }

        }

        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            paneljam.Controls.Remove(label);
            paneljam.Controls.Remove(buttonfilm);
            panelseat.Show();
            paneljam.Show();
            panelseat.BackColor = Color.Black;
            paneljam.BackColor = Color.Red;

            //label judul yang dipilih
            {
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(paneljam.Width / 2 - 150, 30);
                label.Font = new Font("bebas neue", 20);
                label.Size = new Size(300, 35);
                label.BackColor = Color.Black;
                for (int i = 0; i < movielist.Count; i++)
                {
                    if (button == buttonbeli[i])
                    {
                        label.Text = movielist[i];
                    }
                }
                label.ForeColor = Color.White;
                paneljam.Controls.Add(label);
            }

            //add buttonlist ke paneljam
            for (int i = 0; i < buttonbeli.Count; i++)
            {
                if (button == buttonbeli[i])
                {
                    paneljam.Controls.Add(listbuttongabungan[i * 3]);
                    paneljam.Controls.Add(listbuttongabungan[i * 3 + 1]);
                    paneljam.Controls.Add(listbuttongabungan[i * 3 + 2]);
                }
            }

            //backbutton
            {
                buttonfilm = new Button();
                buttonfilm.Location = new Point(paneljam.Left + 30, 80);
                buttonfilm.Text = "Back";
                buttonfilm.Size = new Size(70, 30);
                buttonfilm.BackColor = Color.Black;
                buttonfilm.ForeColor = Color.White;
                paneljam.Controls.Add(buttonfilm);
                buttonfilm.Click += buttonback_Click;
            }

            //reset availability
            {
                buttonfilm = new Button();
                buttonfilm.Location = new Point(paneljam.Left + 30, 20);
                buttonfilm.Text = "Reset Seating";
                buttonfilm.Size = new Size(70, 30);
                buttonfilm.BackColor = Color.Black;
                buttonfilm.ForeColor = Color.White;
                paneljam.Controls.Add(buttonfilm);
                buttonfilm.Click += buttonreset_Click;
            }

            //button submit
            {
                buttonfilm = new Button();
                buttonfilm.Location = new Point(paneljam.Left + 100, 80);
                buttonfilm.Text = "Submit";
                buttonfilm.Size = new Size(70, 30);
                buttonfilm.BackColor = Color.Black;
                buttonfilm.ForeColor = Color.White;
                paneljam.Controls.Add(buttonfilm);
                buttonfilm.Click += buttonsubmit_Click;

              
            }
            //label current 
            label2 = new Label();
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Location = new Point (paneljam.Left + 180, 80);
            label2.Font = new Font("bebas neue", 20);
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Text = "pilihan : ";
            label2.ForeColor = Color.White;
            paneljam.Controls.Add(label2);
        }

        public void buttonback_Click(object sender, EventArgs e)
        {
            paneljam.Hide();
            panelseat.Hide();
            panelseat.Controls.Clear();
            paneljam.Controls.Clear();

            for (int i = 0; i < listseat.Count; i++)
            {
                if (listseat[i].BackColor == Color.Yellow)
                {
                    listseat[i].BackColor = Color.White;
                }
            }
        }

        public void buttonjam_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //show panelseat panel
            panelseat.Visible = true;
            panelseat.Controls.Clear();

            for (int i = 0; i < listbuttongabungan.Count; i++)
            {
                if(button == listbuttongabungan[i])
                {
                    for (int j = i*100 ; j < i*100+100; j++)
                    {
                        panelseat.Controls.Add(listseat[j]);
                        current = listbuttongabungan[i];
                    }
                }
            }
        }
        public void buttonseat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            for(int i = 0; i < listseat.Count; i++)
            {
                if (button == listseat[i] && listseat[i].BackColor == Color.White)
                {
                        listseat[i].BackColor = Color.Yellow;
                    label2.Text = label2.Text + listseat[i].Text;
                }
                else if (button == listseat[i] && listseat[i].BackColor == Color.Yellow)
                {
                    listseat[i].BackColor = Color.White;
                }
            }
            
        }

        public void buttonreset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listbuttongabungan.Count; i++)
            {
                if (current == listbuttongabungan[i])
                {
                    for (int j = i * 100; j < i * 100 + 100; j++)
                    {
                        listseat[j].Enabled = true;
                        listseat[j].BackColor = Color.White;
                    }
                }
            }
        }

        public void buttonsubmit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int taek = 0;
            for (int i = 0; i < listbuttongabungan.Count; i++)
            {
                if (current == listbuttongabungan[i])
                {
                    for (int j = i * 100; j < i * 100 + 100; j++)
                    {
                        if (listseat[j].BackColor == Color.Yellow)
                        {
                            listseat[j].BackColor = Color.Red;
                            listseat[j].Enabled = false;
                            taek++;
                        }
                    }
                }
            }
            if (taek == 0)
            {
                MessageBox.Show("select dlu jing");
            }
            else
            { 
            MessageBox.Show("udh kbli jing");

            }

        }

    }
}
