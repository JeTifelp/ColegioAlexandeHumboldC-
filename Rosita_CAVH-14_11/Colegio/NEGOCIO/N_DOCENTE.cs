using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_DOCENTE
    {

        private DOCENTE docente = new DOCENTE();

        public void insertar( String id_doc, String ap_Paterno,String ap_Materno,String nombre,
                Int32 Horas_Trabajo,String tele, String direccion,DateTime Fecha_NAc)
        {
            docente.setApPater(ap_Paterno);
            docente.setApMaterno(ap_Materno);
            docente.setNombre(nombre);            
                   
            docente.setHorasT(Horas_Trabajo);
            docente.setTELEFONO(tele);

            docente.setIDDoc(id_doc);
            docente.setDireccion(direccion);
            docente.setFechaNac(Fecha_NAc);
            docente.insertar();
        }
        /// <summary>
        /*
ID_DOCENTE VARCHAR (10) NOT NULL,
         * 
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
HORAS_TRABAJO INT ,
TELEFONO INT,
DIRECCION VARCHAR (50),
FECHA_NACIMIENTO DATE,
PRIMARY KEY (ID_DOCENTE)
         */
        /// </summary>
        /// <param name="id_gestion"></param>
        /// <param name="descri"></param>
        /// <param name="fechaini"></param>
        /// <param name="fechafi"></param>

        public void modificar(String ap_Paterno,String ap_Materno,String nombre
            ,String direccion,String estado,DateTime Fecha_NAc,Int32 Horas_Trabajo,
            String ID_Doc,String Telef)
        {
            docente.setApPater(ap_Paterno);
            docente.setApMaterno(ap_Materno);
            docente.setNombre(nombre);            
                   
            docente.setHorasT(Horas_Trabajo);
            docente.setTELEFONO(Telef);

            docente.setIDDoc(ID_Doc);
            docente.setDireccion(direccion);
            docente.setFechaNac(Fecha_NAc);
            docente.modificar();
        
        }

        public void eliminar(String id_docen)
        {
            docente.setIDDoc(id_docen);
            docente.eliminar();
        }

        public void buscar(String IDDoc)
        {
            docente.setIDDoc(IDDoc);
            docente.buscar();
        }

        public DataTable MOSTRAR()
        {
            return docente.mostrar();
        }

    }
}
