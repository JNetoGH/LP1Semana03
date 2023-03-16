using System;

namespace ChangeString {
    class Program {
        
        static void Main(string[] args) {
            
            Console.Write("insert a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            
            Console.Write("insert a char to be removed from the string: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);
        }
        
    }
}