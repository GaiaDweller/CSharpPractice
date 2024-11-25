using System;

namespace Practice_2 
{
    class Practice_2 
    {
        static void Main(string[] args)
        {
            string[] colors = {"Yellow", "Grey", "Not a Color"};
            Console.WriteLine($"{colors[0]} is before {colors[1]}, {colors[1]} is before {colors[2]}!");
            colors[0] = "Black";
            colors[1] = "Green";
            colors[2] = "Purple";
            Console.WriteLine($"{colors[0]} is before {colors[1]}, {colors[1]} is before {colors[2]}!");
        }
    }
}
