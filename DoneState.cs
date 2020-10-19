//Class Name: DoneState.cs
//Author: Kristina VanderBoog
//Purpose: This represents the concrete state of "DoneState" it will initiate the printing 
//of the information entered in the form. I could not get the chevron to line up properly so I omitted it.
//Date: August 14, 2020

using System;
using System.Collections.Generic;

namespace Project_3_Starter
{
    public class DoneState : State
    {

        public DoneState(FormInput f) : base(f) { }

        /*This Run method will have a loop that prints out all the user inputed information
         * it returns nothing, and prints only*/
        public override void Run()
        {
            Console.WriteLine("Here is your printout  ");
            FormInput PrintForm = this.form;
            Form uForm = PrintForm.getForm();
            List<IFormComponent> PrintList = uForm.GetComponent();
            for (int i = 0; i < PrintList.Count; i++)
            {
                string formatter = String.Format("{0,20} {1,20}", PrintList[i].GetName(), PrintList[i].GetValue());
                Console.WriteLine($"{formatter}");
            }

        }
    }
}
