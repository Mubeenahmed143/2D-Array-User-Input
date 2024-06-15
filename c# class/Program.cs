Console.WriteLine("Jagged ARRAY with user input");

int[][] jag = new int[4][];

for (int z = 0; z < 4; z++)
{
    jag[z] = new int[4];
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4
        ; j++)
    {
        Console.Write("Enter value of matrix at position [" + i + "][" + j + "]:");
        jag[i][j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int a = 0; a < jag.Length; a++)
{
    for (int b = 0; b < jag[a].Length; b++)
    {
        Console.Write(jag[a][b] + " ");
    }
    Console.WriteLine();
}
