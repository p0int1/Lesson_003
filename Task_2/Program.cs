using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            ClassRoom class_1 = new ClassRoom(new GoodPupil(), new BadPupil(), new BadPupil());

            class_1.Study();
            class_1.Read();
            class_1.Write();
            class_1.Relax();

            Console.ReadKey();
        }
    }
}
