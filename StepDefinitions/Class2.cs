/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSample.StepDefinitions
{
    [Binding]
    internal class Class2
    {
        // For Prerequisite for each and every scenario of each and every file
        *//*[Before]
        public void Setup()
        {
            Console.WriteLine("BEFORE HOOK: SETUP");
        }

        // for PostRequisite
        [After]
        public void TearDown()
        {
            Console.WriteLine("AFTER HOOK: TEARDOWN");
        }*//*
        [Given(@"Open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("OpenChrome IN CLASS 2********************");
        }
    }
}
*/