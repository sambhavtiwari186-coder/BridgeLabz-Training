public class Vessel
{
   public  string vesselId {get;private set;}
   public string vesselName{get;private set;}
   public double averageSpeed{get;private set;}
   public string vesselType{get;private set;}
   public Vessel(string vesselId,string vesselName,double averageSpeed,string vesselType)
    {
        this.vesselId=vesselId;
        this.vesselName=vesselName;
        this.averageSpeed=averageSpeed;
        this.vesselType=vesselType;
    } 
      public string getVesselId()
    {
        return vesselId;
    }
    public double getAverageSpeed()
    {
        return averageSpeed;
    }
    public override string ToString()
    {
        return $"{vesselId} | {vesselName} | {vesselType} | {averageSpeed} ";
    }
}