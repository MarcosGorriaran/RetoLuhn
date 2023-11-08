/*
 * Programa: Reto Mod 10 Luhn
 * Fecha de actualizacion: 8/11/2023
 * Autor: Marcos Gorriaran
 */
using System;

namespace RetoLahn
{
    class Execute
    {
        public static void Main()
        {
            const int BigSpliter = 100;
            const int Spliter = 10;
            const int CharToArray = 48;
            const int MinLength = 1;
            const int Div = 2;
            const float EndOfLoop = 0.1f;
            const string AskCode = "Proporcioname el codigo para validarlo: ";

            int[] splitedCode;
            int invertedCount;
            int aux;
            int sum=0;
            float thirdAux;
            char[] temp;
            string insertedCode;


            Console.Write(AskCode);
            insertedCode = Console.ReadLine();

            if (insertedCode.Length / Div > MinLength)
            {
                splitedCode = new int[insertedCode.Length / Div];
                temp = insertedCode.ToCharArray();
                for (int i = insertedCode.Length-Div; i >= 0; i-=Div)
                {
                    aux = (((int)temp[i]));//*Div;
                    if(aux >= Spliter)
                    {
                        aux = ((aux / Spliter)%MinLength)*Spliter;
                        aux += MinLength;
                    }
                    sum += aux;
                }
            }
        }
    }
}