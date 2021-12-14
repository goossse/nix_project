using System;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class ValuteAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null) 
            {
                string Currency = value.ToString();
                if (Currency.Length == 3 && Currency.ToUpper() == Currency)
                {
                    return true;
                }
            }
            return false;
        }
    }
}