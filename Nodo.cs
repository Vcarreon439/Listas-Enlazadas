using System;


namespace Listas_Enlazadas
{
    class Nodo
    {
        //Añadir la clase Nodo

        //Atributo que almacena el valor del nodo
        public Object Dato; 

        /*Clase autorefenciada, atributo que indica en que 
        localidad de memoria esta el sigueinte nodo*/
        public Nodo SiguienteNodo; 

        public Nodo(Object dato) 
        {
            Dato = dato;
        }

        public Nodo()
        {

        }
    }
}


