using System.Security.Cryptography.X509Certificates;
using Exemplos.Fundamentos.Models;


// List<string> listaString = new List<string>();

// listaString.Add("RN");
// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");




// for(int contador = 0; contador <listaString.Count; contador++ );
// {
//   Console.WriteLine($"Posição N°{contador} - {listaString[contador]}");
// }
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//   Console.WriteLine($"Posição N°{contadorForeach} - {item}");
//   contadorForeach++;
// }




















//           int[] arrayInteiros = new int[4];

//           arrayInteiros[0] = 72;
//           arrayInteiros[1] = 64;
//           arrayInteiros[2] = 50;
//           arrayInteiros [3] = 1;
          

//           int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
//           Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//           //redimensionando o array
//         //  Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o array com FOR");

//           for(int contador = 0; contador < arrayInteiros.Length; contador++)
//           {
//             Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
//           }















          // Console.WriteLine("Precorrendo o array com ForEach");
          //   int contadorForeach = 0;
          // foreach(int valor in arrayInteiros)
          // {
          //   Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
          //   contadorForeach++;
          // }
























//  string opcao;
//  bool exibirMenu = true;

//  while(exibirMenu)
//  { 
//    Console.Clear();
//    Console.WriteLine("Digite uma opção:");
//    Console.WriteLine("1- Cadastrar Cliente:");
//    Console.WriteLine("2- Buscar Cliente:");
//    Console.WriteLine("3- Apagar Cliente: ");
//    Console.WriteLine("4- Encerrar:");

//   opcao = Console.ReadLine();
  
//   switch(opcao)
//   {
//      case "1":

//      Console.WriteLine("Cadastro de cliente");
//      break;
//      case "2":

//      Console.WriteLine("Busca de cliente");
//      break;
//      case "3":

//      Console.WriteLine("Apagar de cliente");
//      break;
//      case "4":

//      Console.WriteLine("Encerrar");
//      exibirMenu = false;
//      break;

//      default:
//      Console.WriteLine("Opção invalida!");
//      break;
     

//   }

//  } Console.WriteLine("O programa se encerrou!");























// Do Wille

//int soma = 0, numero = 0;

//do
//{
  //  Console.WriteLine("Digite um numero (digite 0 para parar:)");
   // numero = Convert.ToInt32(Console.ReadLine());
  //  soma += numero;

//} while(numero !=0);

//Console.WriteLine($"Total da soma dos números digitados é: {soma}");



















//usando Wille

//int numero = 4;
//int contador = 0;
//while (contador <=10)
//{
//    Console.WriteLine($"{contador + 1}° Execução: {numero}x{contador} = {numero * contador}");
//    contador++;
//    if (contador ==6)
//    {
//        break;
//    }
//}













//usando For
//int numero= 4;
//for(int contador = 0; contador <=10; contador++)
//{
  //  Console.WriteLine($"{numero} x {contador} = {numero*contador}");
//}

//Calculadora calc = new Calculadora();

//calc.Somar(10, 30);
//calc.Subtrair(10,50);
//calc.Multiplicar(15,45);
//calc.dividir(2,2);
//calc.Potencia(3,3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
//calc.raizQuadrada(9);

//int numeroIncremento = 10;

//Console.WriteLine("Incrementando o 10:");
//numero = numero +1;
//numeroIncremento++;
//Console.WriteLine(numeroIncremento);

//int numeroDecremento =20;
//Console.WriteLine("Decrementando o 20:");
//numeroDecremento--;
//Console.WriteLine(numeroDecremento);









// operador NOT

// bool choveu = false;
////bool estaTarde = false;

//if ( !choveu && !estaTarde)
{
   // Console.WriteLine("vou pedalar");

}
//else
//{
 //   Console.WriteLine("Vou pedalar outro dia.");
//}












//Operador AND 

//bool possuiPresencaMinima = true;
//double media = 7.5;

//if (possuiPresencaMinima && media >= 7.5)
//{
 //   Console.WriteLine("Aprovado!");
//}
//else
//{
 //   Console.WriteLine("Reprovado.");
//}






















//operador OR na pratica

//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

///if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//{
 //   Console.WriteLine("Entrada liberada!");
//}
//else
//{
 //   Console.WriteLine("Entrada não liberada.");
//}
































// Console.WriteLine("Digite uma letra:");
 //string letra = Console.ReadLine();
//
// switch(letra)
// {
  //  case "a":
    //case "e":
  //  case "i":
   // case "o":
//    case "u":
//
//    Console.WriteLine("Vogal");
//    break;
//    
//    default:
//    Console.WriteLine("Não é uma vogal.");
//    break;
// }













// Console.WriteLine("Digite uma letra:");
 //string letra = Console.ReadLine();

// if (letra == "a" ||
 //    letra == "e" ||
  //   letra == "i" ||
  //  letra == "o" ||
   //  letra == "u")
  //   {
   //     Console.WriteLine("Volgal");
   //  }
  //   else
  //   {
   //     Console.WriteLine("Não é uma vogal");
    // }




















 //   int quantidadeEmEstoque = 10;
   // int quantidadeCompra = 4;
 //   bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

//    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//    Console.WriteLine($"quantidade da compra: {quantidadeCompra}");
//    Console.WriteLine($"É possível realizar a venda?{possivelVenda}");

//    if (quantidadeCompra == 0)
//    {
//    Console.WriteLine("Venda inválida!");
//    }

//   else if (possivelVenda)  
    
//    {
//     Console.WriteLine("Venda realizada!");
//    }

//    else

//    {
//      Console.WriteLine("Desculpe não temos a quantidade desejada em estoque");
//    }










// Convertendo de maneira segura
// string a = "15-";
// int b = 0;
//int.TryParse(a, out b);
//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");





//Ordem dos Operadores
   // double a = 4/(2+2);
    //Console.WriteLine(a);









 //cast Implícito 

 //int a = 5;
 //double b = a;

 //Console.WriteLine(b);









    //int inteiro = 5;
    //string a = inteiro.ToString();
    ///Console.WriteLine(a);




    //Cast - Casting
    //int a = Convert.ToInt32 ("5");
    //int a = int.Parse("5");

    //Console.WriteLine(a);






//int a = 10;
//int b = 20;

//int c = a + b;

//c = c + 5; //30+5

//c += 5;

//Console.WriteLine(c);


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Fernando";
//pessoa1.Idade = 35;
//pessoa1.Apresentar();
