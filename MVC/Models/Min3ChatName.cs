using MVC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Min3CharName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string ime = (string)value;
            if (ime.Count()<=3)
            {
                return new ValidationResult("Ime mora imati vise od 3 znaka");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}