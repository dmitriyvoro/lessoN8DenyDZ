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

void ProzMatrixs(int[,]MatrixOne,int[,]MatrinxTwo)
{
    Console.WriteLine();  
    int[,]ResultMatrix = new int[MatrixOne.GetLength(0),MatrixOne.GetLength(1)];
    for(int i = 0 ; i<MatrixOne.GetLength(0);i++)
    {
           for(int j = 0 ; j<MatrixOne.GetLength(1);j++)
           {
           ResultMatrix[i,j]=MatrixOne[i,j]*MatrinxTwo[i,j];
           Console.Write(ResultMatrix[i,j]+"\t");
           }       
    Console.WriteLine();
    }
  }  


Console.Write("кол-во строк:"  );
int n =Convert.ToInt32(Console.ReadLine());
Console.Write("кол-во столбцов:"  );
int m =Convert.ToInt32(Console.ReadLine());
int[,]MatrixOne=new int [n,m];
int[,]MatrixTwo=new int [n,m];
Console.WriteLine("Начальная матрица 1: ");
NewMatrix(MatrixOne);
Console.WriteLine();
Console.WriteLine("Начальная матрица 2: ");
NewMatrix(MatrixTwo);
Console.WriteLine("итоговый результат :");
ProzMatrixs(MatrixOne,MatrixTwo);