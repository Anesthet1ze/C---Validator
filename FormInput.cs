//Class Name: FormInput.cs
//Author:Kristina VanderBoog
//Purpose: This is the state Context part of the State pattern, it interacts with the client and the state
//Date : August 14, 2020

namespace Project_3_Starter
{
    //this is the state context!
    public class FormInput 
    {
        //a form object will be created and passed to the state context
        private Form form;
        private State state;

   
        public FormInput(Form f)
        {
            this.form = f;
        }

        //a form object is created and populated then sent to FormInput
    
        //state context class must maintain a reference to state 
        /*This method will change the state depending on the current state that is passed to it */
        public void ChangeState(State state)
        {
           
            this.state = state;
            state.Run();
        }


        //this run method will begin the program
        public void Run()
        {
            this.state = new InputState(this);
            state.Run();
        }

        /*Get form is used to get the currently populated form into the input state */
        public Form getForm()
        {
            return form;
        }
       
    

    }
}
