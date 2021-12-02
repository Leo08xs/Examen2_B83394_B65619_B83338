using System;

public class Producto
{
	private int productoID { set; get; };
	private String descrepcion { set; get; };
	private String preparacion { set; get; };

	public Producto(int id,string desc,string prepa) 
	{
		productoID = prepa;
		descrepcion = desc;
		preparacion = prepa;
	}

	public Producto()
	{
	}
}
