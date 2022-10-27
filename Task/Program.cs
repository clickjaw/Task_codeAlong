using System;

namespace ClassReview
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.Clear();

            TODO newItem = new TODO("Binge watching 30 Rock", Type.personal, Priority.medium, 8040, "Watching the best comedy show of the 2000s");
            
            newItem.OutputText();
            newItem.ItemComplete();
            newItem.DurationUpdate();
            newItem.taskComplete.isDone = true;
            newItem.OutputText();
            newItem.ItemComplete();
        

        }//main
    }//program

    class TODO
    {

        private string taskName;
        private Type taskType;
        private Priority taskPriority;
        private int taskDuration;
        private string taskDescription;
        public Complete taskComplete;

        //constructor------------------------------

        public TODO(string taskName, Type taskType, Priority taskPriority, int taskDuration, string taskDescription)
        {
            this.taskName = taskName;
            this.taskType = taskType;
            this.taskPriority = taskPriority;
            this.taskDuration = taskDuration;
            this.taskDescription = taskDescription;
        }

        public void OutputText()
        {
            Console.WriteLine($"{this.taskName} is a {this.taskType} task with {this.taskPriority} priority. This task should be filled in {this.taskDuration} minutes.");
            Console.WriteLine($"Do you wish to see task description? Type 'yes' or 'no'.");
            string userInput = Console.ReadLine();
            // string userInput = input.ToLower();
            if (userInput == "yes")
            {
                Console.WriteLine(this.taskDescription);
            }
            else
            {
                Console.WriteLine("exiting process");
            }
        }

        public void DurationUpdate()
        {
            Console.WriteLine("How much more time do you need for your task?");
            this.taskDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Task duration has been updated to {this.taskDuration}");
        }

        public void ItemComplete()
        {
            if (this.taskComplete.isDone == true)
            {
                Console.WriteLine("Task is complete.");
            }
            else
            {
                Console.WriteLine("Task is not completed.");
            }
        }


    }//class todo



    //--------------------------------
    enum Type
    {
        personal, professional, other
    }
    //--------------------------------

    enum Priority
    {
        high, medium, low
    }
    //--------------------------------

    struct Complete
    {
        public bool isDone;
    }
}//namespace