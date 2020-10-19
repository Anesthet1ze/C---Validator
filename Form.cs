/* Class Name: Form.cs
 * Author: Kristina vanderBoog
 *Purpose: This represents the mediator part of the design pattern.  It holds a list of IFormComponents
            then includes a getter so that it can pass the information to the input state
  Date: August 14, 2020
*/
using System.Collections.Generic;

namespace Project_3_Starter
{
    public class Form
    {

        private List<IFormComponent> components = new List<IFormComponent>();

     /*This method will add components as they are created to the IFormComponent List
      * It Returns nothing*/
       public void AddComponent(IFormComponent component)
        {
            components.Add(component);
        }

       
        /*This method returns the current populated IFormComponent List for Inputstate access */
        public List<IFormComponent> GetComponent()
       {
            return components;
       }

       
    }
}
