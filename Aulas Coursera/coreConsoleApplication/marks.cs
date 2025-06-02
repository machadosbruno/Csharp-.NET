namespace coreConsoleApplication
{
    internal class Marks : StudentInfo
    {
        float objectiveMarks;
        float subjectiveMarks;

        public void acceptDetails(){
            base.acceptDetails();
            Console.Write("Enter de Objective Marks: ");
            objectiveMarks = float.Parse(Console.ReadLine());
            
            Console.Write("Enter de Subjective Marks: ");
            subjectiveMarks = float.Parse(Console.ReadLine());
        }
    
        public void displayDetails(){
            base.displayDetails();
            Console.WriteLine("Objective Marks: " + objectiveMarks);
            Console.WriteLine("Subjective Marks: " + subjectiveMarks);
        }
    }
}