using EmployeeWEBAPIJISAHW.Data;
using EmployeeWEBAPIJISAHW.Models;

namespace EmployeeWEBAPIJISAHW.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            int result=db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result=db.Employees.Where(x=>x.Id==id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result);
                res=db.SaveChanges();
            }
            return res;
        }

        public Employee GetEmployeeById(int id)
        {
            var result=db.Employees.Where(x=>x.Id== id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;
            var result=db.Employees.Where(x=>x.Id==employee.Id).FirstOrDefault();
            if(result != null)
            {
                result.Name = employee.Name;
                result.City= employee.City;

                res=db.SaveChanges();   
            }
            return res;
        }
    }
}
