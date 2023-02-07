using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string[,] authors = { { "Лев Толстой", "Уильям Шекспир", "Джеймс Джойс" },
                { "Владимир Набоков", "Фёдор Достоевский", "Уильям Фолкнер" },
                { "Чарльз Диккенс", "Антон Чехов", "Гюстав Флобер" } };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Весь список авторів\n");
                for (int i = 0; i < authors.GetLength(0); i++)
                {
                    for(int j = 0; j < authors.GetLength(1); j++)
                    {
                        Console.Write(authors[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Бiблiотека");
                Console.WriteLine("\n1. Знайти ім'я автора по індексу книги.\n\n2. Знайти книгу по автору.\n\n3. Вхід.");
                Console.Write("\nВиберіть пункт меню: ");
                //Console.ReadKey();

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            int col, rows;
                            Console.Write("Ведіть номер колонки: ");
                            col = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.Write("Ведіть номер рядка: ");
                            rows = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Цей автор: " + authors[col,rows]);
                            break;
                        }
                    case 2:
                        {
                            bool authotIsFound = false;
                            string nameAuthor;
                            Console.Write("Iм'я автора: ");
                            nameAuthor = Console.ReadLine();
                            for(int i = 0; i < authors.GetLength(0); i++)
                            {
                                for(int j = 0; j < authors.GetLength(1); j++)
                                {
                                    if(nameAuthor.ToLower() == authors[i, j].ToLower())
                                    {
                                        Console.WriteLine($"Автор {authors[i,j]} находиться по індексу {i + 1}, {j + 1}");
                                        authotIsFound = true;
                                    }
                                }
                            }
                            if(authotIsFound == false)
                            {
                                Console.WriteLine("Такого автора немає.");
                            }
                            break;
                        }
                    case 3:
                        {
                            isOpen = false;
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Введена невірна команда.");
                            break;
                        }
                }
            }
        }
    }
}
