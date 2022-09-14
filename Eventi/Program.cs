using System;

namespace Eventi
{

    /*
        This class represents the emitter class
        that will trigger an event each time the
        property specified will be modified.
    */
    public class Emitter
    {
        private string message;

        public string Message
        {
            get { return message; }

            set { message = value; OnNewMessage(message); }
        }

        // event definition
        public event Action<string> NewMessage;

        public void OnNewMessage(string msg)
        {
            if (NewMessage != null)
            {
                NewMessage(msg);
            }
        }
    }

    /*
        This class represents the listener class
        that will subscribe to the messages trigger
        by the emitter.
    */
    public class Listener
    {
        public void MessageHandler(string message)
        {
            Console.WriteLine("The message {0} has been received", message);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // creating an instanze of the emitter class
            Emitter emitter = new Emitter();

            // creating two instanze of the listener class
            Listener listener1 = new Listener();
            Listener listener2 = new Listener();

            // doing the subscription of the listeners to the emitter
            emitter.NewMessage += listener1.MessageHandler;
            emitter.NewMessage += listener2.MessageHandler;

            // generating the messages
            emitter.Message = "First Message";
            emitter.Message = "Second Message";
        }
    }
}