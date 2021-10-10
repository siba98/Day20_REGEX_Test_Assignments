﻿using Day20_REGEX_Assignments.CustomException;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_REGEX_Assignments.UC2_LastName
{
    public class LastName_Pattern
    {
        public static string Regex_Lastname = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateLastName(string lastname) //method to check lastname
        {
            if (lastname == null)
            {
                throw new CustomException.UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(lastname, Regex_Lastname);
        }
    }
}
