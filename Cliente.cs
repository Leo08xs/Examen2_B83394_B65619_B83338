using System;

public class Cliente
{
	private int clienteID { set; get; };
	private String nombre { set; get; };
	private String Apellido { set; get; };

	public Cliente(int id,string nom,string apellido)
	{
		clienteID = id;
		nombre = nom;
		Apellido = apellido;

	}

	public Cliente()
	{
	
	}




}
