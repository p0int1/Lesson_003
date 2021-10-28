using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите лицензию: ");
            string lic = Console.ReadLine();
            DocumentWorker document;

            switch (lic)
            {
                case "7682":
                    Console.WriteLine("**** ProUser ****");
                    document = new ProDocumentWorker();
                    break;
                case "1628":
                    Console.WriteLine("**** ExpertUser ****");
                    document = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("**** Ключ неверен ****");
                    document = new DocumentWorker();
                    break;
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadKey();

        }
    }
}
