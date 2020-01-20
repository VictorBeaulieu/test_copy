using System;
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
        
        string[] array_short_fileName_copy = new string[8];
        string[] array_short_safeFileName_copy = new string[8];
        string[] array_long_fileName_copy = new string[8];
        string[] array_long_safeFileName_copy = new string[8];
        string copy_location;
        List<Button> list_btn_long;
        List<Button> list_btn_short;

        public Form_change_track()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

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

            list_btn_short.Add(btn_track_short_1);
            list_btn_short.Add(btn_track_short_2);
            list_btn_short.Add(btn_track_short_3);
            list_btn_short.Add(btn_track_short_4);
            list_btn_short.Add(btn_track_short_5);
            list_btn_short.Add(btn_track_short_6);
            list_btn_short.Add(btn_track_short_7);
            list_btn_short.Add(btn_track_short_8);


            Console.WriteLine(Program.path_device);
            Console.WriteLine(Program.config[1]);
            Console.WriteLine(Program.config[2]);
            comboBox1.SelectedIndex = Int16.Parse(Program.config[1]) ;
            comboBox2.SelectedIndex = Int16.Parse(Program.config[2]) ;

        }
        

        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            set_visibility_off_btn_long_track(list_btn_short);
            set_visibility_on_btn_long_track(list_btn_short, comboBox1.SelectedIndex);
        }

        private bool save_fileName_track_short(int i)
        {
            bool res = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "wav files (*.wav)|*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                array_short_fileName_copy[i] = openFileDialog1.FileName;
                array_short_safeFileName_copy[i] = openFileDialog1.SafeFileName;
                Console.WriteLine("file name : " + array_short_fileName_copy[i]);
                Console.WriteLine("safe file name : " + array_short_safeFileName_copy[i]);
                res = true;
            }
            
            return res;
        }

        private bool save_fileName_track_long(int i)
        {
            bool res = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "wav files (*.wav)|*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                array_long_fileName_copy[i] = openFileDialog1.FileName;
                array_long_safeFileName_copy[i] = openFileDialog1.SafeFileName;
                Console.WriteLine("file name : " + array_long_fileName_copy[i]);
                Console.WriteLine("safe file name : " + array_long_safeFileName_copy[i]);
                res = true;
            }

            return res;
        }

        private void Btn_track_1_Click(object sender, EventArgs e)
        {

            if (save_fileName_track_short(0))
            {
                btn_track_short_1.BackColor = Color.Green;
            }
            Program.config[1] = "1";
        }

        private void Btn_track_2_Click(object sender, EventArgs e)
        {
            
            if (save_fileName_track_short(1))
            {
                btn_track_short_2.BackColor = Color.Green;
            }
            Program.config[1] = "2";
        }

        private void Btn_track_3_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(2))
            {
                btn_track_short_3.BackColor = Color.Green;
            }
            Program.config[1] = "3";
        }

        private void Btn_track_4_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(3))
            {
                btn_track_short_4.BackColor = Color.Green;
            }
            Program.config[1] = "4";
        }

        private void Btn_track_5_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(4))
            {
                btn_track_short_5.BackColor = Color.Green;
            }
            Program.config[1] = "5";
        }

        private void Btn_track_6_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(5))
            {
                btn_track_short_6.BackColor = Color.Green;
            }
            Program.config[1] = "6";
        }

        private void Btn_track_7_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(6))
            {
                btn_track_short_7.BackColor = Color.Green;
            }
            Program.config[1] = "7";
        }

        private void Btn_track_8_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_short(7))
            {
                btn_track_short_7.BackColor = Color.Green;
            }
            Program.config[1] = "8";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            copy_location = Program.path_device + "track\\";
            Console.WriteLine(copy_location + array_short_safeFileName_copy[0]);


            if (check_path_short())
            {
                for (int i = 0; i < comboBox1.SelectedIndex + 1; i++)
                {
                    File.Copy(array_short_fileName_copy[i], copy_location + "track_short" + (i + 1).ToString() + ".wav", true);
                }
                del_track_short();
            }
            else MessageBox.Show("you should register all path tracks");
            if (check_path_long())
            {
                for (int i = 0; i < comboBox2.SelectedIndex + 1; i++)
                {
                    File.Copy(array_long_fileName_copy[i], copy_location + "track_long" + (i + 1).ToString() + ".wav", true);
                }
                del_track_long();
            }
            else MessageBox.Show("you should register all path tracks");

            /*File.Delete(Program.path_device + "info.txt");
            File.AppendAllLines(Program.path_device + "info.txt", Program.config);*/

            Console.WriteLine("//////copy///////");
            foreach (string item in Program.config)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array_short_fileName_copy :");
            foreach (string item in array_short_fileName_copy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array_short_safeFileName_copy :");
            foreach (string item in array_short_safeFileName_copy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array_long_fileName_copy :");
            foreach (string item in array_long_fileName_copy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array_long_safeFileName_copy :");
            foreach (string item in array_long_safeFileName_copy)
            {
                Console.WriteLine(item);
            }
            
        }

        private void del_track_short()
        {
            for (int i = comboBox1.SelectedIndex+2; i < 9; i++)
            {
                if(File.Exists(Program.path_device + "track\\" + "track_short_" + i.ToString() + ".wav"))
                {
                    File.Delete(Program.path_device + "track\\" + "track_short_" + i.ToString() + ".wav");
                }
            }
        }
        private void del_track_long()
        {
            for (int i = comboBox2.SelectedIndex + 2; i < 9; i++)
            {
                if (File.Exists(Program.path_device + "track\\" + "track_long_" + i.ToString() + ".wav"))
                {
                    File.Delete(Program.path_device + "track\\" + "track_long_" + i.ToString() + ".wav");
                }
            }
        }

        private bool check_path_short()
        {
            bool res = true;
            
            for (int i = 0; i < comboBox1.SelectedIndex+1; i++)
            {
                if (array_short_fileName_copy[i] == null)
                {
                    res = false;
                }
                
            }
            
            return res;
        }

        private bool check_path_long()
        {
            bool res = true;

            for (int i = 0; i < comboBox2.SelectedIndex + 1; i++)
            {
                if (array_long_fileName_copy[i] == null)
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
            set_visibility_on_btn_long_track(list_btn_long, comboBox2.SelectedIndex);
        }

        private void btn_track_long_1_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(0))
            {
                btn_track_long_1.BackColor = Color.Green;
            }
            Program.config[2] = "1";
        }

        private void btn_track_long_2_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(1))
            {
                btn_track_long_2.BackColor = Color.Green;
            }
            Program.config[2] = "2";
        }

        private void btn_track_long_3_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(2))
            {
                btn_track_long_3.BackColor = Color.Green;
            }
            Program.config[2] = "3";
        }

        private void btn_track_long_4_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(3))
            {
                btn_track_long_4.BackColor = Color.Green;
            }
            Program.config[2] = "4";
        }

        private void btn_track_long_5_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(4))
            {
                btn_track_long_5.BackColor = Color.Green;
            }
            Program.config[2] = "5";
        }

        private void btn_track_long_6_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(5))
            {
                btn_track_long_6.BackColor = Color.Green;
            }
            Program.config[2] = "6";
        }

        private void btn_track_long_7_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(6))
            {
                btn_track_long_7.BackColor = Color.Green;
            }
            Program.config[2] = "7";
        }

        private void btn_track_long_8_Click(object sender, EventArgs e)
        {
            if (save_fileName_track_long(7))
            {
                btn_track_long_8.BackColor = Color.Green;
            }
            Program.config[2] = "8";
        }
    }
}
