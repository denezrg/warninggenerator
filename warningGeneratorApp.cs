using System;
using System.IO;

namespace warninggenerator
{
    class warningGeneratorApp
    {
        static void Main(string[] args)
        {
            string warningTypeString = "";
            string primaryHazard = "";
            string tornadoThreat = "";
            string commieblock = "";
            string fileoutput = "";
            string athazard = "";
            string pds = "";
            string pto = "";
            Console.WriteLine("\nWarning Generator 1.0 Copyright 2019 denezrg");
            Console.WriteLine("\nOffice:");
            string office = Console.ReadLine();
            DateTime dt = DateTime.Now;
            string date = (dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString());
            Console.WriteLine("\nTime:");
            string time = Console.ReadLine();
            Console.WriteLine("\nTimeZone:");
            string timeZone = Console.ReadLine();
            Console.WriteLine("\nWarningType:");
            string warningType = Console.ReadLine();
            Console.WriteLine("\nState:");
            string state = Console.ReadLine();
            Console.WriteLine("\nCounty:");
            string county = Console.ReadLine();
            Console.WriteLine("\nExpiration:");
            string expiration = Console.ReadLine();
            Console.WriteLine("\nLocation:");
            string location = Console.ReadLine();
            Console.WriteLine("\nMovement:");
            string movement = Console.ReadLine();
            Console.WriteLine("\nHail:");
            string hail = Console.ReadLine();
            Console.WriteLine("\nWind:");
            string wind = Console.ReadLine();
            if (warningType == "SV") {
                warningTypeString = "Severe Thunderstorm Warning";
                primaryHazard = "Severe thunderstorm";
                athazard = "severe thunderstorm";
                pds = "";
                pto = "";

            } else if (warningType == "SVT") {
                warningTypeString = "Severe Thunderstorm Warning";
                primaryHazard = "Severe thunderstorm";
                tornadoThreat = "POSSIBLE";
                athazard = "severe thunderstorm";
                pds = "";
                pto = "";

            } else if (warningType == "TOR") {
                warningTypeString = "Tornado Warning";
                primaryHazard = "Tornado";
                tornadoThreat = "RADAR INDICATED";
                athazard = "severe thunderstorm capable of producing a tornado";
                pds = "";
                pto = "";

            } else if (warningType == "CON"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Radar confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "";
                pto = "";

            } else if (warningType == "SPT"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Weather spotter confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "";
                pto = "";

            } else if (warningType == "LAW"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Law enforcement confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "";
                pto = "";

            } else if (warningType == "TORE"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Confirmed damaging tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed large and extremely dangerous tornado";
                pds = "\n\nTORNADO EMERGENCY FOR " + county + " COUNTY! THIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";
                pto = Environment.NewLine + Environment.NewLine + "THIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";

            } else if (warningType == "PDSCON"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Radar confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "\n\nTHIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";
                pto = Environment.NewLine + Environment.NewLine + "THIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";

            } else if (warningType == "PDSSPT"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Weather spotter confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "\n\nTHIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";
                pto = Environment.NewLine + Environment.NewLine + "THIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";

            } else if (warningType == "PDSLAW"){
                warningTypeString = "Tornado Warning";
                primaryHazard = "Law enforcement confirmed tornado";
                tornadoThreat = "OBSERVED";
                athazard = "confirmed tornado";
                pds = "\n\nTHIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";
                pto = Environment.NewLine + Environment.NewLine + "THIS IS A PARTICULARLY DANGEROUS SITUATION. TAKE COVER NOW!";

            } else {
                Console.WriteLine("Warning ID Not Recognized. Please Restart.");
            }
            if (primaryHazard == "Tornado" || primaryHazard == "Radar confirmed tornado" || primaryHazard == "Weather spotter confirmed tornado" || primaryHazard == "Law enforcement confirmed tornado" || tornadoThreat == "POSSIBLE" || primaryHazard == "Confirmed damaging tornado") {
                commieblock = "\n" + warningTypeString + "\n\nBULLETIN - IMMEDIATE BROADCAST REQUESTED\n" + warningTypeString + "\nNational Weather Service " + office + "\n" + time + " " + timeZone + " " + date + "\n\nThe National Weather Service in " + office + " has issued a\n\n* " + warningTypeString + " for...\n " + county + " County in " + state + "...\n\n* Until " + expiration + " " + timeZone + ".\n\n* At " + time + " " + timeZone + ", a " + athazard + " was " + location + ", and was moving " + movement + "." + pds + "\n\nHAZARD..." + primaryHazard + ", " + hail + " inch hail, and " + wind + " mph wind gusts.\n\n&&\n\nTORNADO..." + tornadoThreat + "\n\nHAIL..." + hail + "IN" + "\n\nWIND..." + wind + "MPH\n";
                fileoutput = Environment.NewLine + warningTypeString + Environment.NewLine + Environment.NewLine + "BULLETIN - IMMEDIATE BROADCAST REQUESTED" + Environment.NewLine + warningTypeString + Environment.NewLine + "National Weather Service " + office + Environment.NewLine + time + " " + timeZone + " " + date + Environment.NewLine + Environment.NewLine + "The National Weather Service in " + office + " has issued a" + Environment.NewLine + Environment.NewLine + "* " + warningTypeString + " for..." + Environment.NewLine + " " + county + " County in " + state + "..." + Environment.NewLine + Environment.NewLine + "* Until " + expiration + " " + timeZone + "." + Environment.NewLine + Environment.NewLine + "* At " + time + " " + timeZone + ", a " + athazard + " was " + location + ", and was moving " + movement + "." + pto + Environment.NewLine + Environment.NewLine + "HAZARD..." + primaryHazard + ", " + hail + " inch hail, and " + wind + " mph wind gusts." + Environment.NewLine + Environment.NewLine + "&&" + Environment.NewLine + Environment.NewLine + "TORNADO..." + tornadoThreat + Environment.NewLine + Environment.NewLine +"HAIL..." + hail + " INCH" + Environment.NewLine + Environment.NewLine + "WIND..." + wind + "MPH" + Environment.NewLine;
            } else if (primaryHazard == "Severe thunderstorm"){
                commieblock = "\n" + warningTypeString + "\n\nBULLETIN - IMMEDIATE BROADCAST REQUESTED\n" + warningTypeString + "\nNational Weather Service " + office + "\n" + time + " " + timeZone + " " + date + "\n\nThe National Weather Service in " + office + " has issued a\n\n* " + warningTypeString + " for...\n " + county + " County in " + state + "...\n\n* Until " + expiration + " " + timeZone + ".\n\n* At " + time + " " + timeZone + ", a " + athazard + " was " + location + ", and was moving " + movement + ".\n\nHAZARD..." + primaryHazard + ", " + hail + " inch hail, and " + wind + " mph wind gusts.\n\n&&\n\nHAIL..." + hail + "IN" + "\n\nWIND..." + wind + "MPH\n";
                fileoutput = Environment.NewLine + warningTypeString + Environment.NewLine + Environment.NewLine + "BULLETIN - IMMEDIATE BROADCAST REQUESTED" + Environment.NewLine + warningTypeString + Environment.NewLine + "National Weather Service " + office + Environment.NewLine + time + " " + timeZone + " " + date + Environment.NewLine + Environment.NewLine + "The National Weather Service in " + office + " has issued a" + Environment.NewLine + Environment.NewLine + "* " + warningTypeString + " for..." + Environment.NewLine + " " + county + " County in " + state + "..." + Environment.NewLine + Environment.NewLine + "* Until " + expiration + " " + timeZone + "." + Environment.NewLine + Environment.NewLine + "* At " + time + " " + timeZone + ", a " + athazard + " was " + location + ", and was moving " + movement + "." + Environment.NewLine + Environment.NewLine + "HAZARD..." + primaryHazard + ", " + hail + " inch hail, and " + wind + " mph wind gusts." + Environment.NewLine + Environment.NewLine + "&&" + Environment.NewLine + Environment.NewLine + "HAIL..." + hail + " INCH" + Environment.NewLine + Environment.NewLine + "WIND..." + wind + "MPH" + Environment.NewLine;
            }
            Console.WriteLine(commieblock);
            string combined = Directory.GetCurrentDirectory() + "\\warning.txt";
            System.IO.File.WriteAllText(combined, fileoutput);
            Console.ReadKey();
        }
    }
}
