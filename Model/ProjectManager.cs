namespace Firm.Model
{
    /// <summary>
    /// All project managers must have what an employee and a manager has but also an email
    /// </summary>
    internal class ProjectManager : Manager
    {
        private protected string _email = "example@exam.ple";

        public ProjectManager(string firstName, string lastName, uint cpr, uint phoneNumber, string email) : base(firstName, lastName, cpr, phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public override string ToString()
        {
            return $"First name: {_firstName} | Last name: {_lastName} | CPR number: {_cpr} | Phone number: {_phoneNumber} | Email: {_email}";
        }

        public string GetEmail()
        {
            return _email;
        }
    }
}