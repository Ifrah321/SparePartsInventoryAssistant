using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inventory = { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        while (true)
        {
            Console.Write("Which part do you need? ");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a part name or question.");
                continue;
            }
            
            if (input.Equals("Do you actually have any parts?", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"We have {inventory.Length} part(s)!");
                foreach (string part in inventory)
                {
                    Console.WriteLine(part);
                }
                continue; 
            }
            
            foreach (string part in inventory)
            {
                if (input.Equals(part, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"I've got {part} here for you.");
                    Console.WriteLine("(program exits)");
                    return; 
                }
            }
            
            Console.WriteLine($"I am afraid we don't have any {input} in the inventory.");
        }
    }
}