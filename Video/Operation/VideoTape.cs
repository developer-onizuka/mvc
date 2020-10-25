using System;

namespace Video.Operation
{
	public class VideoTape
	{
		public int Position;
		public string Name;
		public void Forward(int t)
		{
			Position += t;
		}
		public void Back(int t)
		{
			Position -= t;
		}
	}
}

