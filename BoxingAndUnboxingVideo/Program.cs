using System;

public class Program
{
	public static void Main()
	{

		int Fish = 0;

		object BoxedFish = Fish;

		object Chicken = new object();

		object[] Truck = new object[] { Chicken, BoxedFish, Chicken };

		Fish = Convert.ToInt32(BoxedFish);

		/*
		
		{
		  "BoxedFish": "0",
		  "Chicken": "Chicken object"
		}
		
		*/

	}
}