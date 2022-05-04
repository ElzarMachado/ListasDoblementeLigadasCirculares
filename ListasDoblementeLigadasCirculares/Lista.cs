using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares

{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
            nodoInicial.Sig = nodoInicial;
            nodoInicial.Ant = nodoInicial;
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Sig == nodoInicial.Ant);
        }
        public void Vaciar()
        {
            nodoInicial.Sig = nodoInicial;
            nodoInicial.Ant = nodoInicial;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Sig != nodoInicial)
            {
                nodoActual = nodoActual.Sig;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Sig != nodoInicial)
            {
                nodoActual = nodoActual.Sig;
            }
            Nodo nodoNuevo = new Nodo(dato, nodoInicial);
            nodoActual.Sig = nodoNuevo;
            nodoInicial.Ant = nodoNuevo;

        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Sig != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Sig;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Sig != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Sig;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = nodoActual.Ant;
                    nodoAnterior.Sig = nodoActual.Sig;
                    nodoActual.Sig.Ant = nodoAnterior;
                    nodoActual.Sig = null;
                    nodoActual.Ant = null;
                    nodoActual.Valor = null;
                }
            }
        }





    }
}