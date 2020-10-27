using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Carrinho
{
	int tirar;
	List<string> MeuCarrinho = new List<string>();

	public void p1()
	{MeuCarrinho.Add("Arroz");}

	public void p2()
	{MeuCarrinho.Add("Batata 0.8Kg");}

	public void p3()
	{MeuCarrinho.Add("Batata 1,2kg");}

	public void p4()
	{MeuCarrinho.Add("Batata 2kg");}

	public void p5()
	{MeuCarrinho.Add("Cafe colombiano");}

	public void p6()
	{MeuCarrinho.Add("Cafe marca Java");}

	public void p7()
	{MeuCarrinho.Add("Coca-Cola 2,5L");}

	public void p8()
	{MeuCarrinho.Add("Coca-Cola 3L");}

	public void p9()
	{MeuCarrinho.Add("Coca-cola de abacaixi");}

	public void p10()
	{MeuCarrinho.Add("Cocaina 20g");}
	
	public void p11()
	{MeuCarrinho.Add("Cogomelos Jipis 3Kg");}
	
	public void p12()
	{MeuCarrinho.Add("Feijão 1Kg");}
	
	public void p13()
	{MeuCarrinho.Add("Ovo 12Un");}
	
	public void p14()
	{MeuCarrinho.Add("Ovo 30Un");}

	//Hora de saber o preço
	public double montante()
	{
		MeuCarrinho.Sort();
		double monto = 0;
		foreach (var item in MeuCarrinho)
		{
			if (item == "Arroz"){monto += 12;}
			else if (item == "Batata 0.8Kg"){monto += 3;}
			else if (item == "Batata 1,2kg"){monto += 4.5;}
			else if (item == "Batata 2kg"){monto += 6;}
			else if (item == "Cafe colombiano"){monto += 2;}
			else if (item == "Cafe marca Java"){monto += 12;}
			else if (item == "Coca-Cola 2,5L"){monto += 6;}
			else if (item == "Coca-Cola 3L"){monto += 7;}
			else if (item == "Coca-cola de abacaixi"){monto += 1.5;}
			else if (item == "Cocaina 20g"){monto += 5;}
			else if (item == "Cogomelos Jipis 3Kg"){monto += 21;}
			else if (item == "Feijão 1Kg"){monto += 30;}
			else if (item == "Ovo 12Un"){monto += 3;}
			else if (item == "Ovo 30Un"){monto += 6;}
		}
		return monto;
	}

	public void mycar()
	{
		MeuCarrinho.Sort();
		Console.WriteLine("\nSeu carrinho contem:");
		foreach (var item in MeuCarrinho)
		{
			
			Console.WriteLine(item);
		}
	}
	public int Tirar
	{
		set
		{
			tirar = value;
			MeuCarrinho.Remove(MeuCarrinho[tirar-1]);
		}
	}	


}