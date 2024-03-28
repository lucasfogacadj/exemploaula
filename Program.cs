// // string nome = "Paulo";
// // int idade = 17;
// // double nota = 7.5;

// // // Console.WriteLine("O aluno" + nome + " tem " + idade + " anos de idade e a nota dele é " + nota + " .");
// // // Console.WriteLine($"O aluno {nome} \n tem {idade} \n anos de idade e a nota dele é {nota}.");
// // // Console.WriteLine($"{nome} \n {idade} \n {nota}" );

// // char letra1, letra2, letra3;
// // Console.WriteLine("Informe uma letra 1:");
// // letra1 = Convert.ToChar(Console.ReadLine());
// // Console.WriteLine("Informe a letra 2:");
// // letra2 = Convert.ToChar(Console.ReadLine());
// // Console.WriteLine("Informe a letra 3:");
// // letra3 = Convert.ToChar(Console.ReadLine());

// // Console.WriteLine(letra3 + " " + letra2 + " " + letra1);

// // Console.WriteLine($"{letra3} {letra2} {letra1}");


// // Console.WriteLine("Digite um valor:");
// // double num1 = Convert.ToDouble(Console.ReadLine());

// // Console.WriteLine("Digite um outro valor:");
// // double num2 = Convert.ToDouble(Console.ReadLine());

// // Console.WriteLine($"Soma = {num1 + num2}");
// // Console.WriteLine($"Subtração = {num1 - num2}");
// // Console.WriteLine($"Multiplicação = {num1 * num2}");
// // Console.WriteLine($"Divisão = {num1 / num2}");
// // Console.WriteLine($"Módulo = {num1 % num2}");
// // Console.WriteLine($"Exponenciação = {Math.Pow(num1,num2)}");
// // Console.WriteLine($"Raiz Quadrada de {num1} = {Math.Sqrt(num1)}");

// Console.WriteLine("Informe seu nome:");
// string nome = Console.ReadLine()!;
// Console.WriteLine("Informe sua senha:");
// int senha = Convert.ToInt32(Console.ReadLine());

// var resultado = (nome == "admin" || nome == "Maria") && senha == 123 ? "Login feito com sucesso!":"Login inválido";

// Console.WriteLine(resultado);

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x%2==0?"X é par":"X não é par");
Console.WriteLine(y%2==0?"Y é par":"Y não é par");