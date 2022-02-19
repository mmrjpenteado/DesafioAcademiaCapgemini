using System;

class Program 
{
  public static void Main (string[] args) 
  {
    // i=linha j=espaço k=asterisco

    for(int i=1;i<=6;i++) //Repete 6x as linhas
    {
      for(int j=6-i; j>0; j--) //Repete qtd de espaços
        Console.Write(" ");
      for(int k=i; k>0; k--)   //Repete qtd de asterisco
        Console.Write("*");     
      Console.WriteLine(""); //Pula linha
    }
  }
}