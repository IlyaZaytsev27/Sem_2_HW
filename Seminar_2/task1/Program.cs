// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNumber(int num=0){
    if(num<100 || num>999 ){
        Console.WriteLine("ERRRRRRROOOOOR");
    }
    else{
        int new_num = (num/10)%10;
        Console.WriteLine($"Your num is {new_num}");
    }

}

Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
SecondNumber(number);
