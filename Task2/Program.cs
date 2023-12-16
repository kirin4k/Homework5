int[,] arr = new int [5,3];
Random rand = new Random();


FillArray(arr);
Console.WriteLine();
int [,] arr1 = NewArray(arr);
PrintArray(arr1);


void FillArray(int[,] array){
for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){
        array[i , j] = rand.Next(1,10);
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
}

int[,] NewArray (int[,] array){
    int temp = 0;
    for(int i=0; i< array.GetLength(0); i++){
        if(i==0){
    for(int j =0 ; j< array.GetLength(1); j++){
        temp = array[i,j];
        array[i,j] = array[array.GetLength(0) - 1,j];
        array[array.GetLength(0) - 1,j] = temp;
    }
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