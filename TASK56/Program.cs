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
   int[]SumRow=new int[matrix.GetLength(0)];
    for(int i = 0 ; i<matrix.GetLength(0);i++)
        {
           for(int j = 0 ; j<matrix.GetLength(1);j++)
           {
           SumRow[i]+=matrix[i,j];
           }
        }
        int temp=SumRow[0];
        int NumberRow =0;
        for(int i = 0 ; i<SumRow.Length;i++)
         { 
          if(SumRow[i]<temp)
          {
            temp=SumRow[i];
            NumberRow=i+1;
          }
        }
    Console.WriteLine("минимальная сумма элементов в строке : "+ NumberRow);
     
   Console.WriteLine("минимальная сумма элементов равно : " + temp );
  }  


Console.Write("кол-во строк:"  );
int n =Convert.ToInt32(Console.ReadLine());
Console.Write("кол-во столбцов:"  );
int m =Convert.ToInt32(Console.ReadLine());
int[,]matrix=new int [n,m];
Console.WriteLine("Начальная матрица: ");
NewMatrix(matrix);
SotrRowInMatrix(matrix);