// See https://aka.ms/new-console-template for more information
using Business;

string? value = Console.ReadLine();

Repository repository = new Repository();
string input = repository.OrchestrateReturn(value);

Console.WriteLine(input);

//User requests a tool set from agent
// Tool set is passed to the Agent
// Agent has a library of tools
// If tool requested is matched string values to a potential method
//  Tool implementation Enhancement to add generic support

// Implementation
// Add a class library project. Will use DIC add interfaces and define methods

