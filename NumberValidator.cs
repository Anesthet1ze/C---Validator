/* Class Name: NumberValidator.cs
 * Author: Kristina VanderBoog
  Purpose: This is a concrete decorator used to validate whether or not a string entry is a number
  Date: August 14, 2020
*/

using System;

namespace Project_3_Starter
{
    public class NumberValidator : Validator
    {   
        public NumberValidator(IFormComponent numValid) : base(numValid)
        {
            
        }
        /*retrieves the name of the textbox name variable*/
        public override string GetName()
        {
            return validated.GetName();
        }
        /*Retrieves the user inputted value*/
        public override string GetValue()
        {
            return validated.GetValue();
        }
        /*Takes the user inputted value and tries to parse it as an int, if it is successful
         it returns true, which in turn returns true on IsValid other wise it returns false*/
        public override bool IsValid()
        {
            int parseOut;
            if (Int32.TryParse(validated.GetValue(), out parseOut))
                {
                return validated.IsValid();
                
                }
            return false;            
        }
        /*Attempts to set the value on validated input, returns true if success*/
        public override bool SetValue(string value)
        {
           return validated.SetValue(value);
        }
    }
}