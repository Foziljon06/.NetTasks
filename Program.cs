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


        Console.Write("Raqamni kiriting: ");
        int number = int.Parse(Console.ReadLine());

        string result = (number % 2 == 0) ? "Juft" : "Toq";
        Console.WriteLine(result)