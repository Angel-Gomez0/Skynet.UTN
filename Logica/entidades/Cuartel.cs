﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.entidades
{
   
    using System;
    using System.Collections.Generic;

    namespace Logica.entidades
    {
        public class Cuartel : ElementoMapa, ITransferirCarga<Operador>
        {
            private static int contadorId = 0;

            public HashSet<Operador> ListaOperadores = new HashSet<Operador>();

            public int Id { get; private set; }

            //      public List<Carga> cargasEnCuartel { get; private set; } = new List<Carga>();
            public HashSet<Carga> Cargas { get; private set; } = new HashSet<Carga>();

            public Cuartel(int fila, int columna) : base("Cuartel", fila, columna)
            {
                Id = contadorId;
                contadorId++;
            }

            public void AgregarElemento(Operador operador)
            {
                ListaOperadores.Add(operador);
                operador.Fila = this.Fila;
                operador.Columna = this.Columna;
            }

            public void MostrarElementosEnCuartel()
            {
                foreach (Operador elemento in ListaOperadores)
                {
                    Console.WriteLine($"Elemento: {elemento.Nombre} en ({elemento.Fila}, {elemento.Columna}) idElemento {elemento.Id}");
                }
            }

            public void TransferirCarga(Operador operadorDestino, Carga carga)
            {
                try
                {
                    ContieneCarga(carga);
                    operadorDestino.AgregarCarga(carga);
                    SacarCarga(carga);
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
             
            }

            private void SacarCarga(Carga carga)
            {
                Cargas.Remove(carga);
            }
            private bool ContieneCarga(Carga carga)
            {
                return this.Cargas.Contains(carga) ? true : throw new Exception("No posee la carga que quiere transferir ");
            }
           public void ListarEstadoDeOperadores()
            {
                foreach(var operador in  ListaOperadores)
                {
                    Console.WriteLine($"Operador id: {operador.Id}, estado {operador.Estado}");

                }
            }
            public void ListarEstadoDeOperadoresEnLocalizacion(ElementoMapa elemento)
            {
                Console.WriteLine($"LocalDataStoreSlot que esten en esta ubicacion Fila{elemento.Fila}, columna{elemento.Columna} ");
                foreach (var operador in ListaOperadores)
                {
                    if (operador.MismaUbicacion(elemento))
                    {
                      
                        Console.WriteLine($"Operador id: {operador.Id}, estado {operador.Estado}");
                    }
                  

                }
            }
          
        }
    }
}

