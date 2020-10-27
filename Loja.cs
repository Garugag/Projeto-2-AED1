using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Loja
{
	List<string> produtos = new List<string>();
	public void inicio()
	{
		produtos.Add("Arroz,R$12 Code'1'");
		produtos.Add("Arroz,R$12 Code'1'");
		produtos.Add("Arroz,R$12 Code'1'");

		produtos.Add("Batata 0.8Kg,R$3 Code'2'");
		produtos.Add("Batata 0.8Kg,R$3 Code'2'");
		produtos.Add("Batata 0.8Kg,R$3 Code'2'");

		produtos.Add("Batata 1,2kg,R$4.5 Code'3'");
		produtos.Add("Batata 1,2kg,R$4.5 Code'3'");
		produtos.Add("Batata 1,2kg,R$4.5 Code'3'");
	
		produtos.Add("Batata 2kg,R$6 Code'4'");
		produtos.Add("Batata 2kg,R$6 Code'4'");
		produtos.Add("Batata 2kg,R$6 Code'4'");

		produtos.Add("Cafe colombiano,R$2 Code'5'");
		produtos.Add("Cafe colombiano,R$2 Code'5'");
		
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");
		produtos.Add("Cafe marca Java,R$12 Code'6'");

		produtos.Add("Coca-Cola 2,5L,R$6 Code'7'");
		produtos.Add("Coca-Cola 2,5L,R$6 Code'7'");
		produtos.Add("Coca-Cola 2,5L,R$6 Code'7'");
		produtos.Add("Coca-Cola 2,5L,R$6 Code'7'");

		produtos.Add("Coca-Cola 3L,R$7 Code'8'");
		produtos.Add("Coca-Cola 3L,R$7 Code'8'");
		produtos.Add("Coca-Cola 3L,R$7 Code'8'");
		produtos.Add("Coca-Cola 3L,R$7 Code'8'");

		produtos.Add("Coca-cola de abacaixi,R$1.5 Code'9'");
		produtos.Add("Coca-cola de abacaixi,R$1.5 Code'9'");
		produtos.Add("Coca-cola de abacaixi,R$1.5 Code'9'");
		produtos.Add("Coca-cola de abacaixi,R$1.5 Code'9'");
	
		produtos.Add("Cocaina 20g,R$5 Code'10'");
		produtos.Add("Cocaina 20g,R$5 Code'10'");
		produtos.Add("Cocaina 20g,R$5 Code'10'");
		produtos.Add("Cocaina 20g,R$5 Code'10'");

		produtos.Add("Cogomelos Jipis 3Kg,R$21 Code'11'");
		produtos.Add("Cogomelos Jipis 3Kg,R$21 Code'11'");
		produtos.Add("Cogomelos Jipis 3Kg,R$21 Code'11'");
		produtos.Add("Cogomelos Jipis 3Kg,R$21 Code'11'");

		produtos.Add("Feijão 1Kg,R$30 Code'12");
		produtos.Add("Feijão 1Kg,R$30 Code'12");
		produtos.Add("Feijão 1Kg,R$30 Code'12");

		produtos.Add("Ovo 12Un,R$3 Code'13'");
		produtos.Add("Ovo 12Un,R$3 Code'13'");
		produtos.Add("Ovo 12Un,R$3 Code'13'");
		produtos.Add("Ovo 12Un,R$3 Code'13'");

		produtos.Add("Ovo 30Un,R$6 Code'14'");
		produtos.Add("Ovo 30Un,R$6 Code'14'");
		produtos.Add("Ovo 30Un,R$6 Code'14'");
		
	}
	public void listaOpções()
	{
		produtos.Sort();

		foreach (var item in produtos)
		{
			Console.WriteLine(item);
		}
	}


	public void p1()
	{produtos.Remove("Arroz,R$12 Code'1'");}
	
	public void p2()
	{produtos.Remove("Batata 0.8Kg,R$3 Code'2'");}

	public void p3()
	{produtos.Remove("Batata 1,2kg,R$4.5 Code'3'");}

	public void p4()
	{produtos.Remove("Batata 2kg,R$6 Code'4'");}

	public void p5()
	{produtos.Remove("Cafe colombiano,R$2 Code'5'");}
	
	public void p6()
	{produtos.Remove("Cafe marca Java,R$12 Code'6'");}
	
	public void p7()
	{produtos.Remove("Coca-Cola 2,5L,R$6 Code'7'");}
	
	public void p8()
	{produtos.Remove("Coca-Cola 3L,R$7 Code'8'");}
	
	public void p9()
	{produtos.Remove("Coca-cola de abacaixi,R$1.5 Code'9'");}
	
	public void p10()
	{produtos.Remove("Cocaina 20g,R$5 Code'10'");}
	
	public void p11()
	{produtos.Remove("Cogomelos Jipis 3Kg,R$21 Code'11'");}
	
	public void p12()
	{produtos.Remove("Feijão 1Kg,R$30 Code'12");}

	public void p13()
	{produtos.Remove("Ovo 12Un,R$3 Code'13'");}

	public void p14()
	{produtos.Remove("Ovo 30Un,R$6 Code'14'");}


	//limitar a quantia comprada
	public string confer1()
	{
		if (produtos.Contains("Arroz,R$12 Code'1'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer2()
	{
		if (produtos.Contains("Batata 0.8Kg,R$3 Code'2'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer3()
	{
		if (produtos.Contains("Batata 1,2kg,R$4.5 Code'3'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer4()
	{
		if (produtos.Contains("Batata 2kg,R$6 Code'4'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer5()
	{
		if (produtos.Contains("Cafe colombiano,R$2 Code'5'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer6()
	{
		if (produtos.Contains("Cafe marca Java,R$12 Code'6'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer7()
	{
		if (produtos.Contains("Coca-Cola 2,5L,R$6 Code'7'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer8()
	{
		if (produtos.Contains("Coca-Cola 3L,R$7 Code'8'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer9()
	{
		if (produtos.Contains("Coca-cola de abacaixi,R$1.5 Code'9'"))
		{return "1";}
		else {return "0";}
	}
	
	public string confer10()
	{
		if (produtos.Contains("Cocaina 20g,R$5 Code'10'"))
		{return "1";}
		else {return "0";}
	}

	public string confer11()
	{
		if (produtos.Contains("Cogomelos Jipis 3Kg,R$21 Code'11'"))
		{return "1";}
		else {return "0";}
	}

	public string confer12()
	{
		if (produtos.Contains("Feijão 1Kg,R$30 Code'12"))
		{return "1";}
		else {return "0";}
	}

	public string confer13()
	{
		if (produtos.Contains("Ovo 12Un,R$3 Code'13'"))
		{return "1";}
		else {return "0";}
	}

	public string confer14()
	{
		if (produtos.Contains("Ovo 30Un,R$6 Code'14'"))
		{return "1";}
		else {return "0";}
	}
	
}