using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cliente
{
	private string nome;
	private int idade;
	private string endereço;
	private string sexo;
	private string cartão = "1111-11";
	private string senha = "1111";

	public string Card
	{
		get
		{
			return "Ok";
		}
		set
		{
			if(cartão == value);
		}
	}

	public string Pass
	{
		get
		{
			return "Ok";
		}
		set
		{
			if(senha == value);
		}
	}

	public string Nome
	{
		get
		{
			return nome;
		}
		set
		{
			nome = value;
		}
	}

	public int Idade
	{
		get
		{
			return idade;
		}
		set
		{
			idade = value;
		}
	}

	public string Endereço
	{
		get
		{
			return endereço;
		}
		set
		{
			endereço = value;
		}
	}

	public string Sexo
	{
		get
		{
			return sexo;
		}
		set
		{
			sexo = value;
		}
	}
}