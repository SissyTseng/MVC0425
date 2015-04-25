using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class CustomValidationAttribute : DataTypeAttribute 
    {
        public CustomValidationAttribute()
            : base("CustomValidation")
        {
        }
        public override bool IsValid(object value)
        {
            //return (int.Parse(value.ToString()) % 2 == 0);
            if (value == null)
                return true;
            //string strValue = (string)value;
            //return strValue.Length % 2 == 0;
            int num=0;
            if (Int32.TryParse(value.ToString(), out num))
            {
                return (num % 2 == 0);
            }
            else
                return true;
            
        }
    }
}