using System;
using Video.Operation;

namespace Video
{
    class Program
    {
        static void Main(string[] args)
        {
		VideoTape vt = new VideoTape();
	        vt.Forward(600);
		Console.WriteLine("#1: " + vt.Position + "s");	
	        vt.Back(150);
		Console.WriteLine("#2: " + vt.Position + "s");	
		vt.Name = "My Best Movie";
		Console.WriteLine("#3: " + vt.Name);	


		VideoTape vx = new VideoTape();
	        vx.Forward(900);
		Console.WriteLine("#1: " + vx.Position + "s");	
	        vx.Back(650);
		Console.WriteLine("#2: " + vx.Position + "s");	
		vx.Name = "My Best Movie2";
		Console.WriteLine("#3: " + vx.Name);	
        }
    }
}
