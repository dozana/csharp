using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variables_and_constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Data Types ::.");

            /*
                მონაცემთა ტიპები
              
                გვაქვს შემდეგი მონაცემთა ტიპები:

                1) რიცხვითი მონაცემები
                    1.1) მთელი რიცხვის მონაცემები
                        byte,  sbyte
                        short, ushrt
                        int,   uint
                        long,  ulong
                    
                    1.2) ათწილადი რიცხვის მონაცემები
                        float
                        double
                        decimal

                2) ტექსტური მონაცემები
                    char
                    string

                3) ლოგიკური მონაცემები
                    bool

                4) განსაკუთრებული მონაცემები
                    dynamic
                    dynamic

                რიცხვით-მონაცემთა ტიპები

                +-----------------------------------
                + მთელ რიცხვთა მონაცემთა ტიპები
                +-----------------------------------
              
                byte  -- Byte    -- ზომა: 1byte -- 0 to 255
                sbyte -- SByte   -- ზომა: 1byte -- -128 to 127
                short -- Int16   -- ზომა: 2byte -- -32,768 to 32,767 (თუ დადებით რიცხვებთან ერთად მუშაობა გვიწევს უარყოფით რიცხვებზეც ვიყენებთ short)
                ushrt -- UInt16  -- ზომა: 2byte -- 0 to 65,535 (დადებით რიცხვებზე მუშაობისას ვიყენებთ ushrt-ს)
                int   -- Int32   -- ზომა: 4byte -- -2,147,483,648 to 2,147,483,647
                uint  -- UInt32  -- ზომა: 4byte -- 0 to 4,294,967,295
                long  -- Int64   -- ზომა: 8byte -- 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                ulong -- UInt64  -- ზომა: 8byte -- 0 to 18,446,744,073,709,551,615
              

                +-----------------------------------
                + ათწილადი (მცურავწერტილიანი) რიცხვთა მონაცემის ტიპები
                +-----------------------------------

                float   -- Single  -- ზომა: 4byte  -- -3.402823e38 to -3.402823e38
                double  -- Double  -- ზომა: 8byte  -- -1.79769313486232e308 to -1.79769313486232e308
                decimal -- Decimal -- ზომა: 16byte -- +-1.0 x 10-28 to += 7.9 x 1028  (გამოიყენება ფინანსური ტიპი ოპერაციებისთვის)
              

                +-----------------------------------
                + ტექტურ-მონაცემთა ტიპები
                +-----------------------------------
              
                char   -- Char   -- ზომა: 2byte -- ? (char-ის ზომაა 2 ბაიტი და ინახავს ერთ კონკრეტულ სიმბოლოს, ჩარის მინიმალურ სიმბოლოდ მიჩეულია backspace მაქსიმალურ ზომად კითხივს ნიშანი)
                string -- String -- ზომა: ?byte -- ? (string არის char-ების მასივი, string-ი გამოიყენება არა ერთი სიმბოლოს არამედ ტექსტის შესანახად, მისი მინ. და მაქს. მნიშვნელობები არ ვიცით, ფიქსირებული ზომა არ გააჩნია.)
              

                +-----------------------------------
                + ლოგიკურ-მონაცემთა ტიპები
                +-----------------------------------
              
                bool -- Boolean -- ზომა: 1byte -- false | true


                +-----------------------------------
                + განსაკუთრებულ-მონაცემთა ტიპები (არა პრიმიტიული ტიპები)
                +-----------------------------------
            
                object  -- Object - ზომა: N/A -- N/A (object არის მშობელი ყველა დანარჩენი ტიპებისა, მასში შეგვიძლია შევინახოთ ყველა ზემოთ ჩამოთვლილი სთრინგი, მას ზომა არ გააჩნია, ზოგადი ტიპია)
                dynamic -- N/A    - ზომა: N/A -- N/A (dynamic ობიექტის მსგავისა და ცვალებადია)
              
            */



            /*
                +-----------------------------------
                + ტესტები მონაცემთა ტიპებზე
                +-----------------------------------
            
                2.2.4 byte ტიპი აღწერს:
                ა. წილადს
                ბ. ლოგიკურ ცვლადს
                გ. 8 ბიტიან უნიშნო მთელ რიცხვს (*)


                2.2.5 char ტიპი აღწერს:
                ა. მთელ რიცხვს
                ბ. სიმბოლოს (*)
                გ. ლოგიკურ ცვლადს

            
                2.2.6 decimal ტიპი აღწერს:
                ა. ციფრული ტიპის საფინანსო ცვლადს (*)
                ბ. მტელ რიცხვს
                გ. წილადს
            

                2.2.7 float ტიპი აღწერს:
                ა. ორმაგი სუზუსტის წილადს
                ბ. ლოგიკურ ცვლადს
                გ. ერთმაგი სიზუსტის წილადს (*)


                2.2.8 long ტიპი აღწერს:
                ა. გრძელ მთელ რიცხვს (*)
                ბ. წილადს
                გ. ლოგიკურ ცვლადს
            

                2.2.9 sbyte ტიპი აღწერს:
                ა. 8 ბიტიან ნიშნიან მთელ რიცხვს (*)
                ბ. მთელ რიცხვს
                გ. წილადს
            

                2.2.10 short ტიპი აღწერს:
                ა. წილადს
                ბ. ლოგიკურ ცვლადს
                გ. მოკლე მთელ რიცხვს (*)

            
                2.2.11 uint ტიპი აღწერს:
                ა. მთელ რიცხვს
                ბ. უნიშნო მთელ რიცხვს (*)
                გ. ლოგიკურ ცვლადს

            
                2.2.12 ulong ტიპი აღწერს:
                ა. უნიშნო გრძელ მთელ რიცხვს (*)
                ბ. მთელ რიცხვს
                გ. წილადს

            
                2.2.13 ushort ტიპი აღწერს:
                ა. წილადს
                ბ. ლოგიკურ ცვლადს
                გ. უნიშნო მოკლე მთელ რიცხვს (*)

            
                2.2.14 byte ტიპის ცვლადი მნიშვნელობებს იღებს დიაპაზონში:
                ა. 0   65537
                ბ. -32768  32767
                გ. 0 255  (*)

            
                2.2.15 bool ტიპის ცვლადი იღებს:
                ა. მხოლოდ true მნიშვნელობას
                ბ. მხოლოდ false მნიშვნელობას
                გ. true და false მნიშვნელობებს (*)

            
                2.2.16 int ტიპის ცვლადი იკავებს:
                ა. 8 ბაიტს
                ბ. 4 ბაიტს (*)
                გ. 1 ბაიტს

            
                2.2.17 long ტიპის ცვლადი იკავებს:
                ა. 1 ბაიტს
                ბ. 8 ბაიტს (8)
                გ. 4 ბაიტს

            
                2.2.18 byte ტიპის ცვლადი იკავებს:
                ა. 1 ბაიტს (*)
                ბ. 8 ბაიტს
                გ. 4 ბაიტს

                        
                2.2.19 char ტიპის ცვლადი იკავებს:
                ა. 2 ბაიტს (*)
                ბ. 1 ბაიტს
                გ. 4 ბაიტს

                        
                2.2.20 decimal ტიპის ცვლადი იკავებს:
                ა. 8 ბაიტს
                ბ. 16 ბაიტს (*)
                გ. 4 ბაიტს
                       
            
                2.2.21 double ტიპის ცვლადი იკავებს:
                ა. 4 ბაიტს
                ბ. 16 ბაიტს
                გ. 8 ბაიტს (*)

                        
                2.2.22 float ტიპის ცვლადი იკავებს:
                ა. 4 ბაიტს (*)
                ბ. 16 ბაიტს
                გ. 8 ბაიტს

                        
                2.2.23 sbyte ტიპის ცვლადი იკავებს:
                ა. 1 ბაიტს (*)
                ბ. 2 ბაიტს
                გ. 8 ბაიტს
            */









            /*
             * A bit (ბიტი)
             * 
             * ბიტი მონაცემთა უმცირესი ერთეულია, რომელიც გამოიყენება ციფრულ კომუნიკაციებში;
             * 
             * ბიტი შეიძლება ჰქონდეს ორიდან ერთი მნიშვნელობა: 0 ან 1;
             * 
             * ბიტი "სამშენებლო მასალაა" ორობით სისტემაში;
             * 
             * ბიტი გამოიყენება Boolean (ლოგიკური მნიშვნელობების) რეპრეზენტაციისთვის (true/false).
             * ბიტური ოპერაციების შესასრულებლად და ინფორმაციის სხვადასხვა ფორმატში კოდირებისთვის; 
             * 
             * C#-ში შესაძლებელია შემდეგი ბიტური ოპერაციების გამოყენება 
             * ცვლადებში ცალკეული ბიტების მანიპულირებისთვის.: 
             * 
             *  && - (AND) 
             *  II - (OR) 
             *  ^ - (XOR)
             *  ~ - (NOT)
             *  
             * */

            bool myBit = true;
            Console.WriteLine("The value of myBit is: " + myBit);

            // ლოგიკური ოპერაციების წარმოდგენა ბიტებით
            bool anotherBit = false;
            bool resultAND = myBit && anotherBit; // AND operation
            bool resultOR = myBit || anotherBit; // OR operation
            bool resultXOR = myBit ^ anotherBit; // XOR operation

            Console.WriteLine("Result of AND operation: " + resultAND);
            Console.WriteLine("Result of OR operation: " + resultOR);
            Console.WriteLine("Result of XOR operation: " + resultXOR);

            Console.WriteLine("----------------- END\n");


            /*
             * Byte (ბაიტი)
             * 
             * ბაიტი არის უმცირესი მეხსიერებაში მისამართის მქონე ერთეული უმეტეს კომპიუტერულ არქიტექტურაში;
             * ბაიტი ინტეგრალური ტიპია, რომელიც 8 ბიტიანი უნიშნო მთელი რიცხვის რეპრეზენტაციაა.
             * 
             * C#-ში ბაიტი შედგება 8 ბიტისგან; 
             * 1 Byte (ბაიტი) = 8 bit (ბიტი)
             * 
             * ბაიტს შეუძლია წარმოადგინოს 256 განსხვავებული მნიშვნელობა ე.ი 2^8;
             * 
             * ბაიტი გამოიყენება სიმბოლოების, მთელი რიცხვების და სხვა მცირე მნიშვნელობების შესანახად;
             * 
             * ბაიტს შეუძლია შეინახოს მნიშვნელობები 0-იდან 255-მდე.
             * 
             * */

            byte myByte = 150;
            Console.WriteLine("The value of myByte is: " + myByte);
            
            myByte++;
            Console.WriteLine("After incrementing, the value of myByte is: " + myByte);

            // Performing arithmetic operations
            byte a = 50;
            byte b = 100;
            byte sum = (byte)(a + b);
            byte difference = (byte)(b - a);

            Console.WriteLine("Sum of a and b is: " + sum);
            Console.WriteLine("Difference of b and a is: " + difference);

            Console.WriteLine("----------------- END\n");


            /*
             * sbyte
             * 
             * sbyte 8 ბიტიანი ნიშნიანი მთელი რიცხვის რეპრეზენტაციაა.
             * მასში შესაძლებელია მნიშვნელობების შენავა -128-იდან 127-მდე
             * 
             * */

            sbyte mySByte = 50;
            Console.WriteLine("The value of mySByte is: " + mySByte);

            mySByte++;
            Console.WriteLine("After incrementing, the value of mySByte is: " + mySByte);

            // არითემტიკული ოპერაციები
            sbyte a1 = 20;
            sbyte b1 = -10;
            sbyte sum1 = (sbyte)(a1 + b1); // sum will be 10
            sbyte difference1 = (sbyte)(a1 - b1); // difference will be 30

            Console.WriteLine("Sum of a and b is: " + sum1);
            Console.WriteLine("Difference of a and b is: " + difference1);

            Console.WriteLine("----------------- END\n");







            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "John";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            */



        }
    }
}
