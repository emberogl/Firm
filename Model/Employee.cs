﻿namespace Firm.Model
{
    /// <summary>
    /// All employees must have a first name, last name, and cpr number
    /// </summary>
    abstract class Employee
    {
        private protected string _firstName = "name0";
        private protected string _lastName = "name1";
        private protected uint _cpr = 0;

        private protected Employee(string firstName, string lastName, uint cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public uint GetCprNumber()
        {
            return _cpr;
        }
    }
}