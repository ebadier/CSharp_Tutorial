﻿// This is how we import required libraries in C#
using System;
using System.Collections.Generic;
using System.IO;

namespace BasicsProg
{
	class Program
	{
		// 1. This function is the entry point of the program.
		// static means it can be called without the need to instantiate an object of type Program.
		static void Main(string[] args)
		{
			// args is an array of all arguments coming from the command line.
			// to pass some parameters to the application.

			// 2. Write some text to the console.
			Console.WriteLine("Hello World!");
			// Tests
			//VariablesTest();
			//StringTest();
			//OperationsTest();
			//ConditionalsTest();
			//ArrayTest();
			//ListTest();
			//DictionnaryTest();
			//LoopsTest();
			//MethodsTest();
			//FileTest();
			//ClassTest();

			WaitForQuit();
		}

		// 3. Our first function
		static void WaitForQuit()
		{
			Console.WriteLine("Press Enter to quit...");
			// Read input text from the console while Enter is not pressed.
			Console.ReadLine();
		}

		// 4. Variables & Types
		static void VariablesTest()
		{
			// LESSONS LEARN:
			// - Take care of overflow
			// - Make operations using the same type of variables as possible to not lose precision.
			Console.WriteLine("====Variables Test====");
			// These are variables.
			byte myByte = byte.MaxValue; // 255
			Console.WriteLine("myByte : " + myByte);
			int myInt = int.MinValue;
			Console.WriteLine("myInt : " + myInt);
			float myFloat = 1.3f;
			Console.WriteLine("myFloat : " + myFloat);
			bool myBoolean = true;
			Console.WriteLine("myBoolean : " + myBoolean);
			string myName = "John";
			Console.WriteLine("myName : " + myName);
			char myChar = 'a';
			Console.WriteLine("myChar : " + myChar);
			double myDouble = 1.75;
			Console.WriteLine("myDouble : " + myDouble);

			// EXERCISE : DEFINE THREE VARIABLES:
			// A string named productName equal to TV.
			string productName = "TV";
			// An integer named productYear equal to 2021.
			int productYear = 2021;
			// A float named productPrice equal to 499.99f.
			float productPrice = 499.99f;
		} // All variables are destroyed here (end of scope).

		// 5. String operations
		static void StringTest()
		{
			// Declare string and assign a value.
			Console.WriteLine("====String Test====");
			string myString = "A string.";
			Console.WriteLine("myString : " + myString);
			// Empty string
			string emptyString = String.Empty;
			Console.WriteLine("emptyString : " + emptyString);
			string anotherEmptyString = "";
			Console.WriteLine("anotherEmptyString : " + anotherEmptyString);
			// Concatenation
			string firstName = "John";
			string lastName = "Smith";
			string fullName = firstName + " " + lastName;
			Console.WriteLine("fullName : " + fullName);
			string sentence = "I like to play ";
			sentence += "chess.";
			Console.WriteLine("sentence : " + sentence);
			// String Substring
			string sentence2 = sentence.Substring(1);
			Console.WriteLine("sentence2 : " + sentence2);
			sentence2 = fullName + sentence2;
			Console.WriteLine("sentence2 : " + sentence2);
			// Search
			int cPos = sentence2.IndexOf('c');
			// Remove chess. from sentence2.
			sentence2 = sentence2.Substring(0, cPos-1) + '.';
			Console.WriteLine("sentence2 : " + sentence2);
			// Replace
			sentence2 = sentence2.Replace("Smith", "Carter");
			Console.WriteLine("sentence2 : " + sentence2);
			// string formating
			string numbers = string.Format("Numbers : {0} ; {1} ; {2}", 1, 2, 3);
			Console.WriteLine("numbers : " + numbers);

			// EXERCISE
			// Use string formatting to format the variables firstName, lastName to form the following sentence:
			// John Smith is 27 years old.
			string result = string.Format("{0} {1} is {2} years old.", firstName, lastName, 27);
			Console.WriteLine("result : " + result);
		}

		// 6. Operations
		static void OperationsTest()
		{
			Console.WriteLine("====Operations Test====");
			byte myByte = byte.MaxValue; // 255
			Console.WriteLine("myByte : " + myByte);
			int myInt = int.MinValue;
			Console.WriteLine("myInt : " + myInt);
			float myFloat = 1.3f;
			Console.WriteLine("myFloat : " + myFloat);
			bool myBoolean = true;
			Console.WriteLine("myBoolean : " + myBoolean);
			string myName = "John";
			Console.WriteLine("myName : " + myName);
			char myChar = 'a';
			Console.WriteLine("myChar : " + myChar);
			double myDouble = 1.75;
			Console.WriteLine("myDouble : " + myDouble);

			// Take care to never overflow the min & max theoric value of any type !!!
			// The majority of program bugs & computation errors come from overflow.
			Console.WriteLine("====Overflow Test====");
			myByte += 3;
			Console.WriteLine("myByte + 3 : " + myByte);
			myInt -= 3;
			Console.WriteLine("myInt - 3 : " + myInt);

			// Basic Operations.
			Console.WriteLine("====Operations Test====");
			int x = 3;
			int y = 10;
			Console.WriteLine(string.Format("x = {0} ; y = {1}", x, y));
			int sum = x + y;
			Console.WriteLine("X + Y = " + sum);
			int diff = x - y;
			Console.WriteLine("X - Y = " + diff);
			int product = x * y;
			Console.WriteLine("X * Y = " + product);
			int quotient = x / y; // integral types truncate the result by default.
			Console.WriteLine("X / Y = " + quotient);
			int remainder = x % y; // the remainder of the division.
			Console.WriteLine("X % Y = " + remainder);

			// Conversions
			Console.WriteLine("====Conversion Test====");
			// We can convert a float to a double directly (32 bits => 64 bits).
			double myFloatAsDouble = myFloat;
			Console.WriteLine("myfloat as double : " + myFloatAsDouble);
			// We can convert a double to a float using a cast (64 bits => 32 bits).
			float myDoubleAsFloat = (float)myDouble; // cast is mandatory because this conversion is dangerous.
			Console.WriteLine("myDouble as float : " + myDoubleAsFloat);
			// We can convert float to int but we will lose the accuracy. (32 bits => 32 bits)
			int myFloatAsInt = (int)myFloat; // cast is mandatory because this conversion is not trivial.
			Console.WriteLine("myFloat as int : " + myFloatAsInt);
			Console.WriteLine("myFloat as int (floor) : " + Math.Floor(myFloat));
			Console.WriteLine("myFloat as int (ceiling) : " + Math.Ceiling(myFloat));
			Console.WriteLine("myFloat as int (rounding) : " + Math.Round(myFloat));
			// EXERCISE : convert double to int.
			// This conversion is dangerous and we will lose the accuracy. (32 bits => 64 bits)
			int myDoubleAsInt = (int)myDouble; // cast is mandatory because this conversion is not trivial.
			Console.WriteLine("myDouble as int : " + myDoubleAsInt);
			Console.WriteLine("myDouble as int (floor) : " + Math.Floor(myDouble));
			Console.WriteLine("myDouble as int (ceiling) : " + Math.Ceiling(myDouble));
			Console.WriteLine("myDouble as int (rounding) : " + Math.Round(myDouble));
			// IS THERE ANY DIFFERENCE BETWEEN FLOAT TO INT AND DOUBLE TO INT CONVERSIONS ?

			// Here C# converts automatically res to a double (= the largest of the two operands types).
			var res = myFloat + myDouble;
			Console.WriteLine("(myFloat + myDouble) as double : " + res);
			// The second result is more accurate because we use the same type for both operands.
			float res2 = myFloat + 1.75f;
			Console.WriteLine("(myFloat + 1.75f) : " + res2);
			// Use Convert to keep precision.
			float res3 = myFloat + Convert.ToSingle(myDouble);
			Console.WriteLine("(myFloat + Convert.ToSingle(myDouble)) : " + res3);

			// String to number test
			string myStringNum = "10";
			int myNum = int.Parse(myStringNum);
			Console.WriteLine("myNum from String : " + myNum);

			// EXERCISE : Cast sum/diff/product/quotient/remainder to float.
			float sumAsFloat = (float)sum;
			Console.WriteLine("sumAsFloat : " + sumAsFloat);
			float diffAsFloat = (float)diff;
			Console.WriteLine("diffAsFloat : " + diffAsFloat);
			float quotientAsFloat = (float)quotient;
			Console.WriteLine("quotientAsFloat : " + quotientAsFloat);
			float remainderAsFloat = (float)remainder;
			Console.WriteLine("remainderAsFloat : " + remainderAsFloat);
			// How to get the accurate value of quotient ?
			float accurateQuotient = (float)x / (float)y;
			Console.WriteLine("accurateQuotient : " + accurateQuotient);
		}

		// 7. Conditions
		static void ConditionalsTest()
		{
			Console.WriteLine("====Boolean Test====");
			int a = 4;
			int b = 5;
			Console.WriteLine(string.Format("a = {0} ; b = {1}", a, b));
			bool result;
			result = a < b; // true
			Console.WriteLine("a < b : " + result);
			result = a > b; // false
			Console.WriteLine("a > b : " + result);
			result = a <= 4; // a smaller or equal to 4 - true
			Console.WriteLine("a <= 4 : " + result);
			result = b >= 6; // b bigger or equal to 6 - false
			Console.WriteLine("b >= 6 : " + result);
			result = a == b; // a equal to b - false
			Console.WriteLine("a == b : " + result);
			result = a != b; // a is not equal to b - true
			Console.WriteLine("a != b : " + result);
			result = a > b || a < b; // Logical or - true
			Console.WriteLine("a > b || a < b : " + result);
			result = 3 < a && a < 6; // Logical and - true
			Console.WriteLine("3 < a && a < 6 : " + result);
			result = !result; // Logical not - false
			Console.WriteLine("!result : " + result);

			Console.WriteLine("====If/Else Test====");
			// Simple If
			if (a != b)
			{
				Console.WriteLine("a != b");
			}

			// If/Else
			if(a==b)
			{
				// Sorry this is not true.
			}
			else
			{
				Console.WriteLine("Again : a != b");
			}

			// If/Else if/Else
			// You can add as many Else if as you want.
			if (a==b)
			{
				// Sorry this is not true.
			}
			else if(a==6)
			{
				// Sorry this is not true.
			}
			else
			{
				Console.WriteLine("Sorry, nothing is true");
			}

			// Switch
			Console.WriteLine("====Switch Test====");
			int c = b;
			switch(c)
			{
			case 4: Console.WriteLine("c=4"); break;
			case 5: Console.WriteLine("c=5"); break;
			default: Console.WriteLine("c=" + c); break;
			}

			// EXERCISE
			// In this exercise, you must construct an if statement that checks if the number guess is equal to 500.
			// If that is the case, use Console.WriteLine to display "You Win!" or "You Loose !".
			Console.WriteLine("Guess the number ? (you have only one chance)");
			string text = Console.ReadLine();
			if (text == "500")
			{
				Console.WriteLine("You Win !");
			}
			else
			{
				Console.WriteLine("You Loose !");
				Console.WriteLine("The number was 500");
			}
		}

		// 8. Arrays
		static void ArrayTest()
		{
			Console.WriteLine("====Array Test====");
			// Define an array.
			// Size of an array is fixed.
			// To change the size of an array you need to create a new array.
			int[] nums = { 1, 2, 3, 4, 5 };
			int first = nums[0]; // zero based index.
			int second = nums[1];
			int third = nums[2];
			int fourth = nums[3];
			int fifth = nums[4];
			// Out of range.
			//int sixth = nums[5]; 
			Console.WriteLine(string.Format("nums : {0} ; {1} ; {2} ; {3} ; {4}", first, second, third, fourth, fifth));
			third = nums[2] = 10;
			Console.WriteLine("nums[2] = 10;");
			Console.WriteLine(string.Format("nums : {0} ; {1} ; {2} ; {3} ; {4}", first, second, third, fourth, fifth));

			// Define an empty array of size 10.
			// New is a keyword to allocate memory. Here we ask to allocate 10 x 32 bits.
			// The garbage collector will free this allocated memory automatically when the array object will not be used anywhere (at the end of the ArrayTest method in this situation).
			int[] nums2 = new int[10];
			Console.WriteLine("nums2 length : " + nums2.Length);

			Console.WriteLine("====Multidimensional Array Test====");
			// Declare a matrix.
			int[,] matrix = new int[2, 3];
			// Then fill it.
			matrix[0, 0] = 1;
			matrix[0, 1] = 2;
			matrix[0, 2] = 3;
			matrix[1, 0] = 4;
			matrix[1, 1] = 5;
			matrix[1, 2] = 6;
			// Declare and fill at the same time.
			int[,] predefinedMatrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
			Console.WriteLine("predefinedMatrix dimensions : {0} x {1}", predefinedMatrix.GetLength(0), predefinedMatrix.GetLength(1));
			Console.WriteLine("predefinedMatrix[1, 2] : " + predefinedMatrix[1, 2]);

			Console.WriteLine("====Jagged Array Test====");
			// Jagged Arrays are multidimensional arrays where each subarray is an independent array.
			// It can have subarrays of different lengths.
			// Use a separate set of square brackets for each dimension of the array.
			int[][] jaggedArray = new int[3][];
			jaggedArray[0] = new int[] { 10, 20, 30 };
			jaggedArray[1] = new int[] { 40, 50, 60, 70 }; 
			jaggedArray[2] = new int[] { 80, 90, 100, 110, 120 };
			Console.WriteLine("jaggedArray[2, 4] : " + jaggedArray[2][4]);
			//Console.WriteLine("jaggedArray[2, 4] : " + jaggedArray[1][4]); // out of range.

			// EXERCISE : Define an array called fruits that holds the following strings: "apple", "banana", and "orange".
			string[] fruits = { "apple", "banana", "orange" };
		}

		// 9. Lists
		static void ListTest()
		{
			// Lists are Arrays with the possibility to change the size dynamically.
			Console.WriteLine("====List Test====");
			List<int> nums = new List<int>();
			// Adds some numbers to the list using Add().
			nums.Add(1);
			nums.Add(2);
			nums.Add(3);
			Console.WriteLine(string.Format("nums : {0} ; {1} ; {2}", nums[0], nums[1], nums[2]));
			Console.WriteLine(string.Format("nums has {0} elements.", nums.Count));
			// Adds an array of numbers to the list directly with AddRange().
			int[] array = { 4, 5, 6};
			nums.AddRange(array);
			Console.WriteLine(string.Format("nums : {0} ; {1} ; {2} ; {3} ; {4} ; {5}", nums[0], nums[1], nums[2], nums[3], nums[4], nums[5]));
			Console.WriteLine(string.Format("nums has {0} elements.", nums.Count));

			// List of string
			List<string> fruits = new List<string>();
			// add fruits
			fruits.Add("apple");
			fruits.Add("banana");
			fruits.Add("orange");
			Console.WriteLine(string.Format("fruits : {0} ; {1} ; {2}", fruits[0], fruits[1], fruits[2]));
			Console.WriteLine(string.Format("fruits has {0} elements.", fruits.Count));
			// Remove
			fruits.Remove("banana");
			Console.WriteLine("banana removed.");
			Console.WriteLine(string.Format("fruits has {0} elements.", fruits.Count));
			fruits.Add("banana");
			Console.WriteLine("banana is back.");
			Console.WriteLine(string.Format("fruits has {0} elements.", fruits.Count));
			// RemoveAt
			fruits.RemoveAt(0);
			Console.WriteLine("apple removed.");
			Console.WriteLine(string.Format("fruits has {0} elements.", fruits.Count));
			Console.WriteLine(string.Format("fruits : {0} ; {1}", fruits[0], fruits[1]));

			// Concatenation.
			List<string> vegetables = new List<string>();
			vegetables.Add("tomato");
			vegetables.Add("carrot");
			Console.WriteLine(string.Format("vegatables : {0} ; {1}", vegetables[0], vegetables[1]));
			List<string> food = new List<string>();
			food.AddRange(fruits);
			food.AddRange(vegetables);
			Console.WriteLine("food : {0} ; {1} ; {2} ; {3}", food[0], food[1], food[2], food[3]);

			// Search
			int tomatoIndex = food.IndexOf("tomato");
			if(tomatoIndex != -1)
			{
				Console.WriteLine("tomato found at index : " + tomatoIndex);
			}

			// EXERCISE : Construct a list of the first 5 prime numbers(2, 3, 5, 7, 11) called primeNumbers
			List<int> primeNumbers = new List<int>();
			primeNumbers.AddRange(new int[]{ 2, 3, 5, 7, 11 });
		}

		// 10. Dictionnaries
		static void DictionnaryTest()
		{
			Console.WriteLine("====Dictionnary Test====");
			// A Dictionnary store pairs [Key, Value]
			// Duplicate keys are not allowed.
			Dictionary<string, long> phonebook = new Dictionary<string, long>();
			// Adds a pair.
			phonebook.Add("Alex", 4154346543);
			Console.WriteLine("Alex's number is " + phonebook["Alex"]);
			// Another way to add a pair.
			// This method adds a pair if key not already exists.
			phonebook["Jessica"] = 4159484588;
			Console.WriteLine("phonebook has {0} elements.", phonebook.Count);
			//phonebook.Add("Alex", 0654249543); // Throw an excception : because of duplicate key.
			// Modifying an existing key is allowed.
			phonebook["Alex"] = 4154249543;
			// Search
			if (phonebook.ContainsKey("Alex"))
			{
				Console.WriteLine("Alex's new number is " + phonebook["Alex"]);
			}
			// Another fastest way to search.
			if(phonebook.TryGetValue("Jessica", out long number))
			{
				Console.WriteLine("Jessica's number is " + phonebook["Jessica"]);
			}
			// Remove
			phonebook.Remove("Jessica");
			if (!phonebook.ContainsKey("Jessica"))
			{
				Console.WriteLine("Jessica has been removed");
			}
			Console.WriteLine("phonebook has {0} elements.", phonebook.Count);

			// EXERCISE
			// Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
			// Here is the inventory specification:
			// 3 of type apple
			// 5 of type orange
			// 2 of type banana
			Dictionary<string, int> inventory = new Dictionary<string, int>();
			inventory.Add("apple", 3);
			inventory.Add("orange", 5);
			inventory.Add("banana", 2);
		}

		// 11. Loops
		static void LoopsTest()
		{
			Console.WriteLine("====For Loops Test====");
			// Typical for loop.
			// There's no difference whether to use i++ or ++i here.
			// But ++i is more efficient because it increment directly the value of i.
			// On its side i++ is the same as doing : i += 1 or i = i + 1, so there are 2 operations (a sum + an assignement).
			{
				int i;
				for (i = 0; i < 10; ++i)
				{
					Console.WriteLine("i outside : " + i); // call for i [0;9]
				}
			}// i is destroyed here.

			// C# allows to declare the i variable directly in the for statement.
			for (int i = 0; i < 10; ++i)
			{
				Console.WriteLine("i local to for loop: " + i);
			}

			// Break keyword
			for (int i = 0; i < 16; ++i)
			{
				Console.WriteLine("i (break): " + i);
				if (i == 12)
				{
					break; // break exit the for loop directly
				}
			}

			// Continue keyword
			for (int i = 0; i < 16; ++i)
			{
				if (i % 2 == 1)
				{
					continue; // continue go directly to the next iteration.
				}
				Console.WriteLine("i (continue): " + i); // this is not called when i % 2 == 1, so only even numbers from 0 to 15 are printed
			}

			// EXERCISE
			// Print the odd numbers from 1 to 999 to the screen.
			for (int i = 0; i < 1000; ++i)
			{
				if (i % 2 == 1)
				{
					Console.WriteLine("odd number : " + i);
				}
			}

			Console.WriteLine("====Foreach Loops Test====");
			int[] array = { 1, 2, 3, 4, 5 };
			// Loop through all the elements of the array
			foreach(int item in array)
			{
				Console.WriteLine("item : " + item);
			}
			// Loop through all the elements of the array
			string[] programming = { "C++", "C#", "Python", "C", "Java", "JavaScript" };
			foreach (string language in programming)
			{
				Console.WriteLine("language : " + language);
			}

			// EXERCISE
			// In this exercise, you must find if "Python" is present in the array programming using a foreach loop.
			bool pythonFound = false;
			foreach (string language in programming)
			{
				if(language == "Python")
				{
					pythonFound = true;
					// Don't need to look further.
					break;
				}
			}
			Console.WriteLine("Python found : " + pythonFound);

			Console.WriteLine("====While Loops Test====");
			int n = 0;
			// Loops while n equals 0.
			while (n < 2)
			{
				Console.WriteLine("n (while): " + n);
				n++;
			}

			// The same here
			n = 0;
			do
			{
				Console.WriteLine("n (do while): " + n);
				n++;
			} while (n < 2);

			// EXERCISE
			// Print programming languages using a while loop.
			n = 0;
			while(n < programming.Length)
			{
				Console.WriteLine("language : " + programming[n++]);
			}

			// Remember while loops are faster than for loops which are faster than foreach loops.
			// Only consider this remark for big computations.
		}

		// 12. Methods
		static void MethodsTest()
		{
			Console.WriteLine("====Methods Test====");
			Console.WriteLine("MethodTest returns : " + IntegerTest());
			Console.WriteLine(string.Format("Multiply({0}, {1}) returns : {2}", 4, 5, Multiply(4, 5)));

			// EXERCISE
			// Create a method which take 2 parameters : an array of integer values & a integer value to look for in the array.
			// The method must return the index of the integer value if found in the array, otherwise it returns -1.
			int[] values = { 1, -2, 3, 44, int.MinValue, 6, 9, int.MaxValue, 101, 56 };
			Console.WriteLine("IndexOf(6) : " + IndexOf(values, 6));

			// EXERCISE
			// What's wrong with the Compute method below.
			// - Naming of Method + variables not informative.
			// - val1 & val2 not initialised.
			// - Algorithm is wrong : val > val1 ; val < val2
			// - default result of 0 in case pValues.Count == 0 or pValues is null.
			// - default value for min & max : pValues[0].
			// - Algorithm can be optimized with : for loop starting from index 1 + else if.
			// - Return value overflow in case pValues contains int.Min & int.Max.
			Console.WriteLine("RangeOfValues(values) : " + RangeOfValues(values));
			Console.WriteLine("RangeOfValues(null) : " + RangeOfValues(null));
		}

		//static int Compute(int[] pValues)
		//{
		//	int val1, val2;
		//	foreach(int val in pValues)
		//	{
		//		if(val1 > val)
		//		{
		//			val1 = val;
		//		}

		//		if(val2 < val)
		//		{
		//			val2 = val;
		//		}
		//	}
		//	return val1 - val2;
		//}

		static int IndexOf(int[] pValues, int pVal)
		{
			for (int i = 0; i < pValues.Length; ++i)
			{
				if (pVal == pValues[i])
				{
					return i; // pVal found
				}
			}
			return -1; // pVal not found.
		}

		static uint RangeOfValues(int[] pValues)
		{
			// Edge case
			if(pValues == null || pValues.Length == 0)
			{
				return 0u;
			}

			int min, max;
			min = max = pValues[0];
			for (int i = 1; i < pValues.Length; ++i)
			{
				if (pValues[i] > max)
				{
					max = pValues[i];
				}
				else if (pValues[i] < min)
				{
					min = pValues[i];
				}
			}
			// Edge case : convert to uint in case int.Max - int.Min.
			return (uint)(max - min);
		}

		// A simple method returning an integer.
		static int IntegerTest()
		{
			return 0;
		}

		// A method returning an integer as the product of its two parameters : a & b.
		static int Multiply(int a, int b)
		{
			return a * b;
		}

		// 13. Class
		string testAttribute = "This works !"; // an attribute of the class Program.
		// Non static methods can only be called from instances of type Program.
		void TestMethod()
		{
			Console.WriteLine("TestMethod called from an object of Type Program.");
		}

		static void ClassTest()
		{
			Console.WriteLine("====Class Test====");
			// Instantiation of an object of type Program.
			Program prog = new Program();
			Console.WriteLine("prog.testAttribute : " + prog.testAttribute); // testAttribute has value "This works !".
			// Modify testAttribute of prog object.
			prog.testAttribute = "This works better !";
			Console.WriteLine("prog.testAttribute : " + prog.testAttribute);
			// Non static method can be called.
			prog.TestMethod();
			// Static method cannot be called from an instance.
			// But we can call static methods directly, like this.
			Program.IntegerTest();
			Console.WriteLine("Program.IntegerTest() : " + Program.IntegerTest());
		}// prog object destroyed here.

		// 14. File
		static void FileTest()
		{
			Console.WriteLine("====File Test====");
			string filepath = "./TestFile.txt";
			string filecontent = "This is my first file.\nAnd I'm proud of it !";
			// Write to file.
			File.WriteAllText(filepath, filecontent);
			// Read the file.
			if(File.Exists(filepath))
			{
				string filename = Path.GetFileName(filepath);
				Console.WriteLine("File \"" + filename + "\" opened successfully:");
				Console.WriteLine(File.ReadAllText(filepath)); // print filecontent to the console.
			}
		}
	}
}
