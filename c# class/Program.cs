// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

//double a = 20000;
//double b = 40000;
//int formula;
//int a_convert = Convert.ToInt32(a);
//int b_convert = Convert.ToInt32(b);
//formula = a_convert*a_convert + b_convert*b_convert + 2*a_convert*b_convert;
//Console.WriteLine(formula);
//Console.Write(formula);


//string c = "500";

//int convert = Convert.ToInt32(c);

//Console.WriteLine(convert);


//double pie = 3.142;

//Console.WriteLine("Please enter the value of radius");

//int r = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the value of height");

//int h = Convert.ToInt32(Console.ReadLine());

//double cylinder;

//cylinder = pie * r * r * h;
//Console.WriteLine("The value of cylinder is =" + cylinder);

//Console.WriteLine("value of centigrade");
//double cent = Convert.ToInt32(Console.ReadLine());
//double answer;

//answer = cent + 273;
//Console.WriteLine(answer);

//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your age");
//int age =Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Enter your Gender");
//char gender = Convert.ToChar( Console.ReadLine());

//Console.WriteLine("Enetr your Salary");
//double salary = Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Your Name is : " + name);
//Console.WriteLine("Your Age is : " + age);
//Console.WriteLine("Your Gender is : " + gender);
//Console.WriteLine("Your Salary is : " + salary);

//Console.WriteLine("Enter your City");
//string city = Console.ReadLine();

//Console.WriteLine("Enter your Age");
//int age =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Pakistani Rupee");
//decimal pkr = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("What currency to convert to?");
//string currency = Console.ReadLine();

//decimal dollar = 270;

//decimal euro = 301;

//decimal ind = 3;

//decimal riyal = 74;

//if (currency == "dollar")
//{
//    decimal d_to_pak = pkr / dollar;
//    Console.WriteLine("Pakistani Rupee convert to Dollar (" + d_to_pak + ")");
//}
//else if (currency == "euro")
//{
//    decimal e_to_pak = pkr / euro;
//    Console.WriteLine("Pakistani Rupee convert to Euro (" + e_to_pak + ")");
//}
//else if (currency == "indian")
//{
//    decimal i_to_pak = pkr / ind;
//    Console.WriteLine("Pakistani Rupee convert to Indian Rupee (" + i_to_pak + ")");
//}
//else if (currency == "riyal")
//{
//    decimal r_to_pak = pkr / riyal;
//    Console.WriteLine("Pakistani Rupee convert to Riyal (" + r_to_pak + ")");
//}
//else
//{
//    Console.WriteLine("Something went wrong 'try again'");
//};

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//switch(num)
//{
//    case 10:
//        Console.WriteLine("your number is 10");
//        break;
//    case 20:
//        Console.WriteLine("your number is 20");
//        break;
//    case 30:
//        Console.WriteLine("your number is 30");
//        break;
//    default:
//        Console.WriteLine("enter only 10, 20, 30");
//        break;

//}

//Console.WriteLine("USA Coffee Shop");

//int Coffee_Cost = 0;

//Start:

//Console.WriteLine("Select your Coffee Cup Size");
//Console.WriteLine("1-Small , 2-Medium , 3-Large");

//int Cup_Size = int.Parse(Console.ReadLine());

//switch(Cup_Size)
//{
//    case 1:
//        Coffee_Cost += 50;
//        break;

//    case 2:
//        Coffee_Cost += 100;
//        break;

//    case 3:
//        Coffee_Cost += 150;
//        break;

//    default:
//        Console.WriteLine("Your choice {0} is Invalid", Cup_Size);
//        goto Start;
//}

//Decide:;

//Console.WriteLine("Do you want to buy another Coffee - {Yes or No}");
//String Decision = Console.ReadLine();

//switch(Decision.ToUpper())
//{
//    case "YES":
//        goto Start;

//    case "NO":
//        break;

//    default:
//        Console.WriteLine("Your Choice {0} is Invalid Try Again ", Decision);
//        goto Decide;
//}

//Console.WriteLine("Thankyou for shopping with us");
//Console.WriteLine("Bill Amount = ${0}", Coffee_Cost);

//Console.ReadKey();

//Console.WriteLine("Table of 2");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("2 * " + i + " = " + 2 * i);
//}

//Console.WriteLine("Even or Odd Numbers");

//for (int a = 1; a <= 50; a++)
//{
//    if(a % 2 == 0)
//    {
//        Console.WriteLine(a + " is Even Number");
//    }
//    else
//    {
//        Console.WriteLine(a + " is Odd Number");
//    }
//}

//Console.WriteLine("WHILE LOOP");

//Console.WriteLine("Please enter your Age");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your pocket money");
//int counter = int.Parse(Console.ReadLine());

//while  (counter <= 850 && age>=18)
//{
//    Console.WriteLine(counter);
//    counter = counter + 1;
//}

//Console.WriteLine("WHILE LOOP WITH if else condition");

//int i, cus;

//Console.WriteLine("Let's play the game");
//Console.WriteLine("You have only 3 attempts");
//int a = 0;
//i = 13;
//cus = 0;


//while (i != cus && a != 4)
//{
//    if(a==4)
//    {

//        Console.WriteLine( "you exceed the limit" );

//    }
//    Console.WriteLine("Enter the number between 1 to 20");
//    cus = Convert.ToInt32(Console.ReadLine());

//    else if (cus < i )
//    {



//        Console.WriteLine("Number is too low");
//    }
//    else if (cus > i )
//    {



//        Console.WriteLine("Number is too high");
//    }
//    else
//    {
//        Console.WriteLine("Congratulations! You won the Game");
//        break;
//    }


//    a++;


//}

//Console.WriteLine("Sorry! you failed");

//string userChoice = string.Empty;

//do
//{
//    Console.WriteLine("enter your target?");
//    int userTarget = int.Parse(Console.ReadLine());

//    int counter = 10;
//    //Console.WriteLine("tra again");

//    while(counter<=userTarget)
//    {
//        Console.WriteLine(counter + " ");
//        counter = counter + 1;
//    }
//    do
//    {
//        Console.WriteLine("Do you want to continue - Yes or No?");
//        userChoice = Console.ReadLine().ToUpper();
//    }
//    while (userChoice != "YES" && userChoice != "NO");

//}
//while (userChoice == "YES");


Console.WriteLine("Array and array with for each and for loop");

//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(i + " . " + a[i]);
//}


//foreach (int i in a)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine(a[4]);


//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(a[6]);
//}


//int[] myarray = new int[6];
//myarray[0] = 1;
//myarray[1] = 2;
//myarray[2] = 3;
//myarray[3] = 4;
//myarray[4] = 5;
//myarray[5] = 6;

//foreach (int i in myarray)
//{
//    Console.WriteLine(i);
//}


//int[] myarray = new int[3];

//Console.WriteLine("enter the value of array");
//for (int i = 0; i < myarray.Length; i++)
//{
//    myarray[i] = Convert.ToInt32(Console.ReadLine());

//}

//Array.Sort(myarray);
//Array.Reverse(myarray);

//foreach (int i in myarray)
//{
//    Console.WriteLine("Output " + i);
//}

Console.WriteLine("2-DIMENSIONAL ARRAY");

int[,] a = new int[4,4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };


for (int i = 0; i < 4;  i++)
{
    Console.WriteLine("Row : " + i) ;
    for(int j = 0; j < 4; j++)
    {
        Console.WriteLine("Column : " + j);
        Console.WriteLine("Elements of 2d-Array : " + a[i, j]);
    }
}
