using System.ComponentModel;
using System.ComponentModel.Design;
using System.Transactions;

public class VesselMenu
{
    private VesselUtil util = new VesselUtil();
    private Vessel vessel;
    public void Start()
    {
        Console.WriteLine(" -----  Welcome To Ocean Fleet ----");
        int choice;
            Console.WriteLine("Enter The Number Of Vessels To be Added");
            choice = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < choice; i++)
            {
              AddVessel();
            }
            getVessel();
            maxCapacity();
        
    }
    public void AddVessel()
    {
        Console.WriteLine("Enter The Vessel-Id");
              string vesselId = Console.ReadLine();
              Console.WriteLine("Enter The VesselName Here : ");
              string vesselName = Console.ReadLine();
              Console.WriteLine("Enter The Vessel Type");
              string vesselType = Console.ReadLine();
              Console.WriteLine("Enter the Average Speed of the Vessel ");
              double averageSpeed= Convert.ToDouble(Console.ReadLine());
             vessel = new Vessel(vesselId,vesselName,averageSpeed,vesselType);
             util.addVesselPerformane(vessel); 
    }
    public void getVessel()
    {
        Console.WriteLine("Enter The Veseel Id To Check Speed");
            string getVessel = Console.ReadLine();
          Vessel ves =  util.getVesselById(getVessel);
        if (ves == null)
        {
            Console.WriteLine("Vessel Not Found");
        }
          Console.WriteLine(ves);
    }
    public void maxCapacity()
    {
        Console.WriteLine(" High Performance Vessels are ");
          List<Vessel> list = util.getHighPerformanceVessels();
          for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

    }

}