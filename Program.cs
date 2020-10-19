/*Author: Unknown: Project 3 starter Code
  Purpose:set textbox values and validation requirements for user input
  Date: August 14, 2020
*/

namespace Project_3_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a Form object            
            Form form = new Form();

            //2. Populate the Form's list with 6 hard-coded IFormComponent objects
            form.AddComponent(
                new MinLengthValidator(
                    new Textbox("Username"), 6));

           form.AddComponent(
                new CharacterValidator(
                    new CharacterValidator(
                        new Textbox("Email"), "@"),
                    "."));

            form.AddComponent(
                new MinLengthValidator(
                    new Textbox("Real Name"), 2));

            IFormComponent password = new CharacterValidator(
                new MinLengthValidator(
                    new Textbox("Password"), 8)
                , "!");
            form.AddComponent(password);

            form.AddComponent
                (new ValueMatchValidator(
                    new Textbox("Confirm Password"), password));

            form.AddComponent(new NumberValidator
                (new Textbox("Age")));

            ////3. Create a FormInput object to begin communication with the user
            /////this is null because I havent figured out how to make it work
            FormInput context = new FormInput(form);
            context.Run();
        }
    }
}
