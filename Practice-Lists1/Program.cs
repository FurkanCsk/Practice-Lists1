List<string> visitors = new List<string>() { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın" };

Console.WriteLine("** Visitors **\n");
for (int i = 0; i < visitors.Count; i++)
{
    Console.WriteLine($"{i+1} - {visitors[i]}");
}
