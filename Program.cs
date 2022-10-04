// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма

//метод разделения строки, вводимой с клавиатуры. В качестве разделителя между словами - пробел.
(string[],int) split_string(string input_string)
{
    string[] output_string= new string[input_string.Length];
    int word_counter = 0;
    for (int index = 0; index <input_string.Length; index++)
    {
        if (input_string[index] != ' ')
        {
            output_string[word_counter] += input_string[index];
        }
        else
        {
            word_counter +=1;
        }
    }
    return (output_string, word_counter + 1);
}

//вводим строку с клавиатуры и преобразуем ее в массив. разделитель слов - пробел
System.Console.WriteLine("Напечатайте несколько слов. Например можно коротко охарактеризовать себя ...");
string? input = System.Console.ReadLine();
string[] input_array = split_string(input).Item1;
int input_length = split_string(input).Item2;

//определяем длину нового массива
int new_array_length = 0;
for (int index = 0; index < input_length; index++)
{
    if (input_array[index].Length < 4)
    {
        new_array_length +=1;
    }
    //System.Console.WriteLine($"{index} {input_array[index]}");
}

//объявляем новый массив и заполняем его элементами исходного массива из строк, длина которых меньше либо равна 3 символа
string[] new_array = new string[new_array_length];
int counter = 0;
for (int index = 0; index < input_length; index++)
{
    if (input_array[index].Length < 4)
    {
        new_array[counter]=input_array[index];
        System.Console.Write($"{new_array[counter]} ");
        counter += 1;
    }
    
}
System.Console.WriteLine();