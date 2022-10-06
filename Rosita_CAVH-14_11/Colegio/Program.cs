using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Colegio.PRESENTACION;

namespace Colegio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       //     Application.Run(new FORM_realizar_inscripcion ());
            Application.Run(new AUTENTIFICACION());
            //Application.Run(new FormLUGARDENACIMIENTO ());
            //Application.Run(new FormNOTAS  ());
            //Application.Run(new FormCERTIFICADO());
        }
    }
}
