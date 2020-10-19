/* Interface Name: IFormComponent.cs
 * Author: Kristina VanderBoog
  Purpose: This is the Component (top class in the decorator pattern) it sets up the interface
            for the inheriting subclasses (concrete component(textbox)) and Decorator(Validator)
  Date: August 14, 2020
*/


namespace Project_3_Starter
{
    public interface IFormComponent
    {
         string GetName();

         string GetValue();

         bool SetValue(string value);

         bool IsValid();
    }
}
