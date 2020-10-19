/*Class Name: InputState.cs
 * Author: Kristina VanderBoog
 *Purpose: This represents the Concrete State (InputState) that initiates user input 
             into the form.  Once it is completed it will initiate a done state RUN()
  Date: August 14, 2020
*/

using System;
using System.Collections.Generic;


namespace Project_3_Starter
{
    public class InputState : State
    {
        public InputState(FormInput f) : base(f) { }

        /*This method initiates user input and calls on validators to validate it
         it returns nothing, but passes a completed form to the done state*/
        public override void Run()
        {

            FormInput uInput = this.form;
            Console.WriteLine("Welcome to the Form.");
            Console.WriteLine();
            Console.WriteLine();
            Form uForm = uInput.getForm();
            List<IFormComponent> newList = uForm.GetComponent();
            
                Console.WriteLine(newList[0].GetName());
                 string uName = Console.ReadLine();
                 newList[0].SetValue(uName);
                if(!newList[0].IsValid())
            {
                while (!newList[0].IsValid())
                {
                    Console.WriteLine("Entry is invalid, please try again");
                    Console.WriteLine(newList[0].GetName());
                    uName = Console.ReadLine();
                    newList[0].SetValue(uName);
                }
            }
            
                Console.WriteLine(newList[1].GetName());
                string uEmail = Console.ReadLine();
                newList[1].SetValue(uEmail);
            if (!newList[1].IsValid())
            {
                while (!newList[1].IsValid())
                {
                    Console.WriteLine("Invalid email type.  Please include '@' and '.' ");
                    Console.WriteLine(newList[1].GetName());
                    uEmail = Console.ReadLine();
                    newList[1].SetValue(uEmail);
                }
            }
            Console.WriteLine(newList[2].GetName());
            string uRealName = Console.ReadLine();
            newList[2].SetValue(uRealName);
            if(!newList[2].IsValid())
            {
                while(!newList[2].IsValid())
                {
                    Console.WriteLine("The minimum length for a name is 6, please try again ");
                    Console.WriteLine(newList[2].GetName());
                    uRealName = Console.ReadLine();
                    newList[2].SetValue(uRealName);
                }
            }
            Console.WriteLine(newList[3].GetName());
            string uPass = Console.ReadLine();
            newList[3].SetValue(uPass);
            if(!newList[3].IsValid())
            {
                while(!newList[3].IsValid())
                {
                    Console.WriteLine("Invalid password format, please inclide symbol '!' and 8 characters ");
                    Console.WriteLine(newList[3].GetName());
                    uPass = Console.ReadLine();
                    newList[3].SetValue(uPass);
                }
            }
            Console.WriteLine(newList[4].GetName());
            string uPass2 = Console.ReadLine();
            newList[4].SetValue(uPass2);
            if(!newList[4].IsValid())
            {
                while(!newList[4].IsValid())
                {
                    Console.WriteLine("Passwords do not match, please try again");
                    Console.WriteLine(newList[4].GetName() );
                    uPass2 = Console.ReadLine();
                    newList[4].SetValue(uPass2);
                }
            }
            Console.WriteLine(newList[5].GetName());
            string age = Console.ReadLine();
            newList[5].SetValue(age);
            if(!newList[5].IsValid())
            {
                while(!newList[5].IsValid())
                {
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine(newList[5].GetName());
                    age = Console.ReadLine();
                    newList[5].SetValue(age);
                }
            }

            Console.WriteLine("Your form is complete, press 1 to exit or 2 to print to screen: ");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                System.Environment.Exit(1);
            }
            else if(choice == "2")
            {
                uInput.ChangeState(new DoneState(uInput));
            }
            else
            {
                Console.WriteLine("Please select either 1 or 2");
            }

        }
    }
}
