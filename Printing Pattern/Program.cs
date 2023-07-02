for (int i = 0; i < 7; i++)
{
    if (i < 3 || i >= 6)
    {
        for (int j = 0; j <= 10; j++)
        {
            if (j == 5 || j == 6)
                Console.Write("");
            else
                Console.Write(j);
        }
    }
    
    else if (i >= 3 && i < 7)
    {
        for (int j = 10; j > 0; j--)
            {
                Console.Write(j);
            }
    }
    
    Console.WriteLine();
}
