using School;

namespace School
{
    class Student
    {
        private readonly String _name;
        private String _email;

        public String Email {
            set {
                _email = value;
            }
            get => this._email;
        }

        public double Percentage {get; set;}

        public Student(String name, String email){
            this._name = name;
            this._email = email;
        }
    }

    // Outer class
    class MarksCalculation
    {

        public void CalculatePercentage(Student student) {
            CalculationHelper calculationHelper = new CalculationHelper();
            student.Percentage = calculationHelper.GetPercentage(89, 100);
        }


        // This is inner class. By default they are private and only available for outer class.
        public class CalculationHelper
        {
            public int GetPercentage(int securedMarks, int totalMarks) {
                return (securedMarks / totalMarks) * 100;
            }    
        }
    }

}


class Program
{
    static void Main() {
        MarksCalculation marksCalculation = new MarksCalculation();
        Student student = new Student("Suyash", "suyash.lawand@gmail.com");

        marksCalculation.CalculatePercentage(student);

        Console.WriteLine(student.Percentage);
    }
}