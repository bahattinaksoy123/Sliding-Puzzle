using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyBirthDayPrincess
{
    public partial class HappyBirthdayPrincess : Form
    {
        
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList  = new List<Bitmap>();


        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        public HappyBirthdayPrincess()
        {
            InitializeComponent();

            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._5_1, Properties.Resources._5_2, Properties.Resources._5_3, Properties.Resources._5_4, Properties.Resources._5_5, Properties.Resources._5_6, Properties.Resources._5_7, Properties.Resources._5_8, Properties.Resources._5_9, Properties.Resources._null });

        }


        void Shuffle()
        {

            while (true)
            {
             int[] slide_list = new int[9];

                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    slide_list[i] = j+1;
                    if (j == 9)
                    {
                        inNullSliceIndex = i;
                        slide_list[i] = 0;
                    }
                }

                int count=0;
                for(int i = 0; i < 9; i++)
                {
                    for(int jj = i+1; jj < 9; jj++)
                    {
                        if (slide_list[jj]>0 && slide_list[i]>0 && slide_list[i] > slide_list[jj]) count++;
                    }
                }

                if (count % 2 == 0) {
                    for(int i = 0; i < 9; i++)
                    {
                        try
                        {
                            ((PictureBox)panel.Controls[i]).Image = lstOriginalPictureList[(slide_list[i] - 1)];


                        }
                        catch (Exception hata)
                        {
                            ((PictureBox)panel.Controls[i]).Image = lstOriginalPictureList[9];

                        }
                    }
                    break; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lbl_time.Text = timer.Elapsed.ToString().Remove(8);
        }




        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
               if ((panel.Controls[(i)] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }



        private void SwitchPictureBox(object sender, EventArgs e)
        {
            int inPictureBoxIndex = panel.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)panel.Controls[inNullSliceIndex]).Image = ((PictureBox)panel.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)panel.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lbl_moves.Text = (++inmoves).ToString();
                    if (CheckWin())
                    {
                        timer.Stop();
                        inmoves = 0;
                        if(! pictureBox2.Visible)  pictureBox2.Visible=true;
                            pictureBox2.Image = Properties.Resources._5;
                        
                    }
                }
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            try {
            Cursor = new Cursor(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+ "\\Puzzlegame\\Puzzle\\8.cur");
            }
            catch(Exception hata)
            {
                try
                {
                    Cursor = new Cursor(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Puzzlegame\\Puzzle\\8.cur");

                }
                catch(Exception hatay) { 
                }
               

            }
            

            if (panel1.Visible) panel1.Visible = false;
            if (!label1.Visible) label1.Visible = true;
            if (!groupBox1.Visible) groupBox1.Visible = true;
            if (!lbl_time.Visible) lbl_time.Visible = true;
            if (!lbl_moves.Visible) lbl_moves.Visible = true;
        }

        void todo()
        {
            if (pictureBox2.Visible) pictureBox2.Visible = false;
            if (panel.Visible == false) panel.Visible = true;
            timer.Restart();
            timer.Start();
            inmoves = 0;
            lbl_moves.Text = inmoves.ToString();
            Shuffle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todo();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }



    }
}
