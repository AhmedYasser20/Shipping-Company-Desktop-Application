using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Windows.Forms;

namespace Shipping_Company
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }


        // login page
        public DataTable getEmployeeRowByUsernameAndPassword(string Username, string Password)
        {
            string query = "select * from Employee where SSN in (select SSN from U_Login WHERE Username = '" + Username + "' AND U_Password = '" + Password + "' );";
            return dbMan.ExecuteReader(query);
        }

        public DataTable RecievedProduct(string SSN)
        {
            string query = "select p.ProductID, cl.FName,cl.LName From Product as p , Client as cl where p.TruckID = -1 AND cl.SSN=p.SenderSSN AND p.ReciverSSN = " + SSN + ";";
            return dbMan.ExecuteReader(query);
        }

        public int GiveProductToReciever(string productid)
        {
            string query = "UPDATE Product  Set TruckID=Null where TruckID=-1 And ProductID="+productid+";";
            return dbMan.ExecuteNonQuery(query);

        }

        public object GetBranchClientBySSN(string SSN)
        {
            string query = "select BranchID From Client where SSN=" + SSN + ";";
            return dbMan.ExecuteScalar(query);
        }

        public int UpdateClient(string FName, string LName, int SSN, float BranchID)
        {
            string query = "UPDATE Client SET FName='" + FName + "', LName ='" + LName + "', BranchID =" + BranchID + " WHERE SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int add_client(string ClientFName, string ClientLName, int SSN, int BranchID)
        {
            string query = "INSERT INTO Client (FName,LName,BranchID,SSN) " +
            "Values ('" + ClientFName + "', '" + ClientLName + "'," + BranchID + ", " + SSN + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetEmployeeBySSN(string SSN)
        {
            string query = "SELECT FName,LName from Employee WHERE SSN="+SSN+";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetEmployeeRowBySSN(int SSN)
        {
            string query = "SELECT * from Employee WHERE SSN=" + SSN + ";";
            return dbMan.ExecuteReader(query);
        }
        public int UpdataEmployeeSalaryBySSN(string SSN,string X)
        {
            string query = "UPDATE Employee Set Salary ="+X+" where SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int FireEmployeeBySSN(string SSN)
        {
            string query = "Delete From Employee Where SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddSupervisor(string fn,string ln,string SSN,string salary,string branchid)
        {
            string query = "insert into Employee (FName, LName, SSN, SupervisorID, Salary, BranchID) VALUES ('" + fn + "','"+ ln + "',"+ SSN + ",0,"+ salary + ","+ branchid + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeSupervisorID(string SSN, string BranchID)
        {
            string query = "Update  employee set SupervisorID="+SSN+" where BranchID="+BranchID+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddManager(string fn, string ln, string SSN, string salary)
        {
            string query = "insert into Employee VALUES ('" + fn + "','" + ln + "'," + SSN + ",0," + salary + ",0"  + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdataBranchID(string SSN,string BranchID)
        {
            string query = "UPDATE Employee SET BranchID="+ BranchID + " WHERE SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewData(string Table)
        {
            string query = "select * from " + Table + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewProducts(string ssn)
        {
            string query = "select ProductID,BillID,Fees From Bill where SenderID=" + ssn +" and StatusOfBill='Pending'";
            return dbMan.ExecuteReader(query);
        }
        public int PayBill(string billid)
        {
            string query = "UPDATE Bill  Set StatusOfBill='Accepted' where BillID=" + billid + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangePassword(string NewPassword, string OldPassword, string UserName)
        {
            string query = "UPDATE U_Login SET U_Password='" + NewPassword + "' Where Username='" + UserName + "' And U_Password='" + OldPassword + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public object GetBillIDByProductID(string productid)
        {
            string query = "SELECT BillID\r\nfrom Bill\r\nwhere ProductID=" + productid + ";";
            return dbMan.ExecuteScalar(query);
        }
        public object GetTruckTypeByID(string TruckID)
        {
            string query = "select TypeOfTruck\r\nfrom Truck\r\nwhere TruckID=" + TruckID + ";";
            return dbMan.ExecuteScalar(query);
        }
        public object GetBranchBySenderSSN(string SenderSSN)
        {
            string query = "SELECT BranchID\r\nFROM Client as c,Product as P\r\nwhere p.SenderSSN="+ SenderSSN + " and p.SenderSSN=SSN" +";";
            return dbMan.ExecuteScalar(query);
        }
        public int SetTempLogin( string UserName,string password,string ssn)
        {
            string query = "INSERT U_Login (Username,U_Password,SSN) VALUES ('" + UserName + "','" + password + "'," + ssn + ") " + ";";
            return dbMan.ExecuteNonQuery(query);
        }
         public int CreateBill(string ProductID,string EmployeeID,string SenderID,string StatusOfBill,string fees)
         {
            string query = "insert into Bill (ProductID,EmployeeID,SenderID,StatusOfBill,Fees)" +
                "values ("+ ProductID + ","+ EmployeeID + ","+ SenderID + ",'"+ StatusOfBill + "',"+ fees + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public object GetProductID(string S_SSN,string R_SSN)
        {
            string StoredProcedureName = StoredProcedures.getProductID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSSN", S_SSN);
            Parameters.Add("@RSSN", R_SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable ViewAvailTrucksPS(int branchID)
        {
            string StoredProcedureName = StoredProcedures.viewAvailTrucks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bID", branchID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ViewAvailDriverPS(int branchID)
        {
            string StoredProcedureName = StoredProcedures.viewAvailDrivers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bID", branchID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public object GetPrice(int Weight,  string TruckType)
        {

            string StoredProcedureName = StoredProcedures.getPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@weight", Weight);
            Parameters.Add("@TType", TruckType);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable ViewBranchProduct(int branchid)
        {
            string query = "SELECT  p.ProductID,BillID,TruckType FROM Product as p,Bill as b WHERE b.StatusOfBill='Accepted' And p.ProductID=b.ProductID And SenderSSN in (select SSN \r\nFROM Client\r\nwhere BranchID="+branchid.ToString()+"And TruckID=0 )" + ";";
            return dbMan.ExecuteReader(query);
        }
        public int AssignProduct(string TruckID,string capacity,string typeoftruck,string branchid)
        {
            string query = "update Product SET TruckID = " + TruckID + " where ProductID in(select  distinct top "+capacity+" p.ProductID from Product as p,Bill as B, truck as T where B.StatusOfBill='Accepted' And p.TruckType = T.TypeOfTruck And p.TruckType = '"+ typeoftruck + "' AND p.TruckID = 0 AND P.SenderSSN in(select SSN from Client where BranchID = "+branchid+"))";
            return dbMan.ExecuteNonQuery(query);
        }

        public object getCapacity(int TruckID)
        {

            string StoredProcedureName = StoredProcedures.getCapacity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@trID", TruckID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int makeBillIDAccept(int BillID)
        {

            string StoredProcedureName = StoredProcedures.getCapacity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@billid", BillID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetNameOfEmployee(string SSN)
        {

            string StoredProcedureName = StoredProcedures.GetEmployeeBySSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SocialSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public object getBranchIdByDriverSSN(string SSN)
        {

            string StoredProcedureName = StoredProcedures.getBranchIdByDriverSSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@socialSN", SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public object getBranchIDForTruck(string truckid)
        {

            string StoredProcedureName = StoredProcedures.getBranchIDForTruck;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@truckid", truckid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public object getProductsNumberInTruck(string truckid)
        {

            string StoredProcedureName = StoredProcedures.getProductsNumberInTruck;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@truckid", truckid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable ShowArrivedProducts(string truckid)
        {
            string query = "select ProductID , SenderSSN,ReciverSSN\r\nfrom Product\r\nwhere TruckID="+ truckid + "";
            return dbMan.ExecuteReader(query);
        }
        public int ArrivedTruckChangeProduct(string truckid)
        {
            string query = "UPDATE Product SET TruckID=-1 WHERE TruckID="+truckid+"";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ArrivedTruckChangeBranchID(string truckid,string newBranch)
        {
            string query = "UPDATE Truck\r\nset BranchID="+newBranch+" where Truck= "+truckid+"";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteTrip(string truckid)
        {
            string query = "DELETE FROM Tripo WHERE TruckID="+truckid+";";
            return dbMan.ExecuteNonQuery(query);
        }


        public int AssignTruckToTrip(string tripid, string truckid)
        {
            string query = "UPDATE Truck set TripID="+ tripid + " where TripID is NULL and TruckID="+truckid+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AssignDriverToTrip(string tripid, string ssn)
        {
            string query = "UPDATE Driver set TripID=" + tripid + " where TripID is NULL and SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public object GetDriverSSN(string SSN)
        {
            string query = "select BranchID From Driver where SSN="+ SSN + ";";
            return dbMan.ExecuteScalar(query);
        }
 
        public object GetBranchOFTruck(string TruckID)
        {
            string query = "select BranchID From Truck where TruckID = "+TruckID+";";
            return dbMan.ExecuteScalar(query);
        }
        public int CreateTrip(string DiverSSN, string StartBranchID,string EndBranchID,string TripID,string NumberOfProducts,string truckID,string startdate,string starttime,string enddate,string endtime)
        {
            string query = "insert into Tripo (DriverID,StartBranchID,EndBranchID,TripID,NumberOfProducts,TruckID,StartData,StartTime,EndData,EndTime) "+
                "values ("+ DiverSSN + ","+ StartBranchID + ","+ EndBranchID + ","+ TripID + ","+ NumberOfProducts + ","+ truckID + ",'"+ startdate + "','"+ starttime + "','"+ enddate + "','"+ endtime + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public object GetEndBranchOFTruck(string TruckID)
        {
            string query = "select  top 1 CL.Branchid from Client as CL , Product as P,Truck as Tr\r\nwhere tr.TruckID="+TruckID+"  and P.ReciverSSN in (\r\nSELECT SSN \r\n    from Client\r\n    where BranchID=Tr.BranchID\r\n)\r\nORDER BY Branchid DESC\r\n";
            return dbMan.ExecuteScalar(query);
        }
        public object GetCountOfProductINTruck(string TruckID)
        {
            string query = "select count(*)\r\nfrom Product\r\nwhere TruckID="+ TruckID + ";";
            return dbMan.ExecuteScalar(query);
        }

        //Snow
        public DataTable ViewAvilableDrivers()
        {
            string query = "select FName ,LName,SSN From Driver where tripID is null" + ";";
            return dbMan.ExecuteReader(query);
        }
        //public DataTable GetAllPriceList()
        //{
        //    string query = "select WeightRange ,TruckType,ProductType From PriceList" + ";";
        //    return dbMan.ExecuteReader(query);
        //}
        public int InsertNewprice(string Minweight,string MaxWeight, string trucktype, int price)
        {
            string query = "INSERT INTO PriceList (MinWeight,MaxWeight,TruckType,Price)" + " Values('" + Minweight + "', '"+ MaxWeight + "','"
                + trucktype + "'," + price + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable FindOutIfThisListExist(string MinWeight,string MaxWeight, string trucktype)
        {
            string query = "SELECT * FROM PriceList WHERE MinWeight = " + MinWeight + "And MaxWeight="+ MaxWeight + " AND TruckType = '" + trucktype + "';";
            return dbMan.ExecuteReader(query);
        }
        public int updateprice(string Minweight,string MaxWeight, string trucktype,  int price)
        {
            string query = "update PriceList set Price=" + price + "where MinWeight =" + Minweight +"AND MaxWeight="+ MaxWeight + "AND TruckType='"
                + trucktype + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int HireDriver(string fname, string lname, int ssn, int salary, int brachID)
        {
            string query = "insert into Driver (FName,LName,SSN,BranchID,Salary) values( '"
                + fname + "','" + lname + "'," + ssn + "," + brachID + "," + salary + ");";
            return dbMan.ExecuteNonQuery(query);

        }
        public int HireEmployee(string fname, string lname, int ssn, int salary, int brachNum, int superssn)
        {
            string query = "insert into Employee (FName,LName,SSN,BranchID,Salary, SupervisorID) values( '"
                + fname + "','" + lname + "'," + ssn + "," + brachNum + "," + salary + "," + superssn + " );";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddTruck(string BranchID, string Type,string speed,string capcity)
        {
            string query = "insert into Truck (BranchID,TopSpeed,TypeOfTruck,Capacity) VALUES( "+BranchID+","+speed+" , '"+Type+"' ,"+capcity+")";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteTruckByID(string TruckID)
        {
            string query = "DELETE FROM Truck WHERE Truckid="+TruckID+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewAvilableTrucks()
        {
            string query = "select * From Truck where tripID is null" + ";";
            return dbMan.ExecuteReader(query);
        }
        public byte[] MakeSalt(int size)
        {
            string query = "select * From Truck where tripID is null" + ";";
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            return buff;
        }
        public string hashing(string password)
        {

            String Salti = "Key@db1205";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password + Salti);
            System.Security.Cryptography.SHA256Managed shastring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = shastring.ComputeHash(bytes);
            return Encoding.Default.GetString(hash);
        }
        //mariam 
        public int add_Product(int S_SSN, int R_SSN, int Weight, string TruckType)
        {
            string query = "INSERT INTO Product (ReciverSSN,SenderSSN,ProductWeight,TruckType) " +
            "Values (" + R_SSN.ToString() + ", " + S_SSN.ToString() + "," + Weight.ToString() +  ",'"+ TruckType + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ProductDetails(string SSN)
        {
            string query = "SELECT StartData, StartTime, EndData,Endtime from Tripo WHERE TruckID in (SELECT TruckID from Product where ReciverSSN = "+SSN+"  or SenderSSN= "+SSN+" );";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetClientByName(string FName, string LName)
        {
            string query = "SELECT * from Client WHERE FName='" + FName + "'and LName ='" + LName + "';";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}