//// 1.1. Uzdevums

//Console.Write("Ievadiet taisnstūra garumu: ");
//int length = Convert.ToInt32(Console.ReadLine());
//int loop = 1;

//while (loop < length)
//{
//    var i = loop;
//    while (i > 0)
//    {
//        Console.Write("*");
//        i--;
//    }
//    Console.WriteLine();
//    loop++;
//}




//// 1.2. Uzdevums

//string password = "Rudens20XX";
//string input = "";

//while (input != password)
//{
//    Console.Write("Ievadiet paroli: ");
//    input = Console.ReadLine();

//    if (input == password)
//    {
//        Console.WriteLine("Parole ir ievadīta pareizi");
//    } else
//    {
//        Console.WriteLine("Parole ir ievadīta nepareizi!");
//    }
//}




//// 1.3. Uzdevums

//Console.Write("Ievadiet skatili R: ");
//int length = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ievadiet pirmo skaitli: ");
//int multiplier = Convert.ToInt32(Console.ReadLine());

//int i = 0;

//do
//{
//    Console.Write("Reiz[" + i + "] = " + multiplier + "*");
//    int multiplicand = Convert.ToInt32(Console.ReadLine());
//    multiplier = multiplier * multiplicand;
//    i++;
//} while (i < length);

//Console.WriteLine("Reiz[" + i + "] = " + multiplier);




//// 2.1 Uzdevums

//int num = 0;
//int input = 0;
//do
//{
//    Console.Write("Ievadiet pozitivu skaitli: ");
//    input = Convert.ToInt32(Console.ReadLine());
//} while (input <= 0);

//Console.WriteLine("Skaitļa kvadrāts ir: " + (input * input));




//// 2.2 Uzdevums

//string input = "";

//while (input != "0")
//{
//    Console.Write("Ievadiet skaitli (0 lai beigtu): ");
//    input = Console.ReadLine();

//    if (input != "0")
//    {
//        Console.WriteLine("Skaitlim " + input + " ir " + input.Length + " cipari.");
//    } 
//}




//// 2.3 Uzdevums

//Console.Write("Ievadiet pozitīvu vesalu skatili: ");
//int input = Convert.ToInt32(Console.ReadLine());
//int factorial = 1;

//while (input > 0)
//{
//    factorial *= input;
//    input--;
//}

//Console.WriteLine("Skaitla " + input + " faktorials ir " + factorial);




// 2.4 Uzdevums NAV




//// 2.5 Uzdevums

//Console.Write("Ievadiet skaitli N: ");
//int input = Convert.ToInt32(Console.ReadLine());
//int inputSaved = input;
//int sum = 0;

//while (input > 0)
//{
//    if (input % 2 == 0)
//    {
//        sum += input;
//    }
//    input--;
//}

//Console.WriteLine("Pāra skaitļu summa līdz " + inputSaved + " ir " + sum);




//// 2.6 Uzdevums

//int sum = 0;

//do
//{
//    Console.Write("Ievadiet skaitli: ");
//    int input = Convert.ToInt32(Console.ReadLine());
//    sum += input;
//} while (sum < 100);

//Console.WriteLine("Ievadito skaitlu summa ir " + sum + " (>= 100)");




////// 2.7 Uzdevums

//bool isPrime = false;

//while (!isPrime)
//{
//    Console.Write("Ievadiet pozitīvu vesalu skaitli: ");
//    int input = Convert.ToInt32(Console.ReadLine());
//    int divisor = input - 1;

//    if (divisor > 1)
//    {
//        isPrime = true;

//        while (divisor > 1)
//        {
//            if (input % divisor == 0)
//            {
//                isPrime = false;
//            }
//            divisor--;
//        }
//    }

//    if (isPrime)
//    {
//        Console.WriteLine("Skaitlis " + input + " ir pirmskaitlis");
//    }
//    else
//    {
//        Console.WriteLine("Skaitlis " + input + " nav pirmskaitlis");
//    }
//}