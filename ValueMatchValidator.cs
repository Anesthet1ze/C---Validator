/* Class Name: ValueMatchValidator.cs
 * Author: Kristina VanderBoog
 * Purpose: This is a concrete decorator, it will set the validation rules that will be wrapped (applied) around a 
             textbox object for use with user validation
 * Date: August 14,2020
 */

namespace Project_3_Starter
{
    public class ValueMatchValidator : Validator
    {
        IFormComponent vPass;
        public ValueMatchValidator(IFormComponent valValid, IFormComponent password) : base(valValid)
        {
            vPass = password;
        }

        /*Returns the name of the textbox name variable */
        public override string GetName()
        {
            return validated.GetName();
        }
        /*Returns the value of the textbox value variable
         for use with determining whether a set value is valid*/
        public override string GetValue()
        {
            return validated.GetValue();
        }

        /*Will test incoming user input against a requirement it must meet in order to be valid
          This will return true if the current value in the password variable matches the user input
           in order to ensure that the passwords entered match*/
        public override bool IsValid()
           
        {
            if (validated.GetValue() == vPass.GetValue())
            {
              return validated.IsValid();
            }
            return false;
        }

        /*This sets a value and returns true if it was successful based on the isvalid*/
        public override bool SetValue(string value)
        {
           return validated.SetValue(value);
        }
    }
}