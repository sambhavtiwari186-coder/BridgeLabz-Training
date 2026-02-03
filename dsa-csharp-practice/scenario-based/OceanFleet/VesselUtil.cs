using System.Collections.Generic;

public class VesselUtil
{
   private List<Vessel> vesselList = new List<Vessel>();
   public void addVesselPerformane(Vessel vessel)
    {
        vesselList.Add(vessel);
    }
    public Vessel getVesselById(string vesselId)
    {
        for(int i = 0; i < vesselList.Count; i++)
        {
            if (vesselId.Equals(vesselList[i].getVesselId()))
            {
                return vesselList[i];
            }
        }
         return null;
    }
    public List<Vessel> getHighPerformanceVessels()
    {
        List<Vessel> GetVessel = new List<Vessel>();
        double max = vesselList[0].getAverageSpeed();
        for(int i = 0; i < vesselList.Count; i++)
        {
            if (vesselList[i].getAverageSpeed() > max)
            {
                max=vesselList[i].getAverageSpeed();
            }
        }
        for(int i = 0; i < vesselList.Count; i++)
        {
            if (vesselList[i].getAverageSpeed() == max)
            {
                GetVessel.Add(vesselList[i]);
            }
        }
        return GetVessel;
    }
}