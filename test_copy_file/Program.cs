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
        public static bool quit_app = false;
        [STAThread]

        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DeviceSelection());
            if(!quit_app)
            {
                if (path_device != "C:\\")
                {

                    if(File.Exists(path_device+"info.txt"))
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
                        else MessageBox.Show("wrong device selected");
                    }
                else MessageBox.Show("wrong device selected");
                //Application.Run(new Form_change_track());

                }
            }
            
            
        }
    }
}
