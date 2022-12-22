Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] mass = new string [size];

InitArray(mass);

Console.WriteLine($"Массив: [{String.Join(",",mass)}]");

Console.Write($"Количество элементов меньше или равно {3}: {ElementsShorterLen(mass,3)}");

//******************************************************МЕТОДЫ****************************************************
//Ввод массива с клавиатуры
void InitArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
}

//Элементы длинна которых меньше или равна len
int ElementsShorterLen(string[] array, int len){
    int num = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= len) num++;
    }
    return num;
}