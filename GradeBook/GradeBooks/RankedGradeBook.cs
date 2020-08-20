﻿using System;
using System.Collections.Generic;
using System.Text;

 namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) 
        {
            if(Students.Count < 5)
            {
                return base.GetLetterGrade(averageGrade);
            }
            else
            {
                return 'F';
            }
        }
    }
}
