using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * LINQ: (Language Integrated Query) ou (Consulta Integrada a Linguagem)
            - É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#
                - Operações chamadas diretamente a partir das coleções
                - Consultas são objetos de primeira classe (Conceito de programação funcional)
                - Suporte do compilador e IntelliSense da IDE
            - Namespace: System.Linq
            - Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxe similar á SQL
            
            * TRÊS PASSOS:
            - Criar um data source (coleção, array, recurso de E/S, etc.)
            - Definir a query
            - Executar a query (foreach ou alguma operação terminal)
             
            */

            //1o Passo: Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 }; //podendo ser qualquer coleção ou banco de dados e etc...

            //2o Passo: Definir a expressão de consulta
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10); //Usando uma função extensão do Linq (.Where) para testar a expresão lambda e ver quais são os numeros pares do vetor numbers e depois utilizamos o .Select para multiplicar esse resultado por 10

            //3o Passo: Executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
