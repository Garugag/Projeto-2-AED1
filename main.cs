using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass 
{
  public static void Main (string[] args) 
	{
		Cliente n = new Cliente();
		Loja l = new Loja();
		Carrinho c = new Carrinho();

		//coloco os itens na lista da loja
		l.inicio();

		//Preencho os dados do cliente
		Console.WriteLine("Bem vindo a nossa loja, se o senhor/a quiser um desconto de 10% ao valor da compra faça o seguinte cadastro. 's' 'n'");
		string respostCadastro = Console.ReadLine();
		
		if (respostCadastro == "s")
		{
			Console.WriteLine("Excelente, insira seu nome a seguir.");
			n.Nome = Console.ReadLine();
			Console.WriteLine("Insira sua idade");
			n.Idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Agora vamos com o endereço");
			n.Endereço = Console.ReadLine();
			Console.WriteLine("O senhor/a é homem, mulher ou outros? 'h' ou 'm'");
			n.Sexo = Console.ReadLine();
			Console.WriteLine("Nome: {0}.\nIdade: {1}.\nEndereço: {2}.\nGenero: {3}", n.Nome, n.Idade, n.Endereço, n.Sexo);
		}
		else
		{
			Console.Write("Outra vez será. ");
		}
		Console.WriteLine("Desfrute de suas compras.\n");
		
		
		//imprime todas as opções
		
		string Item = "hola :-)";
		while(Item != "fim")
		{
			string x = "0";
			Console.WriteLine("Esses são nossos produtos atualmente:\n");
			l.listaOpções();
			Console.Write("\nDigite o codigo do produto para colocar no carrinho\n");
			Item = Console.ReadLine();

			if (Item == "1")
			{
				x = l.confer1();
				if (x == "1")
				{c.p1();}	
				l.p1();
				
			}
			else if (Item == "2")
			{
				x = l.confer2();
				if (x == "1")
				{c.p2();}	
				l.p2();
			}
			else if (Item == "3")
			{
				x = l.confer3();
				if (x == "1")
				{c.p3();}	
				l.p3();
			}
			else if (Item == "4")
			{
				x = l.confer4();
				if (x == "1")
				{c.p4();}	
				l.p4();
			}
			else if (Item == "5")
			{
				x = l.confer5();
				if (x == "1")
				{c.p5();}	
				l.p5();
			}
			else if (Item == "6")
			{
				x = l.confer6();
				if (x == "1")
				{c.p6();}	
				l.p6();
			}
			else if (Item == "7")
			{
				x = l.confer7();
				if (x == "1")
				{c.p7();}	
				l.p7();
			}
			else if (Item == "8")
			{
				x = l.confer8();
				if (x == "1")
				{c.p8();}	
				l.p8();
			}
			else if (Item == "9")
			{
				x = l.confer9();
				if (x == "1")
				{c.p9();}	
				l.p9();
			}
			else if (Item == "10")
			{
				x = l.confer10();
				if (x == "1")
				{c.p10();}	
				l.p10();
			}
			else if (Item == "11")
			{
				x = l.confer11();
				if (x == "1")
				{c.p11();}	
				l.p11();
			}
			else if (Item == "12")
			{
				x = l.confer12();
				if (x == "1")
				{c.p12();}	
				l.p12();
			}
			else if (Item == "13")
			{
				x = l.confer13();
				if (x == "1")
				{c.p13();}	
				l.p13();
			}
			else if (Item == "14")
			{
				x = l.confer14();
				if (x == "1")
				{c.p14();}	
				l.p14();
			}
			
			l.listaOpções();
			
			c.mycar();
			
			Console.WriteLine("Continuar comprando? 's', 'n'");
			string Continuar = Console.ReadLine();
			if (Continuar == "n")
			{Item = "fim";}
		}
		c.mycar();
		Console.Write("O valor total a pagar é de: ");
		Console.WriteLine(c.montante());
		Console.WriteLine("\nDeseja tirar algum item do carrinho? se quiser digite 's' caso não queira aperte 'n'");
		if (char.Parse(Console.ReadLine()) == 's')
		{
			// digite o numero que do produto que não quira mais, lembrando que para o primeiro produto se deve digitar '1', para o segundo '2' e assim vai.
			string Y = "w";
			while(Y != "n")
			{
				c.mycar();
				Console.WriteLine("Qual item deseja tirar?");
				c.Tirar = int.Parse(Console.ReadLine());
				c.mycar();
				Console.WriteLine("Continuar tirando? 's', 'n'");
				Y = Console.ReadLine();
			}
		}
		c.mycar();
			Console.Write("O valor total a pagar é de: ");
			//os 10% de desconto por cadastro
			if (respostCadastro == "s")
		  {
				Console.WriteLine("R$"+(0.9*c.montante()));
			}
			else
			{
				Console.WriteLine(c.montante());
			}
			Console.WriteLine("Digite o numero da conta do cartão de credito");
			n.Card = Console.ReadLine();
			if (n.Card == "Ok")
			{
				Console.WriteLine("Digite a senha");
				n.Pass = Console.ReadLine();
				if (n.Pass == "Ok")
				{
					Console.WriteLine("Compra efetuada perfeitamente, tenha um bom proveito");
				}
			}
			
  }
	
}
