// See https://aka.ms/new-console-template for more information
using Business;

//User requests a tool set from agent
// Tool set is passed to the Agent
// Agent has a library of tools
// If tool requested is matched string values to a potential method
//  Tool implementation Enhancement to add generic support

// Implementation
// Add a class library project. Will use DIC add interfaces and define methods


Repository repository = new Repository();

while (true)
{
    Console.WriteLine("Enter selections: time or random or test. Press q to quit");
    string? value = Console.ReadLine();

    if (value.ToLower() == "q") break;

    string input = repository.OrchestrateReturn(value);

    Console.WriteLine(input);

    
}




