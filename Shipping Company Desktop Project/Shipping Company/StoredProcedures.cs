using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Company
{
    public class StoredProcedures
    {
        public static string getPrice = "getPrice";
        public static string getProductID = "getProductID";
        public static string getCapacity = "getCapacity";
        public static string viewAvailTrucks = "viewAvailTrucks";
        public static string viewAvailDrivers = "viewAvailDrivers";
        public static string GetEmployeeBySSN = "getSSN";
        public static string getBranchIdByDriverSSN = "getBranchIDForDriver";
        public static string getBranchIDForTruck = "getBranchIDForTruck";
        public static string getProductsNumberInTruck = "getProductsNumberInTruck";
        public static string makeBillAccepted = "makeBillAccepted";
    }
}
