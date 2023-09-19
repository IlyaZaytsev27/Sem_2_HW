//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDayOff(int num){
    if(num > 0 && num <8){
        if(num < 6){
            Console.WriteLine("РАБОТАЙ");       
        }
        else{
            Console.WriteLine("ОТДЫХАЙ");
        
    }}
    else{
        Console.WriteLine("Нема такого дня");
    }

}


Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

CheckDayOff(number);