using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib_03;

/*Вариант 28
Дана строка.Словом текста считается любая последовательность букв латинского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Сохранить в строке последовательность слов, удалив из нее повторные вхождения
слов.*/

namespace _3_2_28
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Stroka stroka = new Stroka();
            stroka.text = "Это пример текста текста Это пример текста пример";
            string[] myWords = stroka.SplitToWords();

            string newString = "";
            for (int i = 0; i < myWords.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < myWords.Length; j++)
                {
                    if (j == i)
                        break;
                    if (myWords[j] == myWords[i])
                        count++;                
                }
                if (count == 0)
                newString += myWords[i] + " ";
            }            
            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
