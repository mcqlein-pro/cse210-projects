using System;

class Program
{
    static void Main()
    {
        GoalTracker app = new GoalTracker();
        app.Run();
    }
}

/* 
To show creativity and to exceed requirement, I created a new type of goal called "DeadlineGoal" 
in the program. This goal allows the user to set a deadline for completion. 
To record an event for a DeadlineGoal, when prompted, the user can indicate whether they have 
completed the event or not by entering 'Y' or 'N', respectively.
*/