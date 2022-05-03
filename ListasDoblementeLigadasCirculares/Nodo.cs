using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo Ant { get; set; }
        public Nodo Sig { get; set; }   
        public Nodo(string valor = "", Nodo ant = null, Nodo sig = null)
        {
            Valor = valor;
            Ant = ant;
            Sig = sig;

        }
    }
}