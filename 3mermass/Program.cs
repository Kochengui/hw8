Console.WriteLine($"Введите размер массива X x Y x Z:");
int x = Numbers("Введите X: ");
int y = Numbers("Введите Y: ");
int z = Numbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3mer = new int[x, y, z];
CreateArray(array3mer);
WriteArray(array3mer);

int Numbers(string tocome)
{
  Console.Write(tocome);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3mer)
{
  for (int i = 0; i < array3mer.GetLength(0); i++)
  {
    for (int j = 0; j < array3mer.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3mer.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3mer[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3mer)
{
  int[] block = new int[array3mer.GetLength(0) * array3mer.GetLength(1) * array3mer.GetLength(2)];
  int  number;
  for (int i = 0; i < block.GetLength(0); i++)
  {
    block[i] = new Random().Next(10, 100);
    number = block[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (block[i] == block[j])
        {
          block[i] = new Random().Next(10, 100);
          j = 0;
          number = block[i];
        }
          number = block[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3mer.GetLength(0); x++)
  {
    for (int y = 0; y < array3mer.GetLength(1); y++)
    {
      for (int z = 0; z < array3mer.GetLength(2); z++)
      {
        array3mer[x, y, z] = block[count];
        count++;
      }
    }
  }
}
	
