using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colegio.DATOS;
using System.Data.SqlClient;
using System.Data;
namespace Colegio.NEGOCIO
{
    class N_PARALELOS
        //____________COMMPLETO__________________
    {
        PARALELOS paralelo = new PARALELOS();

        public void insertar(string id_paralelo, string descrip, int cuposllenos, int cupomax, String idcurso, string gest)
        {

            paralelo.setID_paralelo(id_paralelo);
            paralelo.setDESCRIPCION(descrip);
            paralelo.setCupos_llenos(cuposllenos);
            paralelo.setCupos_max(cupomax);
            paralelo.ID_curso().setID_Curso(idcurso);
            paralelo.setID_GESTION(gest);

            //___MANEJO DE LLAVE FORANEA_________
            paralelo.insertar();
        }
        public void modificar(string id_paralelo, string descrip, int cuposllenos, int cupomax,String idcurso, string gest)
        {
           
            paralelo.setID_paralelo(id_paralelo);
            paralelo.setDESCRIPCION(descrip);
            paralelo.setCupos_llenos(cuposllenos);
            paralelo.setCupos_max(cupomax);
            paralelo.ID_curso().setID_Curso(idcurso);
            paralelo.setID_GESTION(gest);

//___MANEJO DE LLAVE FORANEA_________
            paralelo.modificar();
        }
        public void eliminar(String id)
        {
            paralelo.setID_paralelo(id);

            paralelo.eliminar();
        }
        public void buscar(String id)
        {
            paralelo.setID_paralelo(id);

            paralelo.buscar();
        }
        /*
ID_PARALELO VARCHAR (10) NOT NULL,
DESCRIPCION VARCHAR (30),
CUPOS_LLENOS INT,
CUPO_MAX INT,
ID_CURSO VARCHAR (10) NOT NULL,
 */
        public DataTable MOSTRAR()
        {
            return paralelo.mostrarPARALELO();
        }



        //_______CONTROLA CUPO__ sin procedimiento almacenado
        public DataTable buscar_CUPO(PARALELOS Par)
        {

            return paralelo.Buscar_Cupo(Par);// PARALELOS.Buscar_Cupo(P);

        }
        //__________com procedimiento almacenado________
        public int contar_cuposPROcedure(String algo_de_paralelo) {
            return paralelo.ObtieneCupos_de_UNParalelos(algo_de_paralelo);
        }




    }
}
