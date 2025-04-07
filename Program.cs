
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
static string[] HundredOfThousands= { "Ten Thousand" ,"Twenty Thousand" ,"Thirty Thousand" ,"Forty Thousand","Fifty Thousand","Sixty Thousand","Seventy Thousand","Eighty Thousand","Ninety Thousand"};

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
      if (num == 0) 
      { 
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
       int positiontens = tenIndex / 10 ; //55/10 -2 =3 Hundred[3] = fifty
       int positionUnit = tenIndex % 10; //55% 10 = 5 tens[5]

      if ( tenIndex == 0) 
       { 
         Console.WriteLine($"{Thousands[hundredIndex]}");
       }
      else if (tenIndex < 20) {
    Console.WriteLine($"{Thousands[hundredIndex]} and {Tens[tenIndex -1]}");
       }
      else if(positionUnit== 0  ) {
       Console.WriteLine( $"{Thousands[hundredIndex]} and {Hundreds[positiontens -2]}");
       } 
       else {
         Console.WriteLine( $"{Thousands[hundredIndex]} and {Hundreds[positiontens-2]} {Tens[positionUnit-1]}");
        } 
      } 

      //for 10,000 below
      else if (num < 10000) { // 9001
      int ThousandPosition = num/1000  ;// 9001/1000 = 9
      int ThousandRemainder = num% 1000 ;// 9001% 1000 = 1
      int HundredPosition = ThousandRemainder/100 ; //590/100 =5-1 =4  thousand[4]
      int HundredRemainder = ThousandRemainder % 100 ;// 590% 100 = 90 
      int TensPosition = HundredRemainder /10 ; ///9 -2 =7
      int TensRemainder =HundredRemainder % 10  ;//10% 10 =0

      if (ThousandRemainder ==0 ){
        Console.WriteLine($"{TensOfThousands[ThousandPosition-1]}");
      } 
      else if (ThousandRemainder < 20)
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]}  and {Tens[ThousandRemainder -1]}");
      }
      else if (ThousandRemainder < 100)
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} and {Hundreds[(ThousandRemainder/ 10 )-2] } { Tens[(ThousandRemainder%10) -1 ]}");
      }
      else if (HundredRemainder ==0 )
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} {Thousands[HundredPosition -1]}");
      }
        else if (HundredRemainder <20) 
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} {Thousands[HundredPosition -1]} and {Tens[HundredRemainder -1]}");
      }
        else if (TensRemainder ==0)
      {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} {Thousands[HundredPosition -1]} and {Hundreds[TensPosition -2]}");
      }
        else if (TensRemainder < 20) {
         Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} {Thousands[HundredPosition -1]} and {Hundreds[TensPosition -2]} {Tens[TensRemainder -1]}");
       }
      }
// for 10,000 -100,000 below
      else if (num < 100000) {//10,113
      int TenThousandPosition = num/10000 ;// 10113/10000 = 1
      int TenThousandRemainder = num % 10000;// 10,113% 10000 = 113
      int BetweenTenthousandPosition = num/1000; // 10113/1000 = 10
      int BetweenTenthousandRemainder = num % 1000; // 10113% 1000 = 113
      int ThousandPosition1 = TenThousandRemainder/1000; // 113/1000 =0
      int ThousandRemainder1 = TenThousandRemainder % 1000 ;// 113% 1000 = 113
      int HundredPosition1 = ThousandRemainder1/100 ; // 113/100 =1
      int HundredRemainder1 = ThousandRemainder1 % 100 ;// 113% 100 = 13
      int TensPosition1 = HundredRemainder1/10 ;// 13/10 =1
      int TensRemainder1 = HundredRemainder1 % 10 ; // 13%10 =3
 // 10,000, 20,000, 30,000, 40,000, 50,000 etc
       if ( TenThousandRemainder == 0 ){
        Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]}");
       } 

       else if (BetweenTenthousandRemainder < 20) 
       {
          Console.WriteLine($"{Tens[BetweenTenthousandPosition -1]} Thousand ");
       }
       // 10,001 -10,019
       else if(TenThousandRemainder < 20)
      {
        Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} and {Tens[TenThousandRemainder -1]}");
      } 
      //10,029, 10039, 10049
       else if (TenThousandRemainder < 100 && TensRemainder1  != 0) {
        Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} and {Hundreds[TensPosition1 -2]} {Tens[TensRemainder1 -1]}");
      }// 10,040,10,050,10,060,10,070,
      else if (TenThousandRemainder < 100 ) {
        Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} and {Hundreds[TensPosition1 -2]}");
      }//10100,10200,10300,10400,10500,10600,10700,10800,10900
      else if (TenThousandRemainder >= 100 && TensRemainder1 ==0  ) {
       Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} {Thousands[HundredPosition1 -1]}");
       }//10110,10120,10130,10140,10150,10160,10170,10180,10190
      else if (TenThousandRemainder >= 100  && HundredRemainder1 < 20) {
         Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} {Thousands[HundredPosition1 -1]} and {Tens[HundredRemainder1 -1]}");
       }//10220,10230,10240,10250,10260,10270
       else if (TenThousandRemainder >= 100  && HundredRemainder1 >= 20) {
         Console.WriteLine($"{HundredOfThousands[TenThousandPosition -1]} {Thousands[HundredPosition1 -1]} and {ConvertToWords(HundredRemainder1)}");
       }
       else if (BetweenTenthousandRemainder < 20) 
       {
          Console.WriteLine($"{Tens[BetweenTenthousandPosition -1]} Thousand ");
      }
      // else if (ThousandRemainder < 100)
      // {
      //    Console.WriteLine($"{TensOfThousands[ThousandPosition -1]} and {Hundreds[(ThousandRemainder/ 10 )-2] } { Tens[(ThousandRemainder%10) -1 ]}");
      // }
      }
        }
    
        public static string ConvertToWords(int num)
        {
            if (num == 0) return "Zero";
            if (num < 20) return Tens[num - 1];
            if (num < 100)
            {
                int tensIndex = (num / 10) - 2;
                int onesIndex = num % 10;
                return onesIndex == 0 ? Hundreds[tensIndex] : $"{Hundreds[tensIndex]} {Tens[onesIndex - 1]}";
            }
            return "Number out of range for this method";
        }
    }
  

    


