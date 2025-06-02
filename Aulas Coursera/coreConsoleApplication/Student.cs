namespace coreConsoleApplication
{
    internal class Student
    {
        //Data members
        private int studentId;
        private string studentName;

        //Default Constructor
        public Student(){
            studentId = 101;
            studentName = "Annonymous";
        }
        //Parametrized Constructor
        public Student(int sId, string sname){
            studentId = sId;
            studentName = sname;
        }
        //Members Functions
        public void acceptDetails(){
            Console.Write("Enter Student ID: ");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();
        }
        public void displayDetails(){
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}