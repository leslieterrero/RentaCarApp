using RentaCar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    static class Rentcar
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ClienteView());
            //Application.Run(new TipoVehiculoView());
            //Application.Run(new ModelosView());
            //Application.Run(new MarcasView());
            //Application.Run(new EmpleadoView());
            // Application.Run(new TipoCombustibleView());
            Application.Run(new RentaView());
             //Application.Run(new VehiculosView());
           // Application.Run(new InspeccionView());


        }
    }
}
