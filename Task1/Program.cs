int[,] arr = new int [3,3];
Random rand = new Random();


FillArray(arr);

Console.WriteLine("Введите первый индекс нужного элемента: ");
int FirstIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй индекс нужного элемента: ");
int SecondIndex = Convert.ToInt32(Console.ReadLine());

CheckNumber();


void FillArray(int[,] array){
for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){
        array[i , j] = rand.Next(1,10);
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
}

int FindIndex(int[,] array, int index1, int index2) {
    if(index1<array.GetLength(0) && index2<array.GetLength(1)){
    return array[index1, index2];
    }
    else
    return -1;
}

void CheckNumber (){
    int arrayElement = FindIndex(arr, FirstIndex, SecondIndex);
    if(arrayElement==-1) Console.WriteLine("Такого индекса в массиве не существует");
    else
    Console.WriteLine($"Элемент массива равен: {arrayElement}");
}
