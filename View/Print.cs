namespace Firm.View
{
    internal class Print
    {
        /// <summary>
        /// Outputting any employee object in parameter to console
        /// </summary>
        /// <param name="employees"></param>
        public static void PrintClassDetails(params Model.Employee[] employees)
        {
            foreach (Model.Employee employee in employees) 
            {
                Console.WriteLine(employee.ToString());
            }
            Console.ReadKey();
        }
    }
}
