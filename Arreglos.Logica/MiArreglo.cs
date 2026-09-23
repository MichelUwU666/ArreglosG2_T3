using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        
        private int _tope;
        private int[] _arreglo;

        //Constructor

        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];//mayúsucala para controlar la propiedad y no se pueda modificar
            _tope = 0;
        }

        //Propiedades

        public int N { get; }//Quitamos setter para no cambiar tamaño después

        public bool EstaVacio => _tope == 0;
        public bool EstaLleno => _tope == N;

        //Métodos

        //Meetodo llenar con parametros
        public void llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();

            for(int i =0; i<N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }

            _tope = N;
        }

        //Metodo ordenar 
        public void Ordenar()
        {
            Ordenar(true);
        }


        //Metodo ordenar
        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope-1; i++)
            {
                for (int j = i+1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j]) 
                    {
                        cambiar(ref _arreglo[i], ref _arreglo[j]);
                    }

                    }

                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    
                }
            }
        }

        //Metodo cambiar
        public void cambiar(ref int a,ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        public override string ToString()
        {

            if (EstaVacio)
            {
                return "El arreglo está vacío";
            }

            string salida = string.Empty;

            int contador = 0;

            for (int i = 0; i < _tope; i++)
            {
                salida +=  $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    salida += "\n";
                }
            }



            return salida;
        }
    }
}
