using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipSystem.Models.DB
{
    class DAO
    {

        public void addNewCarNewModel(Car car)
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                ctx.Car.Add(car);
       // ctx.Entry(car.CarFeatures.)
                ctx.SaveChanges();
            }
        }
        public List<CarModel> getCarModels()
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                return ctx.CarModel.ToList();
            }
        }
        public List<CarFeature> getCarFeature()
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                return ctx.CarFeature.ToList();
            }
        }

        public void addEmployee(Employee emp)
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                ctx.Employee.Add(emp);
                ctx.SaveChanges();
            }
        }
        public List<Employee> getEmployees()
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                return ctx.Employee.ToList();
            }
        }

        public Employee searchEmployeeByID(int id)
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {


                Employee emp = ctx.Employee.Include(em => em.EmployeeNavigation).
                             Where(em => em.EmployeeId == id).FirstOrDefault();
                return emp;
                    
            }
        }

        public void updateEmployee(Employee emp)
        {

            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
   ctx.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
   ctx.Entry(emp.EmployeeNavigation).State = 
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();

            }
        }

        public Car searchCarByID(int carId)
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
             return   ctx.Car.Where(c => c.CarId == carId).FirstOrDefault();
            }
        }
        public void sellCar(Car car, Customer cust, decimal totalPrice, string notes)
        {
            using (GSQ2_Garry_TestContext ctx = new GSQ2_Garry_TestContext())
            {
                CarSaleRecord sale = new CarSaleRecord();
                sale.Customer = cust;
                sale.Car = car;
                sale.PuchaseDate = DateTime.Now;
                sale.TotalPaidPrice = totalPrice;
                sale.Note = notes;
                ctx.Entry(sale.Car).State = EntityState.Unchanged;
                ctx.CarSaleRecord.Add(sale);
                ctx.SaveChanges();


                

            }
        }


    }
}
