// Доп.Задача 2(4). Есть программа с бесконечным циклом. 
// Когда пользователь вводит exit программа заканчивается. 
// Добавить к программе еще 4 команды (их можно придумать самому). 
// Например: SetName – Установить имя; Help – вывести список команд; 
// SetPassword – Установить пароль; SetName – Установить имя
// WriteName – вывести имя после ввода пароля; Exit – выход



string stop = "exit";
string text = "";
int[] password = new int[4];
string name = "";

Console.Clear();

for (int j = 0; text != stop; j++)
{
    if (text == "Help")
    {
        Console.WriteLine("SetName - Установить Имя");
        Console.WriteLine("SetPassword - Установить Пароль");
        Console.WriteLine("Help - Вывести список команд");
        Console.WriteLine("Edit - Выход");
    }
    if (text == "SetPassword")
    {
        Console.WriteLine("Введите пароль (4 цифры ): **** ");
        for (int i = 0; i < password.Length; i++)
        {
            Console.Write($"{i + 1}-ю цифрa: ");
            password[i] = Convert.ToInt32(Console.ReadLine());
        }
        
    }
    if (text == "SetName")
    {
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
    } 
   
    Console.Write("Введите команду: ");
    text = Console.ReadLine();
}  
