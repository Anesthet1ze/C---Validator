//Class Name: Validator.cs
//Author: Kristina VanderBoog
//Purpose: This is the Decorator part of the decorator pattern it's going to set the functions needed
//         for subclasses to implement.
//         it is an abstract class
//Date: Aug. 14, 2020

namespace Project_3_Starter
{
    //abstract decorator class
    //use to inherit from Iformcomponent to qualify concrete decorators as components for final list
    public abstract class Validator : IFormComponent
    {

        protected IFormComponent validated;

        public Validator(IFormComponent v)
        {
           validated = v;
        }

        public abstract string GetName();
     
        public abstract bool IsValid();
          
        public abstract bool SetValue(string value);

        public abstract string GetValue();
        
    }
}
