using System;

public class Program
{
	public static void Main()
	{

		//Think of types as two different species.


		int Fish = 0;  //A fish lives in water (on the stack)

		object Chicken = new object(); //A chicken lives on land (In the heap)

		object BoxedFish = Fish; //So if we want a fish and chicken to travel together
								 //We have to box the value type fish so it can go on
								 //a truck with reference-type The chicken

		//Think of this as a truck carrying all objects
		object[] Truck = new object[] { Chicken, BoxedFish, Chicken };

		//When we get to our destination, we unbox the fish from a reference type to a valye type
		Fish = Convert.ToInt32(BoxedFish);

		/*
		// This is basically how JSON serilization works.
		{
		  "BoxedFish": "0",
		  "Chicken": "Chicken object"
		}
		
		*/

	}
}