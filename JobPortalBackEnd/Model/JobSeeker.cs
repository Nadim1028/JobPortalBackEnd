﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalBackEnd.Model
{
    public class JobSeeker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string MobileNum { get; set; }
        public string Address { get; set; }
       
    }
}

/*
 public FirstName
 public LastName
public Gender
public Email
public MobileNum
public Address

 */
