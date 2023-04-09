using System;


namespace name 
{
    public class Program
    {
       public  static void Main(string[] args){
       
        // string name = "John";
        // Console.WriteLine(name);
        
        // int x=10;
        // int y=25;
        // int z=x+y;
        // Console.WriteLine(z);

        // int a,b,c;
        // a= b = c =150;
        // Console.WriteLine(a+b+c);


        //type casting

     /*   int number=10;
        double mydouble = number ;
    Console.WriteLine(number);
    Console.WriteLine(mydouble);

           int myInt = 10;
           double myDouble = 5.25;
           bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string */

       /* string text="programming language is a sequancial code";
        Console.WriteLine("length of the text is : "+ text.Length);





        Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + ((byte)age)); */

      string firstname= "ajith ";
      string middlename= " deva ";
      string lastname= "kumar";
      string name= string.Concat(firstname,middlename,lastname);
      Console.WriteLine(name);


      string n1= "vijay ";
      string n2="kumar ";
      string n3= "vijay ";
      string n4= "jesu ";
      string n5= "das";
      string name1= string.Concat(n1,n2,n3,n4,n5);
      Console.WriteLine(name1);

int x=100;
int y=250;
Console.WriteLine(x >> y);  // boolean 

int n =10;
Console.WriteLine(n == 10);  // equals to

int i = 20;
Console.WriteLine(i == 20);  // equals to

int raju=10;
int maru=11;
if (raju > maru){
}      
// Console.WriteLine("maru is greater than raju");

/*  else {
    Console.WriteLine("good eve"); 
}*/


        }
    }
    
}
