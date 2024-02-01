using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Threading;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("-------------");
            Start();

        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);


            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------");
            Console.WriteLine(" Deseja salvar o aruivo ? S/N");
            string option = Console.ReadLine();
            switch (option)
            {
                case "S":
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o caminho do arquivo:");
                        string path = Console.ReadLine();
                        using (StreamWriter Writer = new StreamWriter(path))
                        {
                            Writer.WriteLine(file.ToString());
                            Console.WriteLine("salvo com sucesso 🎇");
                        }
                        Thread.Sleep(2000);
                        Viewer.Show(file.ToString()); break;
                    }
                case "N": Viewer.Show(file.ToString()); break;
                default: Console.WriteLine("Nada a ser salvo"); break;
            }

            Viewer.Show(file.ToString());
        }
    }
}