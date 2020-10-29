using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas
{
    class ListaE
    {
        public Nodo cabeza;
        public Nodo aux;
        public Nodo final;

        public ListaE()
        {
            cabeza = null;
        }

        public void InsertarALaCabeza(Object dato)
        {
            //Se crea el nodo
            Nodo NuevoNodo = new Nodo(dato);
            //Se establece la sigueinte referencia
            NuevoNodo.SiguienteNodo = cabeza;
            cabeza = NuevoNodo;
        }

        public void InsertarAlFinal(Object dato)
        {
            //Se verifica que haya elementos en la lista
            if (cabeza==null)
            {
                //De no haberlos crea el primer elemento
                InsertarALaCabeza(dato);
            }
            else
            {
                //Variable final como variable temporal
                final = cabeza;
                //Cabeza = nuevo nodo
                cabeza = new Nodo(dato);
                //Se reestablecen los apuntadores con la variable final
                cabeza.SiguienteNodo = final;

                #region Comentario
                /*
                 * En este caso realmente se puede pasar por alto la variable final,
                 * ya que podemos hacer uso de la variable auxiliar para poder
                 * "reestablecer" el orden de la lista
                */
                #endregion
            }
        }

        public void Mostrar()
        {
            aux = cabeza;

            //Ciclo para imprimir hasta que el sig apuntador sea null
            while (aux != null)
            {
                Console.Write(aux.Dato.ToString() + "=>");
                //Se cambia auxiliar por el apuntador del siguiente
                aux = aux.SiguienteNodo;
            }
            //Imprimir null en caso de que el apuntador sea null
            if (aux == null)
            {
                Console.Write("null");
            }
            Console.WriteLine();
        }

        public int ContarElementos()
        {
            aux = cabeza;
            int contador = 0;

            while (aux != null)
            {
                aux = aux.SiguienteNodo;
                contador-=-1;
            }
            Console.WriteLine("Hay {0} elementos en la lista", contador);

            return contador;
        }
    }
}
