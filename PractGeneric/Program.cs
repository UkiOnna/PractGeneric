﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            string poem = @"Вот дом
Который построил Джек
А это пшеница
Которая в тёмном чулане хранится
В доме
Который построил Джек
А это весёлая птица-синица
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
Вот кот
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
Вот пёс без хвоста
Который за шиворот треплет кота
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
А это корова безрогая
Лягнувшая старого пса без хвоста
Который за шиворот треплет кота
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
А это старушка, седая и строгая
Которая доит корову безрогую
Лягнувшую старого пса без хвоста
Который за шиворот треплет кота
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
А это ленивый и толстый пастух
Который бранится с коровницей строгою
Которая доит корову безрогую
Лягнувшую старого пса без хвоста
Который за шиворот треплет кота
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек
Вот два петуха
Которые будят того пастуха
Который бранится с коровницей строгою
Которая доит корову безрогую
Лягнувшую старого пса без хвоста
Который за шиворот треплет кота
Который пугает и ловит синицу
Которая часто ворует пшеницу
Которая в тёмном чулане хранится
В доме
Который построил Джек";
            int a = 0;
            int counter = 0;
            int again;
            bool isAgain;
            StringBuilder word = new StringBuilder();
            List<string> words = new List<string>();
           // List<char> symbols = new List<char>();
            Dictionary  <int,string> dictionary= new Dictionary<int, string>();
            //poem = poem.Replace("\n", string.Empty);
            for(int i = 0; i < poem.Length; i++)
            {
                if (poem[i] == ' '||poem[i]=='\n')
                {
                    dictionary.Add(++counter, word.ToString());
                    word.Clear();
                }
                else
                {
                    word.Append(poem[i]);
                }
            }

            //for(int i = 1; i < counter; i++)
            // {
            //string or = dictionary[i];
            int co = 1;
                foreach (string s in dictionary.Values)
            {
                Console.Write("{0}   ", co);
                Console.WriteLine(s);
                co++;
            }
           
            
           
            
                
        
            Console.ReadLine();
            
        }
    }
}
