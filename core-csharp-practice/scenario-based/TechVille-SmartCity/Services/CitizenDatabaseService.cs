using System;
using TechVilleSmartCity.Models;

namespace TechVilleSmartCity.Services
{
    public class CitizenDatabaseService
    {
        private int[] citizenIds;          // Single Dimensional Array
        private int[,] zoneSectorMatrix;   // 2D Array (Zones x Sectors)
        private int size;

        public CitizenDatabaseService(int capacity)
        {
            citizenIds = new int[capacity];
            zoneSectorMatrix = new int[5, 5]; // 5 Zones, 5 Sectors each
            size = 0;
        }

        // Add Citizen ID
        public void AddCitizenId(int id)
        {
            if (size < citizenIds.Length)
            {
                citizenIds[size] = id;
                size++;
            }
            else
            {
                Console.WriteLine("Database Full!");
            }
        }

        // Assign citizen to Zone & Sector
        public void AssignZoneSector(int zone, int sector)
        {
            if (zone >= 0 && zone < 5 && sector >= 0 && sector < 5)
            {
                zoneSectorMatrix[zone, sector]++;
            }
        }

        // Display All Citizen IDs
        public void DisplayCitizenIds()
        {
            Console.WriteLine("\n--- Citizen IDs ---");
            for (int i = 0; i < size; i++)
            {
                Console.Write(citizenIds[i] + " ");
            }
            Console.WriteLine();
        }

        // Sorting (Bubble Sort)
        public void SortCitizenIds()
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (citizenIds[j] > citizenIds[j + 1])
                    {
                        int temp = citizenIds[j];
                        citizenIds[j] = citizenIds[j + 1];
                        citizenIds[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Citizen IDs Sorted Successfully.");
        }

        // Linear Search
        public void SearchCitizen(int id)
        {
            bool found = false;

            for (int i = 0; i < size; i++)
            {
                if (citizenIds[i] == id)
                {
                    Console.WriteLine("Citizen ID Found at index: " + i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Citizen ID Not Found.");
            }
        }

        // Copy Array
        public void CopyCitizenIds()
        {
            int[] copiedArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                copiedArray[i] = citizenIds[i];
            }

            Console.WriteLine("Citizen IDs Copied to New Array.");
        }

        // Display Zone-Sector Matrix
        public void DisplayZoneSectorData()
        {
            Console.WriteLine("\n--- Zone-Sector Citizen Distribution ---");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(zoneSectorMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
