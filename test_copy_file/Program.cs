using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test_copy_file
{
    static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        public static string path_device;
        public static string[] config;
        public static bool run_check = false;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DeviceSelection());
            if(run_check)
            {
                if (path_device != "C:\\")
                {

                    if(File.Exists(path_device+"info.txt") && Directory.Exists(path_device + "\\tracks\\"))
                    {
                        try
                        {
                           
                            config = File.ReadAllLines(path_device + "info.txt");
                            
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        if (config[0] == "PFE_PRESSION_2") Application.Run(new Form_change_track());
                        else MessageBox.Show("appareil non conforme");
                    }
                    else MessageBox.Show("appareil non conforme");

                }
            }
            
            
        }
    }
}
