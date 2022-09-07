using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class DataBaseFirstApproach
    {
        public static void Main()
        {
            //GetAllEmpDetailByID();
            //GetAllEmpDetails();
            //AddNewEmpoyee();
            //DeleteNewEmployee();
            //UpdateEmpDetails();
            //GetEmployeesSP();
            //GetEmployeesSP1();
            CallStoredProcwithSQLParamater_insert();
            //Console.ReadLine();
        }


        #region UpdatedEmpDetails
        //public static void UpdateEmpDetails()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

        //    emp.Ename = "Jaleel";
        //    ctx.Update(emp);
        //    ctx.SaveChanges();
        //    Console.WriteLine("updated");
        //}
        #endregion



        #region DeleteNewEmployee
        //private static void DeleteNewEmployee()
        //{
        //    var ctx = new trainingTSQLContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 3000;


        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" employee deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        #endregion



        #region AddNewEmpoyee
        //private static void AddNewEmpoyee()
        //{
        //    var ctx = new trainingTSQLContext();

        //    try
        //    {

        //        Emp employee = new Emp();
        //        employee.Empno = 3001;
        //        employee.Ename = " Sheela";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" New employee added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        #endregion



        #region GetAllEmpDetailByID
        //private static void GetAllEmpDetailByID()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + "  " + emp.Sal + " " + emp.Job);
        //}



        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + " " + emp.Sal);
        //    }
        //}
        #endregion


        #region SP[Without Parameter]
        //private static void GetEmployeesSP()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails").ToList();



        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}
        #endregion



        #region SP[With Parameter]
        //private static void GetEmployeesSP1()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emp = ctx.Emps.FromSqlRaw("GetAllDetailsByEmpno @p0", 7566).ToList();
        //    foreach (var e in emp)
        //    {
        //        Console.WriteLine(e.Ename);

        //    }
        //}
        #endregion


        #region Delete

        //private static void RemoveEmp()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var eno = 3001;
        //    int rowsAffected = ctx.Database.ExecuteSqlRaw("RemoveEmployee");
        //    Console.WriteLine($"Number);
        //}

        #endregion



        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new trainingTSQLContext();
            var param = new Microsoft.Data.SqlClient.SqlParameter[] {
                        new SqlParameter() 
                        {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7783
                        },

                         new SqlParameter() 
                         {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Jack"
                         },

                          new SqlParameter() 
                          {
                            ParameterName = "@Job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Employee"
                          }

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("insert_employee @empno, @ename, @job", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException);
            }


            Console.WriteLine("update successful");

        }

    }
}
