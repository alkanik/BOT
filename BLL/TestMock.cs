﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Questions;

namespace BLL
{
    public class TestMock
    {
        public static Test GetTestMock()
        {
            Test testExample = new Test("TestExample")
            {
                questions = new List<AbstractQuestion>
                {
                    new OpenQuestion()
                    {
                        Name = "Who are you?"
                    },
                    new OpenQuestion()
                    {
                        Name = "Why are you writihg me?"
                    },
                    new YesOrNot()
                    {
                        Name = "Are you sure?"
                    },
                    new YesOrNot()
                    {
                        Name = "Are you really smart?"
                    },
                    new RadioButtonQuestion()
                    {
                        Name = "Ok. 2*2=?",
                        Options = new List<string>{"2","3","4","5"}
                    }
                }
            };

            return testExample;
        }
    }
}
