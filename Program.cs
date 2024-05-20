namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            else
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the axis.");





        }

    }
}






        
    
    


