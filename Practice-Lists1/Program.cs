
// Create a list of visitors
List<string> visitors = new List<string>() 
{ 
    "Bülent Ersoy", 
    "Ajda Pekkan", 
    "Ebru Gündeş", 
    "Hadise", 
    "Hande Yener", 
    "Tarkan", 
    "Funda Arar", 
    "Demet Akalın" 
};

// Print the header
Console.WriteLine("** Visitors **\n");

//Loop through the  list and print each visitor
for (int i = 0; i < visitors.Count; i++)
{
    Console.WriteLine($"{i+1} - {visitors[i]}");
}
