/*namespace assignmentone{
    class EmployeeClient
    {
        public static void Main()
        {
            Employee e =new Permanent();
            e.GetDetails();
            e.CalculateSalary();
            e.ShowDetails();
            e=new Trainee();
            e.GetTraineeDetails();
            e.CalculateSalary();
            e.ShowTraineeDetails();

            //Rectangle r =new Rectangle();
            //r.Accept();
            //r.GetDetails();
            //r.ShowDetails();
            //r.Display();
        }
    }
}*/

namespace assignmentone
{
    class EmployeeClient
    {
        public static void Main()
        {
            // Create an object of type Permanent
            Employee e = new Permanent();

            // Call methods specific to Permanent class
            ((Permanent)e).GetDetails();
            ((Permanent)e).CalculateSalary();
            ((Permanent)e).ShowDetails();

            // Create an object of type Trainee
            e = new Trainee();

            // Call methods specific to Trainee class
            ((Trainee)e).GetTraineeDetails();
            ((Trainee)e).CalculateSalary();
            ((Trainee)e).ShowTraineeDetails();
        }
    }
}