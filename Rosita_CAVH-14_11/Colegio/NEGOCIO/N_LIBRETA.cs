using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;


namespace Colegio.NEGOCIO
{
    class N_LIBRETA
    {
        private LIBRETA libreta = new LIBRETA();

        public void insertar(String IDLIBRETA, String Anio, String curso,String materia ,int NOTAREFORZAMIENTO,
            int NOTAANUAl,String idemplea,String idalumnoo)
        {
            libreta.setIdLibreta(IDLIBRETA);
            libreta.setAnio(Anio);
            libreta.setCURSSO(curso);
            libreta.setMATERRIA(materia);
            libreta.setNotaReforzamiento(NOTAREFORZAMIENTO);
            libreta.setNotaAnual(NOTAANUAl);
            libreta.getID_empleado().SETID_EMPLEADO(idemplea);
            libreta.getID_alumno().setID_alumno(idalumnoo);
            libreta.insertar();
        }

        /*
ID_LIBRETA VARCHAR (10) NOT NULL,
AÑO INT,
CURSO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
NOTA_REFORZAMIENTO INT,
NOTA_ANUAL INT,
ID_EMPLEADO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
*/

        public void modificar(String IDLIBRETA, String Anio, String curso, String materia, int NOTAREFORZAMIENTO,
            int NOTAANUAl, String idemplea, String idalumnoo)
        {
            libreta.setIdLibreta(IDLIBRETA);
            libreta.setAnio(Anio);
            libreta.setCURSSO(curso);
            libreta.setMATERRIA(materia);
            libreta.setNotaReforzamiento(NOTAREFORZAMIENTO);
            libreta.setNotaAnual(NOTAANUAl);
            libreta.getID_empleado().SETID_EMPLEADO(idemplea);
            libreta.getID_alumno().setID_alumno(idalumnoo);
            libreta.modificar();
        }

        public void eliminar(String id_Libreta)
        {
            libreta.setIdLibreta(id_Libreta);
            libreta.eliminar();
        }

        public void buscar(String IDLIb)
        {
            libreta.setIdLibreta(IDLIb);
            libreta.buscar();
        }

        public DataTable MOSTRAR()
        {
            return libreta.mostrarLIBRETA();
        }

    }
}
