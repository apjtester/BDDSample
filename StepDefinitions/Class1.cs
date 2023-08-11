using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSample.StepDefinitions
{
    [Binding]
    internal class Class1
    {
        [Given(@"Open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("OpenChrome********************");
        }

        [Given(@"Open Firefox")]
        public void GivenOpenFirefox()
        {
            Console.WriteLine("OpenFireFox********************");
        }


        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine(" Given B is clicked");
             }

        /*[When(@"I click on '([^']*)'")]
        public void WhenClicked(string buttonName)
        {
            Console.WriteLine("Clicked on {0}", buttonName);
        }*/

        [When(@"I click on '([^']*)'")]
        public void WhenIClickOn(string submit)
        {
            Console.WriteLine("This is SUBMIT");
        }

        [When(@"E")]
        public void WhenE()
        {
            Console.WriteLine("This is EE");
        }


        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("When C happens");
             }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("D should happen");
            }

    }
}
