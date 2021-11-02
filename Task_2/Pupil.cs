﻿using System;

namespace Task_2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Ученик учится");
        }
        public virtual void Read()
        {
            Console.WriteLine("Ученик читает");
        }
        public virtual void Write()
        {
            Console.WriteLine("Ученик пишет");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Ученик отдыхает");
        }
    }
}
