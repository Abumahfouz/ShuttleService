using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuttleService
{
    public class OurProcedure
    {
        public class Registration
        {
            public string NewDriverRegistration()
            {
                Console.WriteLine("Please enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name");
                string lastName = Console.ReadLine();
                Random random = new Random();
                int drCode = random.Next(10, 200);
                string drRegId = firstName + "-" + drCode;
                return "Welcome " + firstName + ", your Registration Number is " + drRegId;
            }

            public string NewPassengerRegistration()
            {
                Console.WriteLine("Please enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name");
                string lastName = Console.ReadLine();
                Random rand = new Random();
                int psgCode = rand.Next(300, 10000);
                string psgRegId = firstName + "-" + psgCode;
                return "Welcome " + firstName + ", your Registration Number is " + psgRegId; ;
            }
        }
        public abstract class AccidentSafeguard
        {
            public abstract bool SafeguardMeasure();
            
            public bool FireSafeguard(bool isFireSafeguard)
            {
                return true;
            }

        }
        internal class CalculateFare
        {

            internal double fareCalculator()
            {
                double distance;
                double timeInMinutes;
                double fare = 25;
                Console.WriteLine("Enter distance in metres");
                distance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter trip duration in minutes");
                timeInMinutes = Convert.ToDouble(Console.ReadLine());
                fare = fare + (distance * timeInMinutes);
                Console.WriteLine("Your fare for this trip is "+ fare);
                return fare;
            }
            internal double tipCalculator(bool IsNewPassenger)
            {
                bool status = IsNewPassenger;
                if (status == true)
                {
                    double tip = 5;
                    Console.WriteLine("Your tip is {0}", tip);
                    return tip;
                }
                else
                {
                    return 0;
                }
                
            }
            internal string tipCalculator(int noOfYears)
            {
                int status = noOfYears;
                if (status > 5)
                {
                    double tip = 10;
                    return "We are glad to have you amongst our valued customers. Your tip is " + tip;
                
                }
                else
                {
                    tipCalculator(false);
                    return "5";
                }
            }
        }

        internal class VehicleProperties
        {
            private string fuelReq = "PMS";
            private string FuelType
            {
                get
                {
                    return fuelReq;
                }
            }
        }

       internal class DriverInfo
        {
                string driverID;
                int age;
            public int Age { get; set; }
            public string DriverID {get; set; }
        }
    }
}
