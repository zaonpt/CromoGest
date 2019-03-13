using CromoGest.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CromoGestLibrary;

namespace CromoGest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.InicializarConns(ConnType.LOCALDB);
            Application.Run(new CadernetaForm());
        //    Application.Run(new Form1());

        }
    }
}
