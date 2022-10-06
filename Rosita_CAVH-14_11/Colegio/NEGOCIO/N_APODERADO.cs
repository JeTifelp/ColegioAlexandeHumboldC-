using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data;

namespace Colegio.NEGOCIO
{
    class N_APODERADO
    {
        private APODERADO apoderado = new APODERADO();

        public void insertar(int CI_Ap,String ap_Paterno,String ap_Materno,String nombre,
                            String ocupacion,String Mayor_Grado,String Profesion,
                        String EmpresaT,int Telefono,String parentezco,String Dir_Domicilio,String Dir_Oficina)
        {
            apoderado.setCI_Apoderado(CI_Ap);
            apoderado.setApPAternoo(ap_Paterno);
            apoderado.setApMAternoo(ap_Materno);
            apoderado.setNombre(nombre);
            apoderado.setOcupacion(ocupacion);
            apoderado.setMAyorGradoDeInstruccion(Mayor_Grado);
            apoderado.setProfesion(Profesion);
            apoderado.setEmpresaTrabajo(EmpresaT);
            apoderado.setTelefono(Telefono);
            apoderado.setParentezco(parentezco);
            apoderado.setDirDomicilio(Dir_Domicilio);
            apoderado.setDirOfic(Dir_Oficina);

            apoderado.insertar();
        }
        /*// <summary>
        /// private String   ID_APODERADO;
        private int CI_APODERADO;
        private String AP_PATERNO;
        private String AP_MATERNO;
        private String NOMBRE;
        private String OCUPACION;
        private String MAYOR_GRADO_INSTRUCCION;
        private String PROFESION;
        private String EMPRESA_TRABAJO;
        private int TELEFONO;
        private String PARENTESCO;
        private String DIRECCION_DOMICILIO;
        private String DIRECCION_OFICINA;
        /// </summary>
        //*/ 
     

      

        public void modificar(int CI_Ap,String ap_Paterno,String ap_Materno,String nombre,String ocupacion,
                            String Mayor_Grado,String Profesion,String EmpresaT,int Telefono,String parentezco,
                            String Dir_Domicilio,String Dir_Oficina)
        {
            apoderado.setCI_Apoderado(CI_Ap);
            apoderado.setApPAternoo(ap_Paterno);
            apoderado.setApMAternoo(ap_Materno);
            apoderado.setNombre(nombre);
            apoderado.setOcupacion(ocupacion);
            apoderado.setMAyorGradoDeInstruccion(Mayor_Grado);
            apoderado.setProfesion(Profesion);
            apoderado.setEmpresaTrabajo(EmpresaT);
            apoderado.setTelefono(Telefono);
            apoderado.setParentezco(parentezco);
            apoderado.setDirDomicilio(Dir_Domicilio);
            apoderado.setDirOfic(Dir_Oficina);
            apoderado.modificar();
        }

        public void eliminar(String id_Apoderado)
        {
            apoderado.setID_Apoderado(id_Apoderado);
            apoderado.eliminar();
        }

        public void buscar(String ID_Ap)
        {
            apoderado.setID_Apoderado(ID_Ap);
            apoderado.buscar();
        }

        public DataTable MOSTRAR()
        {
            return apoderado.mostrar();
        }
    }
}
