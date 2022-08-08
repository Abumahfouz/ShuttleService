using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuttleService
{
    internal interface IShuttleRules
    {
        internal int Verification (string driverName, DateTime dateOfBirth, int driverID, bool isLicensed);
        internal string VehicleRequirement(string vehicleType, string vinNumber, string capacity);
        internal bool Station (string size, int noOfExits, string qaLicense);

    }
}
