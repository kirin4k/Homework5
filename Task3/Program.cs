Random rand = new Random();

int[,] arr = FillArray(4,3,1,10);
PrintArray(arr);
Console.WriteLine();
FindMinRow(arr);

int[,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i=0; i< rows; i++){
        for(int j =0 ; j< columns; j++){
        array[i , j] = rand.Next(min,max);
    }
}
return array;
}


void PrintArray(int[,] array){
    for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
}

void FindMinRow(int[,] array){
    int index = -1;
    int min = 1000000;
    for(int i=0; i< array.GetLength(0); i++){
    int sum =0;
    for(int j =0 ; j< array.GetLength(1); j++){
        sum += array[i,j];
    }
    Console.WriteLine(sum);
    if(sum<min){ 
    min= sum;
    index = i;
   }
} Console.WriteLine(index+ ",");
}