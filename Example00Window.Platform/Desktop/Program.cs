using System;
using Impression;

namespace Example00Window
{
    class Program
    {
        static void Main(string[] args)
		{
			using(var game = new Example00WindowGame())
            {
                game.Run();
            }
		}
    }
}