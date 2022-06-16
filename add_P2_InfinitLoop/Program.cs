// Доп.Задача 2. Есть программа с бесконечным циклом. 
// Когда пользователь вводит exit программа заканчивается.


int count = 0;
string stop = "exit";
string text = "";

while (text != stop)
{
    count++;
    Console.WriteLine(count);
    text = Console.ReadLine();
} 