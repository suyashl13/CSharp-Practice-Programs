// Implicit typing example
char a = 'A';
String number = "124";
int b = a;
Console.WriteLine(b);

double convertedValue = double.Parse(number);
Console.WriteLine(convertedValue);

// Try parse
int result = -1;
bool isConverted = int.TryParse(number, out result);
Console.WriteLine(result + ", " + isConverted);

// Try parse with input
Console.WriteLine("Enter your age: ");
String age = Console.ReadLine();
Boolean isValidAgeType = int.TryParse(age, out result);
Console.WriteLine(isValidAgeType + ", " + result);
String result2 = Convert.ToString(result);
Console.WriteLine(result2);
