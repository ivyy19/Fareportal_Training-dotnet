using System;
//System.Datetime;
namespace assignmentone
{
    abstract class Employee
    {
        public int Empid
        {
            get;
            set;
        }
        //Properties
        public string? Empname
        {
            get;
            set;
        }

        public float Salary
        {
            get;
            set;
        }
        public DateTime Doj
        {
            get;
            set;
        }

        //Functions

        public  void AcceptDetails()
        {
            Console.WriteLine("Enter the Id: ");
            Empid=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name: ");
            Empname=Console.ReadLine() ;

            Console.WriteLine("Enter Salary: ");
            Salary=float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter the DOJ: ");
            Doj=Convert.ToDateTime(Console.ReadLine() ?? DateTime.Now.ToString());
        }

        public abstract void CalculateSalary();
        
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Id "+Empid);
            Console.WriteLine("Name "+Empname);
            Console.WriteLine("Salary "+Salary);
            Console.WriteLine("DOJ "+Doj);

        }

    }
    class Permanent:Employee{
        public int BasicPay
        {
            get;
            set;
        }
        public int HRA
        {
            get;
            set;
        }

        public int DA{
            get;
            set;

        }

        public int PF
        {
            get;
            set;
        }

        public  void GetDetails()
        {
            //base.Accept();
            Console.WriteLine("Enter Basic pay, HRA, DA, PF");
            BasicPay=Convert.ToInt32(Console.ReadLine());
            HRA=Convert.ToInt32(Console.ReadLine());
            DA=Convert.ToInt32(Console.ReadLine());
            PF=Convert.ToInt32(Console.ReadLine());
        }

        public override void CalculateSalary()
        {
            Salary=BasicPay+HRA+DA-PF;
        }

        public new void ShowDetails()
        {
            //base.Display();
            Console.WriteLine("Salary: "+Salary);
        }
    }
    class Trainee: Employee{
        public int Bonus
        {
            get;
            set;
        }
        public string? Projectname
        {
            get;
            set;
        }

        public  void GetTraineeDetails()
        {
            //base.Accept();
            Console.WriteLine("Enter Salary, Bonus, Projectname");
            Salary=float.Parse(Console.ReadLine() ?? "0");
            Bonus=Convert.ToInt32(Console.ReadLine() ?? "0");
            Projectname=Console.ReadLine() ?? "";
        }


        public override  void CalculateSalary()
        {
            if(Projectname=="Banking")
            Salary=Salary+(float)(0.05*Salary);

            if(Projectname=="Insurance")
            Salary=Salary+(float)(0.1*Salary);
        }

        public  void ShowTraineeDetails()
        {
            //base.display();
            Console.WriteLine("Salary: "+Salary);
        }
    }

}
