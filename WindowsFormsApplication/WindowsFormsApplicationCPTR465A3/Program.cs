using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApplicationCPTR465A3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new baseForm());



            }
            catch (System.IO.FileLoadException ex)
            {
               
                MessageBox.Show(ex.StackTrace);

            }
           
           
        }
    }
}
