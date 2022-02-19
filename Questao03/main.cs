using System;
using System.Collections.Generic;

class Program 
{
  public static void Main (string[] args) 
  {
    string entrada;
    Console.Write("Digite o texto: "); //entrada do texto
    entrada=Console.ReadLine();

    string check = entrada;
    int i = 0, j = entrada.Length - 1; // Trabalhamos com 2 ponteiros na string
    while (i < entrada.Length && j >= 0) // Validação de texto vazio
    {
      //Verificando se a condição é válida
      if (entrada[i] != entrada[j] && check[i] != entrada[j] && check[j] != entrada[i])
      {
        char temp = entrada[i];
        //Criando subString a partir do texto para comparação
        entrada = entrada.Substring(0, i) + entrada[j] + entrada.Substring(i + 1);
        entrada = entrada.Substring(0, j) + temp + entrada.Substring(j + 1);
        i++;
        j = entrada.Length - 1;
      }
      else
        j--;
    }
 
    if (entrada.Length % 2 != 0) //Com string impares conseguimos usar o endereço central
    {
      int mid = entrada.Length / 2; //Determinando a posição do centro da string
      if (check[mid] == entrada[mid]) //Caracteres identicos realize a troca anagrama
      {
        for (i = 0; i < entrada.Length; i++) 
        {
          if (check[i] != entrada[mid] && entrada[i] != entrada[mid]) //Confirmando a igualdade
          {
            char temp = entrada[i];
            entrada = entrada.Substring(0, i) + entrada[mid] + entrada.Substring(i + 1);
            entrada = entrada.Substring(0, mid) + temp + entrada.Substring(mid + 1);
            break;
          }
        }
      }
    }
 
    bool ok = true;
    for (i = 0; i < entrada.Length; i++)
    {
      if (check[i] == entrada[i]) //anagrama criado condiz com o texto inserido
      {
        ok = false;
        break;
      }
    }
 
    if (ok) //exibição do anagrama ou sua ausencia
        Console.Write(entrada);
    else
        Console.Write("Não forma anagrama");
  }
}