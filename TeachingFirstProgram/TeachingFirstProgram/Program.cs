//// See https://aka.ms/new-console-template for more information

////example of a generic variable
//using TeachingFirstProgram;

//var variable = "Hello world";

////example of variable types
//char charVar = 'c'; //Char = a single character
//string stringVar = "string"; //String = a collection of characters pieced together
//int intVar = 10; //Integer = a whole number
//float floatVar = 1.2f; //Float = floating-point number (aka a whole number that has a decimal)
//double doubleVar = 1.2; //Double = double-precision floating-point number (aka a whole number that has a decimal)
//decimal decimalVar = 1.2M; //Decimal = decimal number
//bool boolVar = false; //Bool = a boolean (true or false)

////example of writing to the console
//Console.WriteLine(variable);

////example of parsing values and reading values
//string input = Console.ReadLine();
//bool isInt = int.TryParse(input, out int value);

////example of if, else if and else
//if (isInt)
//{
//    Console.WriteLine("Your input was an integer: " + value);
//}
//else if (string.IsNullOrEmpty(input))
//{
//    Console.WriteLine("Your input was empty!");
//}
//else
//{
//    Console.WriteLine("Your input was: " + input);
//}

////example of loops
//bool whileLoopBool = true;
//while (whileLoopBool) //This will loop unless whatever the condition is = false. This means if there was an int x = 2 and the while loop condition is (x == 2) then it will loop until x is changed
//{
//    var ans = Console.ReadLine();
//    if (string.IsNullOrEmpty(ans))
//    {
//        break; //Can use break or set the value of whileLoopBool to = false
//    }
//}

//int forLoopInt = 10;
//for (int i = 0; i < forLoopInt; i++) //The variable i is declared here, the loop condition is then set after and then what happens to i is set afterwards.
//{
//    Console.WriteLine(i); //As shown on the console i is incremented each time it loops through.
//}

//bool doWhileBool = false;
//do //The functionality in this loop will run once always.
//{
//    Console.WriteLine("This loop ran at least once");
//} while (doWhileBool); //The condition of the loop will be checked only after the functionality within the loop has run once. The condition must be true for it to loop again.

//Next stage is basic methods
//Exercise is using basic methods and the new variables and functionalities to make a simple calculator

//Next stage is learning Lists, Arrays, Dictionaries and ForEach loops
//Exercise is using methods, take in 8 values into a list, order them by ascending in a method and then write them 1 by 1 to the console.

//Dictionary<string, string> pairs = new Dictionary<string, string>() { {"key", "value" }, { "1", "other value" } };
//List<string> strings = new List<string>() { "other", "dumb", "something" };

//var input = Console.ReadLine();
//strings.Add(input);

//foreach (var item in pairs)
//{
//    Console.WriteLine("This item key is: " + item.Key);
//    Console.WriteLine("This item value is: " + item.Value);
//}

//for (int i = 0; i < strings.Count; i++)
//{
//    Console.WriteLine("This item string is: " + strings[i]);
//}

using TeachingFirstProgram;

//List<Animal> animals = new List<Animal>();

//var tiger = new Tiger();
//animals.Add(tiger);

//var kangaroo = new Kangaroo();
//animals.Add(kangaroo);

//foreach (var animal in animals)
//{
//    Console.WriteLine("This animal is a " + animal.name + " and it has " + animal.ammountOfLegs + " legs");
//    Console.WriteLine("make a noise!");
//    animal.MakeANoise();
//}

var something = new Triangle(1.4f, 3.4f);
something.SomethingElse();

var square = new Sqaure(2f, 2f);
square.SomethingElse();