/*Class Name: CharacterValidator.cs
 * Author: Kristina VanderBoog
  Purpose: Concrete Decorator used to validate specific characters of user input against constructed
           validation requirements
  Date: August 14, 2020
*/


namespace Project_3_Starter
{
    public class CharacterValidator : Validator
    {
        private string vParam;
        //TODO fix naming convention to be more obvious
        public CharacterValidator(IFormComponent charValid, string c) : base(charValid)
        {
            vParam = c;
        }

        public override string GetName()
        {
            return validated.GetName();
        }

        public override string GetValue()
        {
            return validated.GetValue();
        }

        /*This takes the user input and validates it against a value set in the main.  It looks
         to search for present characters in the input, if they are present, it returns true*/
        public override bool IsValid()
        {
            if (validated.GetValue().Contains(vParam))
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