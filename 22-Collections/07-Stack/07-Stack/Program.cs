using ClassLibrary;
class Program {
    static void Main() {
        // Stack demo
        Stack<Student> studentStack = new Stack<Student>();

        studentStack.Push(new Student(name: "AAA", 55));
        studentStack.Push(new Student(name: "BBB", 75));
        studentStack.Push(new Student(name: "CCC", 85));

        int rank = 1;
        foreach (Student item in studentStack)
        {
            item.Rank = rank;
            rank++;

            Console.WriteLine($"{item}'s rank is {item.Rank}");
        }

        // Remove Elements
        Student poppedStudent = studentStack.Pop();
        Console.WriteLine($"Popped Student is: {poppedStudent}");

        // See Last Added element
        Console.WriteLine($"Last added item: {studentStack.Peek()}");

    }
}