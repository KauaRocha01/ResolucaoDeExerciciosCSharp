namespace InicioC_;
class Program
{
    static void Main(string[] args)
    {
        //  Console.WriteLine("Hello, World!");



    // int idade = 18;
    // double altura = 1.75;
    // string nome = "Kaua";
    // bool ativo = true;
    
    // Console.WriteLine(idade);
    // Console.WriteLine(altura);
    // Console.Write(nome);
    // Console.Write(ativo);

    // // Entrada de Dados
    // Console.WriteLine("Digite seu nome: ");
    // // Nome recebe o que foi digitado e armazena
    // string nome = Console.ReadLine();

    // Console.WriteLine("Digite sua idade: " );
    // // Pega o resultado digitado, que é uma string e converte para int.
    // int idade = int.Parse(Console.ReadLine());

    // Console.WriteLine("Nome: " + nome);
    // Console.WriteLine("Idade: " + idade);

    // Console.WriteLine($"Olá, eu sou {nome}, tenho {idade} anos. ");

    // int n1 = 10;
    // int n2 = 5;
    // int soma = n1 + n2;

    // Console.WriteLine("Soma: " + soma);

    // operadores matemáticos
    // soma ->          int soma = a + b
    // subtracao ->     int sub = a - b
    // multiplicacao -> int mult = a * b
    // divisao ->       int div = a / b
    // resto da divisao int resto = a % b

    // operadores relacionas 
    // Iguais ->        num1 == num2
    // Diferente ->     num1 != num2
    // Maior ->         num1 > num2
    // MaiorOuIgual ->  num1 >= num2
    // Menor ->         num1 < num2
    // MenorOUigual     num1 <= num2

    //  int idade = 8;

    //  bool maiorDeIdade = idade >= 18;
    //  bool menorDeIdade = idade < 18;

    //  Console.WriteLine("Maior de idade: " + maiorDeIdade);
    // Console.WriteLine("Menor de idade: " + menorDeIdade);

    // // Operadores Logicos
    // /* Operador AND(E) - &&
    //         -> valida se todas as condições forem verdadeiras, se
    //         forem, ele retorna true - caso contrario, retorna 
    //         false.
    //         -> amarelo && branco -> false
    //         -> branco && branco -> true

    //     Operador OR(OU) -> ||
    //         -> valida se pelo menos uma condição é verdadeira, se for, retorna
    //         true, se as duas forem falsas, retorna falso
    //         -> hoje == "Sexta" || hoje == "Sábado" -> true
    //         -> hoje -- "Segunda" || hoje == "Sábado" -> false

    //     Operador NOT(NÃO) -> !
    //         -> inverte a condição, se for true vira false e se for false vira
    //         true.
    //         -> !true -> false
    //         -> !false -> true     

    // bool condicao1 = true;
    // bool condicao2 = false;

    // Console.WriteLine(condicao1 && condicao2); // false
    // Console.WriteLine(condicao1 || condicao2);// true
    // Console.WriteLine(!condicao1); // false

    // int idade = 20;
    // bool possuiCarteira = false;

    // bool podeDirigir = idade >= 18 && possuiCarteira;
    // Console.WriteLine("Pode dirigir: " + podeDirigir);
    
//     int numero = 5;

//     bool resultado = numero < 0 || numero > 10;

// Console.WriteLine("Fora do intervalo 0 a 10 : " + resultado ); 
    
    // bool estaChovendo = false;

    // Console.WriteLine(!estaChovendo);

       

       
     //Dobro de um número  Leia um número inteiro e mostre o dobro dele.
        
        //  Console.Write("Digite um número inteiro: ");
        //  int numero = int.Parse(Console.ReadLine());

        // int dobro = numero * 2;

        //  Console.WriteLine("O dobro do número é: " + dobro);


    //Soma simples Leia dois números e exiba a soma.

        // int n4 = 20;
        // int n5= 30;
        // int soma = n4 + n5;

         // Console.WriteLine("A soma dos dois numeros é: " + soma);

     //Par ou ímpar Leia um número e informe se ele é par ou ímpar.


    //Console.Write("Digite um número: ");
       // int numero = int.Parse(Console.ReadLine());
       //

        //string[] resultado = { "O número é par.", "O número é ímpar." };
        //Console.WriteLine(resultado[numero % 2]);


     //Maior número Leia dois números e informe qual é o maior.
         //   Console.Write("Digite o primeiro número: ");
         //   int num1 = int.Parse(Console.ReadLine());
         //   Console.Write("Digite o segundo número: ");
         //   int num2 = int.Parse(Console.ReadLine());
        //    int maior = num1 > num2 ? num1 : num2;
        //    Console.WriteLine("O maior número é: " + maior);

    //Idade mínima Leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais)

        // Console.Write("Digite a idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";
        // Console.WriteLine(resultado);




     //Média de notasLeia duas notas e calcule a média.Exiba se o aluno foi aprovado (média >= 6).

        // Console.Write("Digite a primeira media: ");
        //  double n1 = double.Parse(Console.ReadLine());
        // Console.Write("Digite a segunda media: ");
        // double n2 = double.Parse(Console.ReadLine());

        // double media = (n1 + n2) / 2;

        // Console.WriteLine(media);
        // Console.WriteLine(media >= 6 ? "Aprovado" : "Reprovado");

     //Intervalo numérico Leia um número e informe se ele está entre 50 e 100.

        // double num = double.Parse(Console.ReadLine());

        //     string resultado = (num >= 50 && num <= 100) 
        // ?           "Está entre 50 e 100" 
        //              : "Não está entre 50 e 100";

        //             Console.WriteLine(resultado);

     // Desconto em produto
        // Leia o valor de um produto.
        // Se o valor for maior que 100, aplique 10% de desconto.
        // Mostre o valor final.

        // double valor = double.Parse(Console.ReadLine());

        // double valorFinal = (valor > 100) ? valor * 0.9 : valor;

        // Console.WriteLine(valorFinal);

//        Positivo, negativo ou zero
// Leia um número e informe se ele é positivo, negativo ou zero.
    // Console.Write("Digite um número: ");
    //     double numero = Convert.ToDouble(Console.ReadLine());

    //     string resultado =
    //         numero > 0 ? "Positivo" :
    //         numero < 0 ? "Negativo" :
    //         "Zero";

    //     Console.WriteLine($"\nResultado: {resultado}");

   // Leia a idade e informe se a pessoa pode votar (idade >= 16).

//    Console.Write("Digite sua idade: ");
//    int idade = int.Parse(Console.ReadLine());

//    Console.WriteLine("Pode votar: " + (idade >= 16));



//     1. **Sistema de login simples** Peça um usuário e senha.  Considere válidos: - usuário: admin  - senha: 1234  Informe se o login foi bem-sucedido.
    //   Console.Write("Digite o usuario: ");
    //   string usuario = Console.ReadLine();

    //   Console.Write("Digite a senha: ");
    //   string senha = Console.ReadLine();

    //   Console.Write("Login realizado: " + (usuario ==
    //   "admim" && senha == "1234"));
    
    //Maior de três números Leia três números e informe qual é o maior.

    // int n1 = 27;
    // int n2 = 35;
    // int n3 = 54;

    // Console.WriteLine("O primeiro número é maior: " + (n1 > n2 && n1 > n3));
    // Console.WriteLine("O segundo número é maior: " + (n2 > n1 && n2 > n3));
    // Console.WriteLine("O terceiro número é maior: " + (n3 > n1 && n3 > n2));
    // Console.WriteLine("Os números são iguais: " + (n1 == n2 && n1 == n3));

    // Cálculo de salário com bônus Leia o salário de um funcionário.

    // decimal salario = 15000m;

    // decimal aumento10 = salario = (salario * 0.10m);
    // decimal aumento20 = salario = ( salario * 0.20m);

    // Console.WriteLine("Salário com 10%: " + aumento10);
    // Console.WriteLine("Salário com 20%: " + aumento20);

    // Console.WriteLine("Recebe 10%: " + (salario > 2000));
    // Console.WriteLine("Recebe 20% " + (salario <= 2000));

   // Ano bissexto (simplificado) Leia um ano e informe se ele é divisível por 4 (considere isso como critério).

    // int ano = 2024;
    
    // Console.WriteLine("Ano bissexto simplificado: " + (ano % 4 == 0));

    Console.Write("Informe sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Possui convite? (true/false)");
    bool convite = bool.Parse(Console.ReadLine());

    Console.WriteLine("Acesso permitido: " + (idade >= 18 && convite));

        
    
      










    


    }
}