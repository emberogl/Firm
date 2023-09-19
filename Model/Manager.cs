namespace Firm.Model
{
    /// <summary>
    /// All managers must have everything an employee has but also a phone number
    /// </summary>
    internal class Manager : Employee
    {
        private protected uint _phoneNumber;

        public Manager(string firstName, string lastName, uint cpr, uint phoneNumber) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
            _phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"First name: {_firstName} | Last name: {_lastName} | CPR number: {_cpr} | Phone number: {_phoneNumber}";
        }
    }
}