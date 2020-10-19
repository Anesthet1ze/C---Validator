//Class Name: Textbox.cs
//Author: Kristina VanderBoog
//Purpose: This is the Concrete component of the Decorator pattern, it can have concrete decorators
//         stacked for the purpose of validating it's user inputted data
//Date: Aug. 14, 2020


namespace Project_3_Starter
{
    public class Textbox : IFormComponent
    {

        private string name;
        private string value;

        public Textbox(string v)
        {
            this.name = v; //this works, name = username
        }

        /*This method returns the name set in main*/
        public string GetName()
        {
            return this.name;
        }

        /*the value member is populated by user input, this returns that input*/
        public string GetValue()
        {
            return this.value;
        }

        public bool IsValid()
        {
            return true;
        }

        /*sets the current value variable to the user input variable and returns true on success*/
        public bool SetValue(string value)
        {
            this.value = value;
            return true;
        }
    }
}