using System;

public class Venta
{
	private int numeroV { set; get; };
	private DateTime Fecha { set; get; };;
	private Cliente cliente { set; get; };;

	public Venta(int num, DateTime fech, Cliente cli) 
	{
		numeroV = num;
		Fecha = fech;
		cliente = cli;
	}

	public Venta()
	{
	}
}
