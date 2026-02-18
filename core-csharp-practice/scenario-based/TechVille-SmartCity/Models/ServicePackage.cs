namespace TechVilleSmartCity.Models
{
    public class ServicePackage
    {
        public static void ShowPackageBenefits(string packageName)
        {
            switch (packageName)
            {
                case "Platinum":
                    System.Console.WriteLine("Platinum Benefits: Free Healthcare, Premium Transport, VIP Services");
                    break;

                case "Gold":
                    System.Console.WriteLine("Gold Benefits: Subsidized Healthcare, Priority Transport");
                    break;

                case "Silver":
                    System.Console.WriteLine("Silver Benefits: Basic Healthcare Support");
                    break;

                case "Basic":
                    System.Console.WriteLine("Basic Benefits: Access to Standard Services");
                    break;

                default:
                    System.Console.WriteLine("No valid package selected.");
                    break;
            }
        }
    }
}
