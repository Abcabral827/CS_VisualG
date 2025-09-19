
string nome;
int idade = 0;
int data;
Console.WriteLine("Digite seu nome");
nome = Convert.ToString(Console.ReadLine());

Console.WriteLine("Digite seu ano de nascimento");
data =  Convert.ToInt32 (Console.ReadLine());
idade += 2025 - data;
Console.WriteLine("Sua idade: " + Convert.ToString(idade));
Console.WriteLine("Seu nome: " + Convert.ToString(nome));


