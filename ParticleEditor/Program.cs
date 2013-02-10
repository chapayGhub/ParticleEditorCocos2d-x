using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ParticleEditor
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
                Application.Run(new ParticleEditorForm());
            }
            catch (System.Exception ex)
            {
                string a = ex.Message;
            }
          
        }
    }
}
