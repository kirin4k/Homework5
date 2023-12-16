Random rand = new Random();
int[,] arr = FillArray(4,3,1,10);                   //Ввод массива случайными числами, если наименьших чисел несколько, то отрезается только строка и столбец с первым меньшим числом.
PrintArray(arr);
// int[,] arr = {{5,3,1},{1,0,7},{5,1,7}};          //Ввод массива от руки
// PrintArray(arr);
PrintArray(NewArray(arr));


void PrintArray(int[,] array){
    for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){        
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
}

int[,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i=0; i< rows; i++){
        for(int j =0 ; j< columns; j++){
        array[i , j] = rand.Next(min,max);
    }
}
return array;
}

int[,] NewArray(int[,] array){
    int [] size = MinValue(arr);
    int[,] newarr = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int m=0, l=0;
    for(int i=0; i< array.GetLength(0); i++){
        if(i != size[0]){
    for(int j =0 ; j< array.GetLength(1); j++){
        if(j != size[1]){
        newarr[m,l]= array[i,j];
        l++;
        }
    }
    m++;
    l =0;
}
}
return newarr;
}

int[] MinValue(int[,] array){
    int[] list = new int[2];
    int min = array[0,0];
    int ind1 = 0, ind2 =0;
    for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){
        if(arr[i,j]<min){
            min = array[i,j];
            ind1 = i;
            ind2 = j;
        }
    }
}
list[0]= ind1;
list[1]= ind2;
return list;
}