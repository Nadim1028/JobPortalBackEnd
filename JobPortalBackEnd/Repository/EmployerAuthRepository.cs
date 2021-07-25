using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalBackEnd.Model;

namespace JobPortalBackEnd.Repository
{
    public class EmployerAuthRepository : DatabaseRepository
    {
        public EmployerAuth Add(EmployerAuth employerAuth)
        {
            DatabaseContext.EmployerAuthTable.Add(employerAuth);
            DatabaseContext.SaveChanges();
            return employerAuth;
        }

        /*public List<StudentAuth> GetAll()
        {
            return databaseContext.StudentAuthTable.ToList();
        }*/

        public EmployerAuth GetEmployerAuthById(int employerAuthId)
        {
            return DatabaseContext.EmployerAuthTable.SingleOrDefault(EmployerAuth => EmployerAuth.Id == employerAuthId);
        }

        public EmployerAuth GetByEmail(string Email)
        {
            return DatabaseContext.EmployerAuthTable.SingleOrDefault(EmployerAuth => EmployerAuth.Email == Email);
        }

        public EmployerAuth Update(EmployerAuth employerAuth)
        {
            DatabaseContext.EmployerAuthTable.Update(employerAuth);
            DatabaseContext.SaveChanges();
            return employerAuth;
        }

        public bool Delete(int employerAuthId)
        {
            DatabaseContext.EmployerAuthTable.Remove(GetEmployerAuthById(employerAuthId));
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
