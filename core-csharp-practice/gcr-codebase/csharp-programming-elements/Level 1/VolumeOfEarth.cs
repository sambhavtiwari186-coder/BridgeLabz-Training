using System;
public class VolumeOfEarth{
	public static void Main(){
		// Taking  Radius of Earth as input
		int RadiusOfEarth=6378;
		float VolumeOfEarth= (4f/3f)* 3.14f*((float) RadiusOfEarth*RadiusOfEarth*RadiusOfEarth);
		float VolumeInMiles = 1.6f*VolumeOfEarth;
		// Printing the answers
		Console.WriteLine("The volume of earth in cubic kilometers is" + VolumeOfEarth + "and cubic miles is" + VolumeInMiles);
	}
}