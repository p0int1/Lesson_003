using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class BadPupil : Pupil 
    {
        public override void Study()
        {
            Console.WriteLine("Ученик плохо учится");
        }
        public override void Read()
        {
            Console.WriteLine("Ученик плохо читает");
        }
        public override void Write()
        {
            Console.WriteLine("Ученик плохо пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Ученик отдыхает лучше всех");
        }
    }
}
