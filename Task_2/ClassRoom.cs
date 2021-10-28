using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pup1, Pupil pup2)
        {
            pupils[0] = pup1;
            pupils[1] = pup2;
            pupils[2] = new Pupil();
            pupils[3] = new Pupil();
        }

        public ClassRoom(Pupil pup1, Pupil pup2, Pupil pup3)
        {
            pupils[0] = pup1;
            pupils[1] = pup2;
            pupils[2] = pup3;
            pupils[3] = new Pupil();
        }
        public ClassRoom(Pupil pup1, Pupil pup2, Pupil pup3, Pupil pup4)
        {
            pupils[0] = pup1;
            pupils[1] = pup2;
            pupils[2] = pup3;
            pupils[3] = pup4;
        }

        public void Study()
        {
            foreach (Pupil pup in pupils)
                pup.Study();
            Console.WriteLine("----------");
        }

        public void Read()
        {
            foreach (Pupil pup in pupils)
                pup.Read();
            Console.WriteLine("----------");
        }

        public void Write()
        {
            foreach (Pupil pup in pupils)
                pup.Write();
            Console.WriteLine("----------");
        }

        public void Relax()
        {
            foreach (Pupil pup in pupils)
                pup.Relax();
            Console.WriteLine("----------");
        }

    }
}
