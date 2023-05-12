using System; // Import the "System" namespace, which contains fundamental classes and base classes.

class Entry // Define a class called "Entry".
{
    public string _prompt; // Declare a public property called "Prompt" 
    public string _response; // Declare a public property called "Response" 
    
    public string _date; // Declare a public property called "Date" 

    public Entry(string prompt, string response, string date) // Declare a public constructor for the "Entry" class that takes three parameters: "prompt", "response", and "date".
    {
        _prompt = prompt; // Set the value of the "Prompt" property to the value of the "prompt" parameter.
        _response = response; // Set the value of the "Response" property to the value of the "response" parameter.
        _date = date; // Set the value of the "Date" property to the value of the "date" parameter.
        
    }
}
