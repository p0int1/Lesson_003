﻿using System;

namespace Task_2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Ученик отлично учится");
        }
        public override void Read()
        {
            Console.WriteLine("Ученик отлично читает");
        }
        public override void Write()
        {
            Console.WriteLine("Ученик отлично пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Ученик отдыхает");
        }
    }
}
