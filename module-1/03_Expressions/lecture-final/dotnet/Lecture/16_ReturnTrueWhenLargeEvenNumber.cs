﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            string result = ""; 

            bool isBig = number > 100;
            bool isEven = number % 2 == 0;
            bool isMultOfFive = number % 5 == 0; 

            if (isBig)
            {
                if (isEven && isMultOfFive)
                {
                    result = "Big Even Number";
                }
                else
                {
                    result = "Big Number";
                }
            }
            return result;

        }
        


    }
}
