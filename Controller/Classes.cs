namespace Firm.Controller
{
    internal class Classes
    {
        public void Instantiate()
        {
            // Not allowed due to abstraction
            //Model.Employee employee = new Model.Employee();

            // Creating a sweeper employee
            Model.Employee sweeper = new Model.Sweeper(firstName: "James", lastName: "Jackson", cpr: 2504936773);

            // Creating a manager employee
            Model.Employee manager = new Model.Manager(firstName: "Michael", lastName: "Johnson", cpr: 1508884205, phoneNumber: 58149388);

            // Creating a project manager employee
            Model.Employee projectManager = new Model.ProjectManager(firstName: "David", lastName: "Robinson", cpr: 2902854169, phoneNumber: 27642286, email: "davrob@firm.dk");

            // Writing all object details to console
            View.Print.PrintClassDetails(sweeper, manager, projectManager);
        }
    }
}