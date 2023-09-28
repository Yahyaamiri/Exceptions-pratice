using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions_pratice
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

                Console.WriteLine("********************* OUR Store *************");

                Console.WriteLine("Welcome to the iPhone Sales Consultant!");
                Console.WriteLine("1. Add Customers");
                Console.WriteLine("2. Display Phone Models");
                Console.WriteLine("3. Upgrade Device");
                Console.WriteLine("4. Display Upgrade Details");
                Console.WriteLine("5. Display Customer Details");
                Console.WriteLine("6. Exit");
                Console.WriteLine("************************ Your choice **********");
                Console.Write("Please select an option: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddCustomers();
                            break;
                        case 2:
                            DisplayPhone();
                            break;
                        case 3:
                            UpgradeDevice();
                            break;
                        case 4:
                            DisplayFile("C:\\Users\\harsh\\OneDrive - New Zealand Skills & Education Group\\Desktop\\NZSE Desktop\\csharp\\MyIdea\\Week-7\\upgradeDetails.txt");
                            break;
                        case 5:
                            DisplayFile("C:\\Users\\harsh\\OneDrive - New Zealand Skills & Education Group\\Desktop\\NZSE Desktop\\csharp\\MyIdea\\Week-7\\customerDetails.txt");
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }
            }
        }

        static void AddCustomers()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter location: ");
            string location = Console.ReadLine();

            string customerDetails = $"{name}, {phoneNumber}, {email}, {location}";

            try
            {

                // Save customer details to a text file
                File.AppendAllText("C:\\Users\\harsh\\OneDrive - New Zealand Skills & Education Group\\Desktop\\NZSE Desktop\\csharp\\MyIdea\\Week-7\\customerDetails.txt", customerDetails + Environment.NewLine);

                Console.WriteLine("Customer details saved successfully!");
            }
            catch (IOException ex)

            {
                Console.WriteLine("IOException: " + ex.Message);
            }
        
        
            }

        static void DisplayPhone()
        {
            Console.WriteLine("Choose an iPhone model from the last 5 years:");
            Console.WriteLine("1. iPhone 13");
            Console.WriteLine("2. iPhone 12");
            Console.WriteLine("3. iPhone SE (2nd Gen)");
            Console.WriteLine("4. iPhone 11");
            Console.WriteLine("5. iPhone XR");
            Console.Write("Enter the model number: ");

            int modelChoice;
            if (int.TryParse(Console.ReadLine(), out modelChoice) && modelChoice >= 1 && modelChoice <= 5)
            {
                string[] models = { "iPhone 13", "iPhone 12", "iPhone SE (2nd Gen)", "iPhone 11", "iPhone XR" };
                string selectedModel = models[modelChoice - 1];

                Console.WriteLine($"You selected {selectedModel}.");
                Console.Write("Do you want to purchase this model? (yes/no): ");
                string purchaseChoice = Console.ReadLine();

                if (purchaseChoice.ToLower() == "yes")
                {
                    UpgradeDevice();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void UpgradeDevice()
        {
            Console.WriteLine("Upgrade Device");
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Choose an iPhone model to upgrade to:");
            Console.WriteLine("1. iPhone 13");
            Console.WriteLine("2. iPhone 12");
            Console.WriteLine("3. iPhone SE (2nd Gen)");
            Console.WriteLine("4. iPhone 11");
            Console.WriteLine("5. iPhone XR");
            Console.Write("Enter the model number: ");

            int modelChoice;
            if (int.TryParse(Console.ReadLine(), out modelChoice) && modelChoice >= 1 && modelChoice <= 5)
            {
                string[] models = { "iPhone 13", "iPhone 12", "iPhone SE (2nd Gen)", "iPhone 11", "iPhone XR" };
                string selectedModel = models[modelChoice - 1];

                string upgradeDetails = $"{name}, {phoneNumber}, {selectedModel}";

                // Save upgrade details to a text file
                File.AppendAllText("C:\\Users\\harsh\\OneDrive - New Zealand Skills & Education Group\\Desktop\\NZSE Desktop\\csharp\\MyIdea\\Week-7\\upgradeDetails.txt", upgradeDetails + Environment.NewLine);

                Console.WriteLine("Upgrade details saved successfully!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void DisplayFile(string fileName)
        {
           

                if (File.Exists(fileName))

                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine($"Contents of {fileName}:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                }

                else
                {
                    Console.WriteLine($"{fileName} not found.");
                }
            
            


            /*
                        try
                        {
             if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine($"Contents of {fileName}:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                            
                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.WriteLine($"Error: File not found. {ex.Message}");

                        }
            */
        }
    }
}


            /*
            //...............Time out Exception....................//

            try
            {
                // Simulate an operation that takes longer than the timeout
                Thread.Sleep(5000); // Sleep for 5 seconds
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("TimeoutException: " + ex.Message);
            }
        }
    }
}
            */



/*
//.........................Overflow Exception............................//

int maxInt = int.MaxValue;



try
{
    checked
    {
        int result = maxInt + 1; // This will throw an OverflowException
        Console.WriteLine("Result: " + result);
    } //Because we definied int maxInt = int.MaxValue; and now we want to add 1 more number. 
}
catch (OverflowException ex)
{
    Console.WriteLine("OverflowException: " + ex.Message);
}
}
}
}
*/



// .............. Out of Range Exception................................//
/*

int[] numbers = { 1, 2, 3 };



try
{
    int value = numbers[3]; // This will throw an IndexOutOfRangeException
    Console.WriteLine("Value: " + value);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
}
}
}
}
*/



/*
//................. FormatException........................//
string invalidNumber = "abc";



try
{
    int parsedNumber = int.Parse(invalidNumber);
    Console.WriteLine("Parsed Number: " + parsedNumber);
}
catch (FormatException ex)
{
    Console.WriteLine("FormatException: " + ex.Message);
}
}
}
}
*/



//.................................ArgumentException........................................//

/*
int age = -5;



try
{
    if (age < 0)
    {
        throw new ArgumentException("Age must be a non-negative value.", nameof(age));
    }



    Console.WriteLine("Age: " + age);
}
catch (ArgumentException ex)
{
    Console.WriteLine("ArgumentException: " + ex.Message);
}
}
}
}
*/





/*
       //.................................. Argument null exception...................//
string name = null;



try
{
    if (name == null)
    {
        throw new ArgumentNullException(nameof(name), "Name cannot be null.");
    }



    Console.WriteLine("Hello, " + name);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("ArgumentNullException: " + ex.Message);
}
}
}
}
*/


//.................DivideByZeroExceptio..........................//
/*
 *
try
{
    // Attempt some risky operation
    int result = Divide(10, 0);
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException: " + ex.Message);
}
finally
{
    // This block will always execute, regardless of whether an exception occurred or not
    Console.WriteLine("Finally block executed.");
}
}



static int Divide(int numerator, int denominator)
{
// Attempt to divide, might throw a DivideByZeroException
return numerator / denominator;
}
}
}

*/




//..................................IOException.........................//

/*
{
    FileStream fileStream = null;
    try
    {
        fileStream = File.Open("C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\Programing project for progaming\\even numbers using for loop 0 to 100\firstfile.txt", FileMode.Open);
        // Perform operations with the file
    }
    catch (IOException ex)
    {
        Console.WriteLine("IOException: " + ex.Message);
    }
    finally
    {
        // Ensure the file stream is always closed, even if an exception occurred
        if (fileStream != null)
            fileStream.Close();
    }
}
}
}
}

*/


//..............................Finally block Exception.............................//
/*
                    // Finally block Exception
int numerator = 10;
int denominator = 0;
int result = 0;

try
{
    result = numerator / denominator; // This will throw a DivideByZeroException
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    Console.WriteLine("Finally block executed.");
}
}
}
}
*/

//......................MemoryException....................//

/*
// Out of memory Exception: the length is maxium and can't be allocate. 
// the outpout is out of memory exception: Exception of type ' system.out

try
{
    // Attempt to allocate a very large array to simulate running out of memory
    int[] largeArray = new int[int.MaxValue];
}
catch (OutOfMemoryException ex)
{
    Console.WriteLine("Out of Memory Exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("General Exception: " + ex.Message);
}
}
}
}
*/




//...........................NullException.............................//

/*

// NullException code 

string text = null;

try
{
    // Attempt to get the length of a null string
    int length = text.Length; // This will throw a NullReferenceException
    Console.WriteLine("Length of the string: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Null Reference Exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("General Exception: " + ex.Message);
}
}
}
}
*/

//...........................IOException............................................//

/*
// IO Exception is for inpuy and output
// The blew program is to read the file path and if not found then output the I/O exception
string filePath = "C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\Programing project for progaming\\firstfile.txt";

try
{
    // Attempt to read from a file that does not exist
    using (StreamReader reader = new StreamReader(filePath))
    {
        string content = reader.ReadToEnd();
        Console.WriteLine("File Content: " + content);
    }
}
catch (IOException ex)
{
    Console.WriteLine("I/O Exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("General Exception: " + ex.Message);
}
}
}
}

*/

//............................Filepath not found Exception..........................................//


/*
try
{
    Console.Write("Enter the path of a text file: ");
    string filePath = Console.ReadLine();

    // Attempt to read and display the contents of the file
    string fileContents = File.ReadAllText(filePath);

    Console.WriteLine("File Contents:");
    Console.WriteLine(fileContents);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: File not found. {ex.Message}");
}

//.............................................................................
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Error: Unauthorized access. {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Error: Input/output error. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

Console.WriteLine("Program finished.");
}
}

}

*/
