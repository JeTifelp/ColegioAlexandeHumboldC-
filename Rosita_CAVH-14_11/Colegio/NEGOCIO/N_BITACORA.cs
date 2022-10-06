using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Colegio.DATOS;




namespace Colegio.NEGOCIO
{
    class N_BITACORA
    {
        private BITACORA dBitacora = new BITACORA();

        public System.Data.DataTable listarBitacora()
        {
            return dBitacora.listarBitacora();
        }
        public System.Data.DataTable obtenerBitacora(DateTime inicio, DateTime fin)
        {
            dBitacora.FechaInicio = inicio;
            dBitacora.FechaFin = fin;
            return dBitacora.obtenerBitacora();
        }
    }
}
