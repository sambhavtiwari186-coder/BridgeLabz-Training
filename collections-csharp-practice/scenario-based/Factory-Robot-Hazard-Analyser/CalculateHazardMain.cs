public class CalculateHazardMain
{
    public static void Main(string [] args)
    {
        Console.WriteLine("---Welcome To Hazard Calculation ----");
        Console.WriteLine("Enter the Arm Precision Here ");
        double armPrecision = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter The Worker Density");
        int workerDensity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Machinery State");
        string machineryState = Console.ReadLine();
        CalculateHazard hazard = new CalculateHazard();
      double harm  =  hazard.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
      Console.WriteLine("Robot Hazard Risk Score : " + harm );
    }
}