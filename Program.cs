Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] mass = new string [size];

InitArray(mass);

Console.Write($"[{String.Join(",",mass)}] ->"); 
Console.WriteLine($"[{String.Join(",",ArrayElementsShorterLen(mass,3))}]");

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

//Формируем массив из массива array длина строк которого <= len 
string[] ArrayElementsShorterLen(string[] array, int len){
    size = ElementsShorterLen(array,len);
    if (size == 0){
        string[] temp = new string [size]; 
        return temp;   
    } 
    else{
        string[] temp = new string [size];
        int j = 0;
        for(int i = 0; i < array.Length; i++){
            if(array[i].Length <= len){
                temp[j] = array[i];
                j++;
            }
        }
        return temp;
    }
}