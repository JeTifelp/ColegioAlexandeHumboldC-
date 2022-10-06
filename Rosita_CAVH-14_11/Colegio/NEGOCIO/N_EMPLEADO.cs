using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data.SqlClient;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_EMPLEADO
    {
        EMPLEADO empleado = new EMPLEADO();
        public void insertar(string id_empleado, string ap_PATERNO, string ap_MATERNO, string noMBRE, int telefono, String diRECCION,
    string estadocivil, DateTime fecha, String idcargo)
        {

            empleado.SETID_EMPLEADO(id_empleado);
            empleado.SETAP_PATERNO(ap_PATERNO);
            empleado.SETAP_MATERNO(ap_MATERNO);
            empleado.SETNOMBRE(noMBRE);
            empleado.SETTELEFONO(telefono);
            empleado.SETDIRECCION(diRECCION);
            empleado.SETESTADO_CIVIL(estadocivil);
            empleado.SETFECHA_NACIMIENTO(fecha);
            empleado.getID_CARGO().setIDcargo(idcargo);
            empleado.insertar();

            //___MANEJO DE LLAVE FORANEA_________

        }

        /*
ID_EMPLEADO VARCHAR (10) NOT NULL,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
TELEFONO INT,
DIRECCION VARCHAR (50),
ESTADO_CIVIL VARCHAR (10),
FECHA_NACIMIENTO DATE,
ID_CARGO VARCHAR (10) NOT NULL,         
 */

        public void modificar(string id_empleado, string ap_PATERNO, string ap_MATERNO, string noMBRE, int telefono,String diRECCION,
            string estadocivil, DateTime fecha,String idcargo)
        {
          
            empleado.SETID_EMPLEADO(id_empleado);
            empleado.SETAP_PATERNO( ap_PATERNO);
            empleado.SETAP_MATERNO(ap_MATERNO);
            empleado.SETNOMBRE(noMBRE);
            empleado.SETTELEFONO(telefono);
            empleado.SETDIRECCION(diRECCION);
            empleado.SETESTADO_CIVIL(estadocivil);
            empleado.SETFECHA_NACIMIENTO(fecha);
            empleado.getID_CARGO().setIDcargo(idcargo);
            empleado.modificar();

           //___MANEJO DE LLAVE FORANEA_________
           
        }
        public void eliminar(String id)
        {
            empleado.SETID_EMPLEADO(id);

            empleado.eliminar();
        }
        public void buscar(String ID)
        {
            empleado.SETID_EMPLEADO(ID);
            empleado.buscar();

        }

        public DataTable MOSTRAR()
        {
            return empleado.mostrarEMPLEADO();
        }
    }
}
