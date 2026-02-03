using System.Data;

public class CalculateHazard
{
    public double CalculateHazardRisk(double armPrecision,int workerDensity,string machineryState)
    {
        if(armPrecision>1.00 || armPrecision < 0.0)
        {
            throw new RobotSafetyException("Error: Arm Precision must be 0.0-1.0 .");
        }
        if(workerDensity<1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error : Worker Density Must be 1-20");
        }
        if(!(machineryState.Equals("Worn") || machineryState.Equals("Faulty") || machineryState.Equals("Critical")))
        {
            throw new RobotSafetyException("Error : Unsupported machinery state");
        }
        double machineRiskFactor;
        if (machineryState.Equals("Worn"))
        {
            machineRiskFactor=1.3;
        }else if (machineryState.Equals("Faulty"))
        {
            machineRiskFactor=2.0;
        }
        else
        {
            machineRiskFactor=3.0;
        }
        double hazradRisk = ((1.0-armPrecision)*15.0)+(workerDensity * machineRiskFactor);
        return hazradRisk;
    }
}