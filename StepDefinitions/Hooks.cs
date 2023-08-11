using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSample.StepDefinitions
{
    [Binding]
    internal class Hooks
    {


        [BeforeScenario("CategoryA")]
        public void BeforeSceneAHook()
        {
            Console.WriteLine("Category A Scene Hook AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        [BeforeScenario("CategoryB")]
        public void BeforeSceneBHook()
        {
            Console.WriteLine("Category B Scene HookBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
        }

        //Below given are hooks, which will be run at the specified time

        //This hook will run before every feature
        [BeforeFeature]
        public static void BeforeHook()
        {

            Console.WriteLine("Befor Feature Scene Hook????????????????????????????????????");
        }

        [BeforeScenario]
        public  void Before2Hook()
        {

            Console.WriteLine("Befor Scenario2  Hook????????????????????????????????????");
        }


        [AfterFeature]
        public static void AfterHook()
        {

            Console.WriteLine("After Feature Scene Hook???????????????????????????????????????????????");
        }

        [BeforeScenario]
        public void BeforeSceneHook()
        {

            Console.WriteLine("Before Scene Hook\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        }

        [AfterScenario]
        public void AfterSceneHook()
        {

            Console.WriteLine(" After Scene Hook///////////////////////////////////////////////////////////");
        }

    }


}
