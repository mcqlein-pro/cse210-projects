using System; // import the System namespace, which provides basic functionality such as console input/output

class Goal // declare a new class called "Goal"
{
    public string _description; // declare a public field called "Description" that is of type string
    public string _dueDate; // declare a public field called "DueDate" that is of type string
    public int _progress; // declare a public field called "Progress" that is of type int

    public Goal(string description, string dueDate, int progress) // declare a constructor for the Goal class that takes in three parameters: a string called "description", a string called "dueDate", and an int called "progress"
    {
        _description = description; // set the value of the "Description" field to the value of the "description" parameter
        _dueDate = dueDate; // set the value of the "DueDate" field to the value of the "dueDate" parameter
        _progress = progress; // set the value of the "Progress" field to the value of the "progress" parameter
    }
}


// The UserCredentials class represents a user's credentials, including their username and password.

class UserCredentials
{
    public string _username; // Represents the username of the user.
    public string _password; // Represents the password of the user.
}
