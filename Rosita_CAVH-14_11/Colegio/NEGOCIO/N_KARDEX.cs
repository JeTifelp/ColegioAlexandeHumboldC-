using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;
using System.Data.SqlClient;

namespace Colegio.CONEXION
{
    class N_KARDEX
    {
        private KARDEX kardex = new KARDEX();

        public void insertar(String id_kardex, String curso, String nivel, String colegio_precedencia,
            String Gestion, String Hermanos_Colegio, String Lugar_Nac, String idalumno)
        {
            kardex.setID_KARDEX(id_kardex);
            kardex.setCurso(curso);
            kardex.setNivel(nivel);
            kardex.setColegio_Precedencia(colegio_precedencia);
            kardex.setGestion(Gestion);
            kardex.setHermanos_En_El_Colegio(Hermanos_Colegio);
            kardex.setLugar_De_Nac(Lugar_Nac);
            kardex.getID_ALUMNO().setID_alumno(idalumno);
            kardex.insertar();
        }

        public void modificar(String id_kardex, String curso, String nivel, String colegio_precedencia,
            String Gestion, String Hermanos_Colegio, String Lugar_Nac, String idalumno)
        {
            kardex.getID_ALUMNO().setID_alumno(idalumno);
            kardex.setID_KARDEX(id_kardex);
            kardex.setCurso(curso);
            kardex.setNivel(nivel);
            kardex.setColegio_Precedencia(colegio_precedencia);
            kardex.setGestion(Gestion);
            kardex.setHermanos_En_El_Colegio(Hermanos_Colegio);
            kardex.setLugar_De_Nac(Lugar_Nac);
            kardex.modificar();
        }

        public void eliminar(String id_Kardex)
        {
            kardex.setID_KARDEX(id_Kardex);
            kardex.eliminar();
        }

        public void buscar(String ID_Kardex)
        {
            kardex.setID_KARDEX(ID_Kardex);
            kardex.buscar();
        }

        public DataTable MOSTRAR()
        {
            return kardex.mostrar2();
        }


    }
}
