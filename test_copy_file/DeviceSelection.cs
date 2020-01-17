using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_copy_file
{
    public partial class DeviceSelection : Form
    {
        private List<string> volumeNames;
        public DeviceSelection()
        {
            InitializeComponent();
            List<string> unitesLogiques = new List<string>();
            volumeNames = new List<string>();


            foreach (DriveInfo f in DriveInfo.GetDrives())
            {
                string tmp;
                if (f.VolumeLabel != "") tmp = " (" + f.VolumeLabel + ")";
                else tmp = "";
                Console.WriteLine(f.Name);
                if (f.Name != "C:\\")
                {
                    volumeNames.Add(f.Name);
                    unitesLogiques.Add(f.Name + tmp);
                }
                
            }
            
            
            foreach (string item in unitesLogiques)
            {
                listUniteLogic.Items.Add(item);
            }
            listUniteLogic.SelectedIndex = 0;
        }

       

        private void Btn_valid_Click(object sender, EventArgs e)
        {
            string[] vl = volumeNames.ToArray();
            Program.path_device = vl[listUniteLogic.SelectedIndex];
            this.Close();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Program.quit_app = true;
            this.Close();
        }

        private void Btn_format_Click(object sender, EventArgs e)
        {
            
            string[] vl = volumeNames.ToArray();
            string path = vl[listUniteLogic.SelectedIndex].ToString();
            string[] default_config = { "PFE_PRESSION_2", "5","8","8"};
            
            try
            {
                //File.Create(path + "info.txt");
                if(File.Exists(path + "info.txt")) File.Delete(path + "info.txt");
                File.AppendAllLines(path + "info.txt", default_config);
                
                
            }
            catch (Exception)
            {

                throw;
            }
            if(File.Exists(path + "info.txt"))
            {
                MessageBox.Show("succeed");
            }
            else MessageBox.Show("failled");




        }
    }
}
