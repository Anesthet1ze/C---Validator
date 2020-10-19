//Class Name: State.cs
//Author: Kristina Vanderboog
//Purpose: This is the State: State part of the state pattern
//it will define an interface for the encapsulating state behavior
//Date: Aug 14, 2020

namespace Project_3_Starter
{
   public abstract class State
    {
        protected FormInput form;

        //creates a state object that is passed Form input 
        public State(FormInput f)
        {
            form = f;
        }

        public virtual void Run() { } 
    }
}
