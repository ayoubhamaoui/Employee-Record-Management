using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERMS.Models
{
    public class EmployeeDataAccessLayer
    {
        ERMSContext db = new ERMSContext();
        
        public IEnumerable<TbEmployee> GetAllEmployees()
        {
            try
            {
                return db.TbEmployee.ToList();
            }
            catch
            {
                throw;
            }
        }

        //add new employee record
        public int AddEmployee(TbEmployee employee)
        {
            try
            {
                db.TbEmployee.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //update the record of an employee
        public int UpdateEmployee(TbEmployee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();

            return 1;
        }

        //detail of particulare employee
        public TbEmployee GetEmployeeData(int id)
        {
            try
            {
                TbEmployee employee = db.TbEmployee.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //delete record of particular employee
        public int DeleteEmployee(int id)
        {
            try
            {
                TbEmployee employee = db.TbEmployee.Find(id);
                db.TbEmployee.Remove(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //get list of cities
        public List<TbCities> GetCities()
        {
            List<TbCities> lstCities = new List<TbCities>();
            lstCities = (from CityList in db.TbCities select CityList).ToList();

            return lstCities;
        }


    }
}
