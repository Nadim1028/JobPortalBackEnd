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
            return DatabaseContext.EmployerAuthTable.SingleOrDefault(employerAuth => employerAuth.Id == employerAuthId);
        }

        public EmployerAuth GetByEmail(string email)
        {
            return DatabaseContext.EmployerAuthTable.SingleOrDefault(employerAuth => employerAuth.CompanyEmail == email);
        }

        public EmployerAuth GetByUserName(string username)
        {
            return DatabaseContext.EmployerAuthTable.SingleOrDefault(employerAuth => employerAuth.UserName == username);
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
