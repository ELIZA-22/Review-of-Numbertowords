
//Develop a console app that takes an integer as input and prints out the integer in words.
// For example, If the input is 5, the program prints Five to the terminal, if the input is 2,456, the program prints Two thousand, Four hundred and fifty six to the terminal.
// The program should handle input values between 0 and 1,000,000

// prompt user to enter an integer from 0 to 1,000,000
//declare a variable integer
// check if input is  valid 
// if it is convert to words
//else 
// if it is get a function that print out the number in words 
//0-20 , 30,40,50,60,70,80,90,100
//input = 1  list ={ ONE , TWO , THREEE } LIST[0] =0NE , LIST[1] =TWO 
// output = one 
//create a function that print numbers to words by telling it zero means 0 and one means 1 etc.
using System;

public class Program
{

static string[] Tens = { "one" ,"two", "three","four","five","six","seven" ,"eight",
        "nine", "ten" ,"eleven" , "Twelve", "thirteen", "fourteen" , "fifteen",
        "sixteen", "seventeen" , "eighteen" ,"nineteen"};
static string[] Hundreds ={ "Twenty" ,"Thirty" ,"Forty", "Fifty" ,"Sixty" ,"Seventy" ,"Eighty","Ninety",};

static string[] Thousands= { "One Hundred" ,"Two Hundred" ,"Three Hundred" ,"Four Hundred","Five Hundred","six Hundred","Seven Hundred","Eight Hundred","Nine Hundred"};
static string[] TensOfThousands= { "One Thousand" ,"Two Thousand" ,"Three Thousand" ,"Four Thousand","Five Thousand","Six Thousand","Seven Thousand","Eight Thousand","Nine Thousand"};
//static string[] HundredOfThousands= { "Ten Thousand" ,"Twenty Thousand" ,"Thirty Thousand" ,"Forty Thousand","Fifty Thousand","Sixty Thousand","Seventy Thousand","Eighty Thousand","Ninety Thousand"};

static void Main(string[] args) {

/// prompt user to enter an integer from 0 to 1,000,000
Console.WriteLine("Enter an Integer from 0 to 1,000,000 :" );
// declare a variable 'input'that assigns the users input to itself
 var input =Console.ReadLine();
 var num =0;
 // check is the user inputed the right thing and also convert the string inputed to integer
 bool inputValidity = Int32.TryParse( input , out num);
 if(!inputValidity || num < 0 || num > 1000000) {
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine($"Your input is invalid, please try again\n");
 Console.ResetColor();
 //Main(args);
 } 
 NumberToWords(num);
}
    public static void NumberToWords(int num)
    { 

      if (num == 0 ){ 
        Console.WriteLine("Zero");
      } 
      else if (num == 1000000 ){ 
        Console.WriteLine("One million");
      } 
      else if (num < 20 ){ 
        Console.WriteLine(Tens[num - 1]);
      } 
      else if (num < 100)
         {
            int tensIndex = (num / 10) - 2;  // Convert 20, 30... to 0, 1...
            int onesIndex = num % 10;      // Get last digit

                if (onesIndex == 0)
                    Console.WriteLine(Hundreds[tensIndex]); // 20, 30, 40...
                else
                    Console.WriteLine( $"{Hundreds[tensIndex]} {Tens[onesIndex -1]}"); // 21-99
         }
      else if (num < 1000) //110
      {
       int hundredIndex = num/100 -1;// 110/100 -1 =   thousand[0] = one HUNDRED
       int tenIndex = num% 100; // 400% 100 = 0
       int positiontens = tenIndex / 10  -2 ; //55/10 -2 =3 Hundred[3] = fifty
       int positionUnit = tenIndex % 10; //55% 10 = 5 tens[5]

      if ( tenIndex == 0) 
       { 
         Console.WriteLine($"{Thousands[hundredIndex]}");
       }
      else if (tenIndex < 20) {
    Console.WriteLine($"{Thousands[hundredIndex]} and {Tens[tenIndex -1]}");
       }
      else if(positiontens== 0  ) {
       Console.WriteLine( $"{Thousands[hundredIndex]} and {Tens[positionUnit -1]}");
       } 
       else {
         Console.WriteLine( $"{Thousands[hundredIndex]} and {Hundreds[positiontens]} {Tens[positionUnit-1]}");
        } 
      } 
      else if (num < 10000) { // 6590
      int ThousandPosition = num/1000 -1 ;//6590/1000 -1 =5 tenthousand[5]
      int ThousandRemainder = num% 1000 ;//6590% 1000 = 590
      int HundredPosition = ThousandRemainder/100 -1 ; //590/100 =5-1 =4  thousand[4]
      int HundredRemainder = ThousandRemainder % 100 ;// 590% 100 = 90 
      int TensPosition = HundredRemainder /10 -2; ///9 -2 =7
      int TensRemainder =HundredRemainder % 10  ;//10% 10 =0

      if (ThousandRemainder ==0 ){
        Console.WriteLine($"{TensOfThousands[ThousandPosition]}");
      } else if (HundredRemainder ==0 )
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition]} {Thousands[HundredPosition]}");
      }
        else if (HundredRemainder <20) 
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition]} {Thousands[HundredPosition]} and {Tens[HundredRemainder -1]}");
      }
        else if (TensRemainder ==0)
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition]} {Thousands[HundredPosition]} and {Hundreds[TensPosition]}");
      } else 
      {
       // else if (TensRemainder < 20) {
         Console.WriteLine($"{TensOfThousands[ThousandPosition]} {Thousands[HundredPosition]} and {Hundreds[TensPosition]} {Tens[TensRemainder -1]}");
       }
        //else 
       // { Console.WriteLine($"{TensOfThousands[ThousandPosition]} {Thousands[HundredPosition]} and {Hundreds[TensPosition]} {Tens[HundredRemainder]}" );
      }
    }
  }

    


