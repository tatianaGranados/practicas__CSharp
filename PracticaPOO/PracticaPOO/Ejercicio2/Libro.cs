using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Libro
    {
       
        
        public Libro(){
        }

        public Libro(string tituloLibro, string autor, int nroEjemplaresLibro, int nroEjemplaresPrestados)
        {
            TituloLibro = tituloLibro;
            Autor = autor;
            NroEjemplaresLibro = nroEjemplaresLibro;
            NroEjemplaresPrestados = nroEjemplaresPrestados;
        }

        public bool Prestamo()
        {
            bool prestado = true;
            if (NroEjemplaresPrestados < NroEjemplaresLibro)
            {
                NroEjemplaresPrestados++;
            }
            else
            {
                prestado = false;
            }
            return prestado;
        }

        public bool Devolucion()
        {
            bool devuelto = true;
            if (NroEjemplaresPrestados==0)
            {
                devuelto = false;
            }
            else
            {
                NroEjemplaresPrestados--;
            }
            return devuelto;
        }

        public  string ToString()
        {

        }

        public string TituloLibro{ get; set; }
        public string Autor { get; set; }
        public int NroEjemplaresLibro { get; set; }
        public int NroEjemplaresPrestados { get; set; }

        
    }
}
