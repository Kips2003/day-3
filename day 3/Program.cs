// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};

        
        for (int i = 0; i <numbers.Length; i++){
            if(numbers[i]%2 ==0){
                Console.Write($"{numbers[i]}, ");
            }
        }
        System.Console.WriteLine();

        int sum =0;
        for (int i = 0; i <numbers.Length; i++){
            sum += numbers[i];
        }
        System.Console.WriteLine($"masivshi shemavali ricxvebis jamia {sum}");

        int x = 1;
        for (int i = 0; i<numbers.Length; i++){
            x*=numbers[i];
        }
        System.Console.WriteLine($"masivshi shemavali ricxvebis namravlia {x}");

        System.Console.WriteLine("shemoeitanet ricxvi 1dan 18mde");
        string? userInput = Console.ReadLine();
        int userInputInInt = int.Parse(userInput);

        int sum1 = 0;
        for (int i =0; i <userInputInInt; i++){
            sum1 +=numbers[i];
        }
        System.Console.WriteLine($"momxmareblis shemotanili ricxis shesabamisada migebuli ricxvebis jamia {sum1}");

        System.Console.WriteLine($"momxmareblis shemotanili ricxvis kubia {userInputInInt*userInputInInt*userInputInInt}");

    }
}