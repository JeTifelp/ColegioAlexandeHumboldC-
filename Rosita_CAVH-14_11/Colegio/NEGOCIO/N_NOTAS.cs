using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_NOTAS
    {
        private NOTAS nota = new NOTAS();

        public void insertar(String id_nota, String tipo, int calificacion,DateTime fecha, String materia, String curso, String id_trim, String id_alum)
        {

            nota.setID_NOTAS(id_nota);
            nota.setTIPO(tipo);
            nota.setCALIFICACION(calificacion);
            nota.setFECHA(fecha);
            nota.getMATERIA().setID_MATERIA(materia);
            nota.getCURSO().setID_CURSO(curso);
            nota.getID_TRIMESTRE().setIdTrimestral(id_trim );
            nota.getID_ALUMNO().setID_alumno(id_alum);
            nota.insertar();
        }

        public void modificar(String id_nota, String tipo, int calificacion, DateTime fecha, String materia, String curso, String id_trim, String id_alum)
        {
            nota.setID_NOTAS(id_nota);
            nota.setTIPO(tipo);
            nota.setCALIFICACION(calificacion);
            nota.setFECHA(fecha);
            nota.getMATERIA().setID_MATERIA(materia);
            nota.getCURSO().setID_CURSO(curso);
            nota.getID_TRIMESTRE().setIdTrimestral(id_trim);
            nota.getID_ALUMNO().setID_alumno(id_alum);
            nota.modificar();
        }

        public void eliminar(String id_not)
        {
            nota.setID_NOTAS(id_not);
            nota.eliminar();
        }

        public void buscar(String ID)
        {
            nota.setID_NOTAS(ID);
            nota.buscar();
        }

        /* public DataTable listar()
         {

             return certificado.Listar();
         }*/
        public DataTable MOSTRAR()
        {
            return nota.mostrar();       
        }
    }
}
