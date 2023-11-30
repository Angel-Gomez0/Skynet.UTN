using System;

namespace Logica.entidades
{
    public class Mapa
    {
        private int[,] terreno;

        public Mapa(int filas, int columnas)
        {
            terreno = new int[filas, columnas];
            var random = new Random();

            for (int i = 0; i < filas; i += 10)
            {
                for (int j = 0; j < columnas; j += 10)
                {
                    int tipoLocalizacion = random.Next(0, 9);

                    for (int k = i; k < i + 10; k++)
                    {
                        for (int l = j; l < j + 10; l++)
                        {
                            terreno[k, l] = tipoLocalizacion;
                        }
                    }
                }
            }
        }

        public void CrearMapa(int filas, int columnas, int randy)
        {
            for (int k = i; k < i + 10; k++)
            {
                for (int l = j; l < j + 10; l++)
                {
                    terreno[k, l] = randy;
                }
            }
        }

        public void MostrarMapa()
        {
            for (int i = 0; i < terreno.GetLength(0); i++)
            {
                for (int j = 0; j < terreno.GetLength(1); j++)
                {
                    Console.Write((int)terreno[i, j] + " ");
                }
                Console.WriteLine();
            }
        }




        /*private List<ElementoMapa>[,] elementosMapa;

        public Mapa(int filas, int columnas)
        {
            elementosMapa = new List<ElementoMapa>[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    elementosMapa[i, j] = new List<ElementoMapa>();
                }
            }
        }

        public void MostrarMapa()
        {
            Console.WriteLine("  +-------------------------------------------+");
            for (int i = 0; i < elementosMapa.GetLength(0); i++)
            {
                Console.Write("  |");
                for (int j = 0; j < elementosMapa.GetLength(1); j++)
                {
                    if (elementosMapa[i, j].Count > 0)
                    {
                        foreach (ElementoMapa elemento in elementosMapa[i, j])
                        {
                            Console.Write($" {elemento.Nombre.PadRight(7)} ");
                        }
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("         |");
                    }
                }
                Console.WriteLine("\n  +-------------------------------------------+");
            }
        }

        public void AgregarElemento(ElementoMapa elemento, int fila, int columna)
        {
            elementosMapa[fila, columna].Add(elemento);
            elemento.Fila = fila;
            elemento.Columna = columna;
        }

        public void MoverElemento(ElementoMapa elemento, int nuevaFila, int nuevaColumna)
        {
            elementosMapa[elemento.Fila, elemento.Columna].Remove(elemento);
            elementosMapa[nuevaFila, nuevaColumna].Add(elemento);

            elemento.Fila = nuevaFila;
            elemento.Columna = nuevaColumna;
        }*/
    }
}
