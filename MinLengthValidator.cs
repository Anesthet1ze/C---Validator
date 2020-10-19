/* Class Name: MinLengthValidator.cs
 * Author: Kristina VanderBoog
  Purpose: Concrete decorator used to validate minimum length of user input
  Date: August 14, 2020
*/

namespace Project_3_Starter
{
    public class MinLengthValidator : Validator
    {
        private int nParam;
        public MinLengthValidator(IFormComponent minValid, int n) : base(minValid)
        {
            nParam = n;
        }

        public override string GetName()
        {
            return validated.GetName();
        }

        public override string GetValue()
        {
            return validated.GetValue();
        }

        /*Takes the user inputted value and compares it to the validating nParam set in main
         Returns true if the input meets the minimum length*/
        public override bool IsValid()
        {
            if(validated.GetValue().Length >= nParam)
            {
                return validated.IsValid();
            }
            return false;
        }

        public override bool SetValue(string value)
        {
            return validated.SetValue(value); 
        }
    }
}