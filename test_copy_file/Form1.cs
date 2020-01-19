﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_copy_file
{
    public partial class Form_change_track : Form
    {
        
        string[] array_fileName_copy = new string[8];
        string[] array_safeFileName_copy = new string[8];
        string copy_location;
        List<Button> list_btn_long;
        List<Button> list_btn_short;

        public Form_change_track()
        {
            InitializeComponent();
            list_btn_short = new List<Button>();
            list_btn_long = new List<Button>();

            list_btn_long.Add(btn_track_long_1);
            list_btn_long.Add(btn_track_long_2);
            list_btn_long.Add(btn_track_long_3);
            list_btn_long.Add(btn_track_long_4);
            list_btn_long.Add(btn_track_long_5);
            list_btn_long.Add(btn_track_long_6);
            list_btn_long.Add(btn_track_long_7);
            list_btn_long.Add(btn_track_long_8);

            list_btn_short.Add(btn_track_1);
            list_btn_short.Add(btn_track_2);
            list_btn_short.Add(btn_track_3);
            list_btn_short.Add(btn_track_4);
            list_btn_short.Add(btn_track_5);
            list_btn_short.Add(btn_track_6);
            list_btn_short.Add(btn_track_7);
            list_btn_short.Add(btn_track_8);


            Console.WriteLine(Program.path_device);
            Console.WriteLine(Program.config[1]);
            comboBox1.SelectedIndex = Int16.Parse(Program.config[1])-1;
            comboBox2.SelectedIndex = Int16.Parse(Program.config[2]) - 1;

        }
        

        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            set_visibility_off_btn_long_track(list_btn_short);
            set_visibility_on_btn_long_track(list_btn_short, comboBox1.SelectedIndex + 1);
        }

        private bool save_fileName_track(int i)
        {
            bool res = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "wav files (*.wav)|*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                array_fileName_copy[i] = openFileDialog1.FileName;
                array_safeFileName_copy[i] = openFileDialog1.SafeFileName;
                Console.WriteLine("file name : " + array_fileName_copy[i]);
                Console.WriteLine("safe file name : " + array_safeFileName_copy[i]);
                res = true;
            }
            
            return res;
        }

        private void Btn_track_1_Click(object sender, EventArgs e)
        {

            if (save_fileName_track(0))
            {
                btn_track_1.BackColor = Color.Green;
            }
            Program.config[1] = "1";
        }

        private void Btn_track_2_Click(object sender, EventArgs e)
        {
            
            if (save_fileName_track(1))
            {
                btn_track_2.BackColor = Color.Green;
            }
            Program.config[1] = "2";
        }

        private void Btn_track_3_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(2))
            {
                btn_track_3.BackColor = Color.Green;
            }
            Program.config[1] = "3";
        }

        private void Btn_track_4_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(3))
            {
                btn_track_4.BackColor = Color.Green;
            }
            Program.config[1] = "4";
        }

        private void Btn_track_5_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(4))
            {
                btn_track_5.BackColor = Color.Green;
            }
            Program.config[1] = "5";
        }

        private void Btn_track_6_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(5))
            {
                btn_track_6.BackColor = Color.Green;
            }
            Program.config[1] = "6";
        }

        private void Btn_track_7_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(6))
            {
                btn_track_7.BackColor = Color.Green;
            }
            Program.config[1] = "7";
        }

        private void Btn_track_8_Click(object sender, EventArgs e)
        {
            if (save_fileName_track(7))
            {
                btn_track_7.BackColor = Color.Green;
            }
            Program.config[1] = "8";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            copy_location = Program.path_device + "track\\";
            Console.WriteLine(copy_location + array_safeFileName_copy[0]);


            if (check_path())
            {
                for (int i = 0; i < comboBox1.SelectedIndex + 1; i++)
                {
                    File.Copy(array_fileName_copy[i], copy_location + "track_" + (i + 1).ToString() + ".wav", true);
                }
                del_track();
            }
            else MessageBox.Show("you should register all path tracks");
            
            

            File.WriteAllLines(Program.path_device + "info.txt", Program.config);
        }

        private void del_track()
        {
            for (int i = comboBox1.SelectedIndex+2; i < 9; i++)
            {
                if(File.Exists(Program.path_device + "track\\" + "track_" + i.ToString() + ".wav"))
                {
                    File.Delete(Program.path_device + "track\\" + "track_" + i.ToString() + ".wav");
                }
            }
        }

        private bool check_path()
        {
            bool res = true;
            
            for (int i = 0; i < comboBox1.SelectedIndex+1; i++)
            {
                if (array_fileName_copy[i] == null)
                {
                    res = false;
                }
                
            }
            
            return res;
        }

        private void set_visibility_off_btn_long_track(List<Button> list_btn)
        {
            foreach (Button item in list_btn)
            {
                item.Visible = false;
            }
        }
        private void set_visibility_on_btn_long_track(List<Button> list_btn, int number)
        {
            for(int i = 0; i<number; i++)
            {
                list_btn[i].Visible = true;
            }
        }

        private void set_visibility_on_btn_long_track(List<Button> list_btn)
        {
            foreach (Button item in list_btn)
            {
                item.Visible = true;
            }
        }


        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_visibility_off_btn_long_track(list_btn_long);
            set_visibility_on_btn_long_track(list_btn_long, comboBox2.SelectedIndex+1);
        }
    }
}
