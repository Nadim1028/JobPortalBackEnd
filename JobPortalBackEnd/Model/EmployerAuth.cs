using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalBackEnd.Model
{
    public class EmployerAuth
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CompanyEmail { get; set; }
        public string RePassword { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string IndustryType { get; set; }
        public string CompanyContactNo { get; set; }
        public string YearOfEstablishment { get; set; }
        public string TradeLicenseNo { get; set; }
    }
}

/*
public Id
public UserName
public CompanyEmail
public RePassword
public Password
public CompanyName
public CompanyAddress
public IndustryType
public CompanyContactNo
public YearOfEstablishment
public TradeLicenseNo
 
 */