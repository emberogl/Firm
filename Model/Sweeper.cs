namespace Firm.Model
{
    /// <summary>
    /// Sweepers are employees that require employee info
    /// </summary>
    internal class Sweeper : Employee
    {
        public Sweeper(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}