// See https://aka.ms/new-console-template for more information



 //                  Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa

//                                       Task 1


// Console.Write("Birinchi raqamni kiriting: ");
        // double num1 = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Amalni kiriting (+, -, *, /): ");
        // string operation = Console.ReadLine();

        // Console.Write("Ikkinchi raqamni kiriting: ");
        // double num2 = Convert.ToDouble(Console.ReadLine());

        // double result = 0;

        // switch (operation)
        // {
        //     case "+":
        //         result = num1 + num2;
        //         break;

        //     case "-":
        //         result = num1 - num2;
        //         break;

        //     case "*":
        //         result = num1 * num2;
        //         break;

        //     case "/":
        //         if (num2 != 0)
        //             result = num1 / num2;
        //         else
        //         {
        //             Console.WriteLine("Nolga bo'lish mumkin emas!");
        //             return;
        //         }
        //         break;

        //     default:
        //         Console.WriteLine("Noto'g'ri amal kiritildi!");
        //         return;
        // }

        // Console.WriteLine($"Natija: {result}");
    


//                                       Task 2



//         Console.Write("Musbat butun sonni kiriting (N): ");
//         int N = Convert.ToInt32(Console.ReadLine());

//         int sum = 0;
        
//         for (int i = 1; i <= N; i++)
//         {
//             sum += i;
//         }

//         Console.WriteLine($"1 dan {N} gacha bo'lgan sonlar yig'indisi: {sum}");




//   Console.Write("Raqamni kiriting: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         // Paritetni tekshirish
//         string result = (number % 2 == 0) ? "Juft" : "Toq";

//         Console.WriteLine(result);


//                                       Task 3


        // Console.Write("Raqamni kiriting: ");
        // int number = int.Parse(Console.ReadLine());

        // string result = (number % 2 == 0) ? "Juft" : "Toq";
        // Console.WriteLine(result);




         //  //                Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa


//                                       Task 1



    //     Console.Write("Sonni kiriting: ");
    //     if (int.TryParse(Console.ReadLine(), out int number))
    //     {
    //         if (number > 1 && IsPrime(number))
    //         {
    //             Console.WriteLine("Tub");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Tub emas");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Xato: Iltimos, butun son kiriting!");
    //     }
    

    // static bool IsPrime(int num)
    // {
    //     for (int i = 2; i <= Math.Sqrt(num); i++)
    //     {
    //         if (num % i == 0)
    //             return false;
    //     }
    //     return true;
    // }



//                                       Task 2


        // Console.Write("Sonni kiriting: ");
        // if (int.TryParse(Console.ReadLine(), out int number))
        // {
        //     Console.WriteLine("Bo'luvchilar:");
        //     for (int i = 2; i <= 10; i++)
        //     {
        //         if (number % i == 0)
        //             Console.WriteLine(i);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Xato: Iltimos, butun son kiriting!");
        // }
    



//                                       Task 3

        // Console.Write("Sonni kiriting: ");
        // if (int.TryParse(Console.ReadLine(), out int baseNumber))
        // {
        //     Console.Write("Darajani kiriting (musbat butun son): ");
        //     if (int.TryParse(Console.ReadLine(), out int power) && power >= 0)
        //     {
        //         double result = Math.Pow(baseNumber, power);
        //         Console.WriteLine($"Natija: {result}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Xato: Daraja musbat butun son bo'lishi kerak!");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Xato: Iltimos, butun son kiriting!");
        // }


//                                       Task 4


// Console.WriteLine("Harajat miqdorlarini vergul bilan ajratib kiriting (masalan: 150, 230, 80, 120): ");
//         string input = Console.ReadLine();

//         try
//         {
//             // Vergul bilan ajratilgan ma'lumotlarni sonlarga aylantirish
//             int[] amounts = input.Split(',')
//                                  .Select(x => int.Parse(x.Trim()))
//                                  .ToArray();

//             // Yig'indini hisoblash
//             int total = amounts.Sum();

//             Console.WriteLine($"Yig'indi: {total}");
//         }
//         catch
//         {
//             Console.WriteLine("Xato: Faqat raqamlarni kiriting va ularni vergul bilan ajrating!");
//         }


// //                                       Task 5


// Console.Write("Sonni kiriting: ");
//         if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
//         {
//             if (IsArmstrong(number))
//             {
//                 Console.WriteLine($"{number} Armstrong son");
//             }
//             else
//             {
//                 Console.WriteLine($"{number} Armstrong son emas");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Xato: Iltimos, musbat butun son kiriting!");
//         }
    

//     static bool IsArmstrong(int num)
//     {
//         string digits = num.ToString(); // Sonni qatorga aylantirish
//         int power = digits.Length; // Son raqamlarining o'lchami
//         int sum = 0;

//         foreach (char digit in digits)
//         {
//             int d = int.Parse(digit.ToString()); // Har bir raqamni ajratib olish
//             sum += (int)Math.Pow(d, power); // Raqamni o'lcham darajasiga ko'tarib qo'shish
//         }

//         return sum == num;
//     }



//                                       Task 6

        Console.Write("Sonni kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            int count = CountProperDivisors(number);
            Console.WriteLine($"Sifatli bo'luvchilar soni: {count}");
        }
        else
        {
            Console.WriteLine("Xato: Iltimos, musbat butun son kiriting!");
        }