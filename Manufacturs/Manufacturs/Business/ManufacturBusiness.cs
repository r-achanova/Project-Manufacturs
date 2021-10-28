using Manufacturs.Data;
using Manufacturs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturs.Business
{
   public class ManufacturBusiness
    {
        private ManufacturContext manufacturContext;

        public void AddDepartment(Department department)
        {
            using (manufacturContext = new ManufacturContext())
            {
                manufacturContext.Departments.Add(department);
                manufacturContext.SaveChanges();
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (manufacturContext = new ManufacturContext())
            {
                var item = manufacturContext.Departments.Find(department.DepartmentId);
                if (item != null)
                {
                    manufacturContext.Entry(item).CurrentValues.SetValues(department);
                    manufacturContext.SaveChanges();
                }

            }
        }

        public Department Get(int id)
        {
            using (manufacturContext = new ManufacturContext())
            { return manufacturContext.Departments.Find(id); }
        }

    }
}
