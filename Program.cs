using System.Net.Mime;
using System.Collections.Generic;
using System;
using System.Collections;
namespace PalabraRepetida_1_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            string text = Normalize("Hola, me me me llamo Johan; un placer!");
            string[] value = text.Split(" ");

            foreach (var item in value)
            {
                if(table.ContainsKey(item))
                {
                    int valor = (int)table[item];
                    table[item] = valor + 1;
                }else
                {
                    table.Add(item, 1);
                }
            }

            ICollection keys = table.Keys;

            foreach (var item in keys)
            {
                System.Console.Write($"{item}: {table[item]}\n");
            }
        }

        public static string Normalize(string text)
        {
            text = text.ToLower().Replace(",", "").Replace(";","").Replace("!","").Replace("¿","").Replace("?","");
            return text;
        }
    }
}
