using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Net;
using System.Xml.Linq;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public int AddProduct(string pid, string pname, string price, string pres, string sid)
        {
            string procedurename = StoredProcedures.AddProduct;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pid", pid);
            parameters.Add("@pname", pname);
            parameters.Add("@price", price);
            parameters.Add("@pres", pres);
            parameters.Add("@sid", sid);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(procedurename, parameters));
            return x;
        }

        public int AddSup(string supid, string supname, string supcity)
        {
            string procedurename = StoredProcedures.AddSup;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@supid", supid);
            parameters.Add("@supcity", supcity);
            parameters.Add("@supname", supname);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(procedurename, parameters));
            return x;
        }


        public bool DelSup(string supname)
        {
            string procedurename = StoredProcedures.DelSup;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@supname", supname);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(procedurename, parameters));
            if (x == 1)
                return true;
            else
                return false;
        }

        public int Restock(string id, string pid, string qty, string off, string bid, string expdate)
        {
            string procedurename = StoredProcedures.Restock;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            parameters.Add("@pid", pid);
            parameters.Add("@qty", qty);
            parameters.Add("@off", off);
            parameters.Add("@bid", bid);
            parameters.Add("@expdate", expdate);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(procedurename, parameters));
            return x;
        }

        public DataTable Reviews(string bid, string rating1, string rating2)
        {
            string procedurename = StoredProcedures.Reviews;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@rating1", rating1);
            parameters.Add("@rating2", rating2);
            parameters.Add("@bid", bid);
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable ViewInBody(string cid)
        {
            string procedurename = StoredProcedures.ViewInBody;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@cid", cid);
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable DailyReport(string date)
        {
            string procedurename = StoredProcedures.DailyReport;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@date", date);
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable Revenue(string year)
        {
            string procedurename = StoredProcedures.Revenue;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@year", year);
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable BudgetvSpent()
        {
            string procedurename = StoredProcedures.BudgetvSpent;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable GetSup()
        {
            string procedurename = StoredProcedures.GetSup;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable GetBranches()
        {
            string procedurename = StoredProcedures.GetBranches;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable GetProducts()
        {
            string procedurename = StoredProcedures.GetProducts;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public DataTable GetCustomers()
        {
            string procedurename = StoredProcedures.GetCustomers;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(procedurename, parameters);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable getbranchID()
        {
            string SPN = StoredProcedures.GETBRANCHIDS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getemployeeID()
        {
            string SPN = StoredProcedures.GETEMPLOYEEID;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getpID()
        {
            string SPN = StoredProcedures.GETPIDS;
            return dbMan.ExecuteReader(SPN, null);

        }

        public DataTable branchPerformance()
        {
            string SPN = StoredProcedures.BRANCHPERFORMANCE;
            return dbMan.ExecuteReader(SPN, null);
        }
        public DataTable getSubscriptionID()
        {
            string SPN = StoredProcedures.GETTODAYSUBSCRIPTION;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getmanagers()
        {
            string SPN = StoredProcedures.GETMANAGERS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getproductids()
        {
            string SPN = StoredProcedures.GETPRODUCTIDS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable get1subs()
        {
            string SPN = StoredProcedures.GET1SUBS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable get0subs()
        {
            string SPN = StoredProcedures.GET0SUBS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getcustomerID()
        {
            string SPN = StoredProcedures.GETCUSTOMERIDS;
            return dbMan.ExecuteReader(SPN, null);

        }
        public DataTable getemployees()
        {
            string SPN = StoredProcedures.GETEMPLOYEES;
            return dbMan.ExecuteReader(SPN, null);

        }

        public DataTable newSubscriptions()
        {
            string SPN = StoredProcedures.NEWSUBSCIRBERS;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable newCustomers()
        {
            string SPN = StoredProcedures.NEWCUSTOMERS;
            return dbMan.ExecuteReader(SPN, null);
        }

        public DataTable totalEmployees()
        {
            string SPN = StoredProcedures.TOTALEMPLOYEES;
            return dbMan.ExecuteReader(SPN, null);
        }
        public DataTable getbatchids(int branchid)
        {
            string SPN = StoredProcedures.GETBATCHIDS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BRANCHID", branchid);
            return dbMan.ExecuteReader(SPN, Parameters);

        }
        public DataTable getProductsinsub(int subscriptionid)
        {
            string SPN = StoredProcedures.GETPRODUCTSINSUBS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SUBSCRIPTIONID", subscriptionid);
            return dbMan.ExecuteReader(SPN, Parameters);

        }
        public int deactivatesub(int subscriptionid)
        {
            string SPN = StoredProcedures.DEACTIVATESUBS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SUBSCRIPTIONID", subscriptionid);
            return dbMan.ExecuteNonQuery(SPN, Parameters);

        }
        public int activatesub(int subscriptionid)
        {
            string SPN = StoredProcedures.ACTIVATESUBS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SUBSCRIPTIONID", subscriptionid);
            return dbMan.ExecuteNonQuery(SPN, Parameters);

        }
        public object getcusinsubs(int subscriptionid)
        {
            string SPN = StoredProcedures.GETCUSOFAUBS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SUBSCRIPTIONID", subscriptionid);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;

        }
        public int addorder(int OrderID,int EmployeeID , int CustomerID)
        {
            string SPN = StoredProcedures.ADDORDER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            Parameters.Add("@EMPLOYEEID", EmployeeID);
            Parameters.Add("@CUSTOMERID", CustomerID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int addsubscription(int SubscriptionID, int Interval,int Active, int CustomerID)
        {
            string SPN = StoredProcedures.ADDSUBSCRIPTION;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SUBSCRIPTIONID", SubscriptionID);
            Parameters.Add("@INTERVAL", Interval);
            Parameters.Add("@ACTIVE", Interval);
            Parameters.Add("@CUSTOMERID", CustomerID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int addproductinsubscription(int PID, int subscriptionID, int Quantity)
        {
            string SPN = StoredProcedures.ADDPRODUCTINSUBSCRIPTION;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@SUBSCRIPTIONID", subscriptionID);
            Parameters.Add("@QUANTITY", Quantity);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int addproductinorder(int OrderID, int BatchID, int Quantity)
        {
            string SPN = StoredProcedures.ADDPRODUCTINORDER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            Parameters.Add("@BATCHID", BatchID);
            Parameters.Add("@QUANTITY", Quantity);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int addproductinsubs(int OrderID, int PID, int Quantity)
        {
            string SPN = StoredProcedures.ADDPRODUCTINORDERSUBS;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            Parameters.Add("@PID", PID);
            Parameters.Add("@QUANTITY", Quantity);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public object getsbatchid(int PID)
        {
            string SPN = StoredProcedures.GETSBATCHID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public object getbdao(int OrderID)
        {
            string SPN = StoredProcedures.GETBDAO;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public object getbd(int OrderID)
        {
            string SPN = StoredProcedures.GETBD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            int x=Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public object getafter(int OrderID)
        {
            string SPN = StoredProcedures.GETTOTAL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public DataTable getproductsinorder(int OrderID)
        {
            string SPN = StoredProcedures.VIEWPRODUCTSINORDER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            return dbMan.ExecuteReader(SPN, Parameters);
        }
        public object getQUANTITY(int BatchID)
        {
            string SPN = StoredProcedures.GETQUANTITY;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BATCHID", BatchID);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public object gettier(int CustomerID)
        {
            string SPN = StoredProcedures.GETTIER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CUSTOMERID", CustomerID);
            int x = Convert.ToInt32(dbMan.ExecuteScalar(SPN, Parameters));
            return x;
        }
        public int calculateorder(int  OrderID,int customerID,ref int BDAO,ref int  BD,ref int A) {
            string SPN = StoredProcedures.CALCULATETOTAL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ORDERID", OrderID);
            Parameters.Add("@CUSTOMERID", customerID);
            Parameters.Add("@BEFOREDISCOUNTSANDOFFER", BDAO);
            Parameters.Add("@BEFOREDISCOUNTS", BD);
            Parameters.Add("@AFTER", A);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        } 

        public DataTable findproduct(int productID)
        {
            string SPN = StoredProcedures.FINDPRODUCT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProductID", productID);
            return dbMan.ExecuteReader(SPN, Parameters);

        }

        public int insertEmployee(int ID, string Name, float Salary, string Role, string phone, string Address, string Password, int BranchID)
        {
            string SPN = StoredProcedures.ADDEMPLOYEE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EMPLOYEEID", ID);
            Parameters.Add("@EMPLOYEENAME", Name);
            Parameters.Add("@SALARY", Salary);
            Parameters.Add("@ROLE", Role);
            Parameters.Add("@PHONENUMBER", phone);
            Parameters.Add("@ADDRESS", Address);
            Parameters.Add("@PASSWORD", Password);
            Parameters.Add("@BRANCHID", BranchID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int insertmanager(int ID, string Name, float Salary, string Role, string phone, string Address, string Password, int BranchID)
        {
            string SPN = StoredProcedures.ADDMANAGER;
  


            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EMPLOYEEID", ID);
            Parameters.Add("@EMPLOYEENAME", Name);
            Parameters.Add("@SALARY", Salary);
            Parameters.Add("@ROLE", Role);
            Parameters.Add("@PHONENUMBER", phone);
            Parameters.Add("@ADDRESS", Address);
            Parameters.Add("@PASSWORD", Password);
            if (BranchID != 0)
                Parameters.Add("@BRANCHID", BranchID);
            else
                Parameters.Add("@BRANCHID", Convert.DBNull);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int updatemanager(int ID, int BranchId)
        {
            string SPN = StoredProcedures.UPDATEMANAGER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", ID);
            Parameters.Add("@BRANCHID", BranchId);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int updateprice(int PID, float Price)
        {
            string SPN = StoredProcedures.UPDATEPRICE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@NEWPRICE", Price);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int upgradetier(int CustomerID)
        {
            string SPN = StoredProcedures.UPGRADETIER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CUSTOMERID", CustomerID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int deleteEmployee(int ID)
        {
            string SPN = StoredProcedures.FIREEMPLOYEE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", ID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int deletemanager(int ID)
        {
            string SPN = StoredProcedures.FIREMANAGER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", ID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int insertcustomer(int ID, string name, string address, string phonenumber)
        {
            string SPN = StoredProcedures.ADDCUSTOMER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CUSID", ID);
            Parameters.Add("@CUSTOMERNAME", name);
            Parameters.Add("@ADDRESS", address);
            Parameters.Add("@PHONENUMBER", phonenumber);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public string Login(string ID, string Password)
        {
            string SPN = StoredProcedures.GETLOGINROLE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EmployeeID", ID);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteScalar(SPN, Parameters).ToString();


        }

        public int addBranch(float budget, string location, int managerID)
        {
            string SPN = StoredProcedures.ADDBRANCH;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Budget", budget);
            Parameters.Add("@Location", location);
            Parameters.Add("@EmployeeID", managerID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public int deleteBranch(int branchID)
        {
            string SPN = StoredProcedures.DELETEBRANCH;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BranchID", branchID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public int addReview(int reviewID, string description, float rating, int customerID, int branchID)
        {
            string SPN = StoredProcedures.ADDCOMPLAINT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ReviewID", reviewID);
            Parameters.Add("@Description", description);
            Parameters.Add("@Rating", rating);
            Parameters.Add("@CustomerID", customerID);
            Parameters.Add("@BranchId", branchID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }

        public int addInBody(int inBodyID, float weight, float height, int age, string gender, float muscleMass, float fatPercent, int cusotmerID)
        {
            string SPN = StoredProcedures.ADDINBODY;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@InBodyID", inBodyID);
            Parameters.Add("@Weight", weight);
            Parameters.Add("@Height", height);
            Parameters.Add("@Age", age);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@MuscleMass", muscleMass);
            Parameters.Add("@FatPercent", fatPercent);
            Parameters.Add("@CustomerID", cusotmerID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int approveRefund(int orderID, string description, int employeeID)
        {
            string SPN = StoredProcedures.APPROVEREFUND;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@OrderID", orderID);
            Parameters.Add("@Description", description);
            Parameters.Add("@EmployeeID", employeeID);
            return dbMan.ExecuteNonQuery(SPN, Parameters);
        }
        public int ChangePassword(string ID, string password, string oldpass)
        {
            string SPN = StoredProcedures.CHANGEPASSWORD;
            
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
                
            /*@EmployeeID INT,
              @NewPassword NVARCHAR(10),*/
            Parameters.Add("@EmployeeID", ID);
            Parameters.Add("@OldPassword", oldpass);
            Parameters.Add("@NewPassword", password);
            return dbMan.ExecuteNonQuery(SPN, Parameters);


        }
        public int GetBranchID(string ID)
        {
            string SPN = StoredProcedures.GETBRANCHID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@EmployeeID", ID);
            if (dbMan.ExecuteScalar(SPN, Parameters) == DBNull.Value)
                return 0;
            else
                return (int)(dbMan.ExecuteScalar(SPN, Parameters));

        }

        public void expiryDiscounts()
        {
            string SPN = StoredProcedures.EXPIRYDISCOUNTS;
            dbMan.ExecuteReader(SPN, null);
        }

        public int UpdateBudget(string BranchID , string Budget)
        {
            string SPN = StoredProcedures.CHANGEBRANCHBUDGET;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@BranchID", BranchID);
            Parameters.Add("@NewBudget", Budget);

            return dbMan.ExecuteNonQuery(SPN,Parameters);

        }
        /*public int CreateUser(string ID,string Name,string Salary, string Role, string PhoneNumber, string Address, string Password, string BranchID)
        {
            DateTime Time = DateTime.Now.Date;
            string SPN = StoredProcedures.ADDNEWUSER;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EmployeeID", ID);
            Parameters.Add("@EmployeeName", Name);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Role", Role);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Date", Time);


        }*/
            /*EmployeeID INT = NULL,
    /*@EmployeeName NCHAR(30),
    @Salary FLOAT,
    @Role NCHAR(10),
    @PhoneNumber NCHAR(11),
    @Address NCHAR(300),
    @Password NCHAR(10),
    @BranchID INT,
    @Date DATE,
    @Result INT OUTPUT

    }*/
        }
    }
