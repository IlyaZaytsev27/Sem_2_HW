// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit(int num){
    while(num > 999){
        num = num / 10;
    }
        num = num % 10;
        Console.WriteLine($"{num}");
    
}
bool CheckThirdDigit(int num){
    if(num < 100){
        Console.WriteLine("ThirdDigit none");
        return false;
    }
    return true;
    
}
    

Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckThirdDigit(number)){
    ThirdDigit(number);
}
