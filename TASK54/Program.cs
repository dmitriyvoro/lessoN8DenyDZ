void NewMatrix(int[,]matrix)
{
   for(int i = 0 ; i<matrix.GetLength(0);i++)
    {
    for(int j = 0 ; j<matrix.GetLength(1);j++)
    {
    matrix[i,j]=new Random().Next(-10,11);
    Console.Write(matrix[i,j]+"\t");
    }
   Console.WriteLine(); 
    }   
}
void SotrRowInMatrix(int[,]matrix)
{
   for(int i = 0 ; i<matrix.GetLength(0);i++)
    {
     for(int j = 0 ; j<matrix.GetLength(1);j++)
     {
      for(int k = 0 ; k<matrix.GetLength(1)-1;k++)    
       {
        if(matrix[i ,k]< matrix[i,k +1 ])  
         {
          int temp = matrix[i,k+1];
          matrix[i,k+1]=matrix[i,k]; 
          matrix[i,k]=temp;
         }
       }
    Console.Write(matrix[i,j]+ "\t");
     }
   Console.WriteLine();
  }  
}

Console.Write("кол-во строк:"  );
int n =Convert.ToInt32(Console.ReadLine());
Console.Write("кол-во столбцов:"  );
int m =Convert.ToInt32(Console.ReadLine());
int[,]matrix=new int [n,m];
Console.WriteLine("Начальная матрица: ");
NewMatrix(matrix);
Console.WriteLine("Конечная матрица: ");
SotrRowInMatrix(matrix);