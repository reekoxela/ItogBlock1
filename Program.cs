Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] mass = new string [size];

InitArray(mass);

Console.WriteLine($"Массив: [{String.Join(",",mass)}]");

//******************************************************МЕТОДЫ****************************************************
//Ввод массива с клавиатуры
void InitArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
}