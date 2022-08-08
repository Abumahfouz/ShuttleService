namespace ShuttleService
{
    internal class CiscoShuttleService : OurProcedure, IShuttleRules
    {
        static void Main(string[] args)
        {
            string user;
            Console.WriteLine("Welcome to Cisco Shuttle Service! Are you a driver(enter d) or passenger(enter p)?");
            user = Console.ReadLine();
            string newUser = user.ToLower();

            

            if (newUser == "d")
            {
                Registration thisReg = new Registration();
                string thisDriver = thisReg.NewDriverRegistration();
                Console.WriteLine(thisDriver);
                DriverInfo myDriver = new DriverInfo();
                Console.WriteLine("Enter your age: ");
                int driverAge = Convert.ToInt32( Console.ReadLine());
                myDriver.Age = driverAge;
                if (driverAge < 20)
                {
                    Console.WriteLine("You are not yet of age to work with us");
                    return;
                }
                Console.WriteLine("Enter valid Driver ID number: ");
                string driverIDNo = Console.ReadLine();
                myDriver.DriverID = driverIDNo;
            }

            else if (newUser == "p")
            {
                Registration thisReg = new Registration();
                string thisPassenger = thisReg.NewPassengerRegistration();
                Console.WriteLine(thisPassenger);
                CalculateFare thisFare = new CalculateFare();
                double myFare = thisFare.fareCalculator();


            }


    }

        bool IShuttleRules.Station(string size, int noOfExits, string qaLicense)
        {
            Console.WriteLine("Enter Size of Station Garage in feet");
            size = Console.ReadLine();
            Console.WriteLine("Enter Number of Available Exits");
            noOfExits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quality Assurance License ID");
            qaLicense = Console.ReadLine();

            if (noOfExits >= 5 && qaLicense == "") {
                return true;
            }
            else
            {
                return false;
            }
        }

        string IShuttleRules.VehicleRequirement(string vehicleType, string vinNumber, string capacity)
        {

            Console.WriteLine("Enter tyoe of vehicle: ");
            vehicleType = Console.ReadLine();
            Console.WriteLine("Enter VIN Number: ");
            vinNumber = Console.ReadLine();
            Console.WriteLine("What's is your vehicle passenger capacity?");
            capacity = Console.ReadLine();

            return "Your " + vehicleType + " Vehicle Model meets our requirements";
        }

        int IShuttleRules.Verification(string driverName, DateTime dateOfBirth, int driverID, bool isLicensed)
        {
            throw new NotImplementedException();
        }
    }
}