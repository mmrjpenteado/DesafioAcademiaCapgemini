using System;
using System.Text.RegularExpressions;

class Program 
{
  public static void Main (string[] args) 
  {
    string nome,senha;
    int qtdCaracter, qtdNumerico, qtdMinusculo, qtdMaiusculo, qtdEspecial;
    do //inicio da repetição
    {
      //Solicitando as informações para o cadastro
      Console.Write("Digite o nome: ");
      nome=Console.ReadLine();
      Console.Write("Digite a senha: ");
      senha=Console.ReadLine();

      // Quantificando cada validação
      qtdCaracter = senha.Length;
      qtdNumerico = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
      qtdMinusculo = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
      qtdMaiusculo = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
      qtdEspecial = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;

      // Informando a regra faltante
      if(nome=="")
        Console.WriteLine("O campo nome deve ser preenchido.");
      if(qtdCaracter<6)
        Console.WriteLine("A senha deve ter no mínimo 6 caracteres.");
      if(qtdNumerico<1)
        Console.WriteLine("A senha deve ter no mínimo 1 dígito.");
      if(qtdMinusculo<1)
        Console.WriteLine("A senha deve ter no mínimo 1 letra em minúsculo.");
      if(qtdMaiusculo<1)
        Console.WriteLine("A senha deve ter no mínimo 1 letra em maiúsculo.");
      if(qtdEspecial<1)
        Console.WriteLine("A senha deve ter no mínimo 1 caracter especial.");
    }
    while(nome=="" || qtdCaracter<6 || qtdNumerico<1 || qtdMinusculo<1 || qtdMaiusculo<1 || qtdEspecial<1);
    
    Console.WriteLine("Cadastro Realizado Com Sucesso!");
  }
}