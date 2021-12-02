using System;

public class ItemVenta
{
	private int itemventaID { set; get; };
	private int cantidadV { set; get; };
	private float precioU { set; get; };
	private Venta numVenta { set; get; };
	private Producto producto { set; get; };

	public ItemVenta(int id, int cant,float pre,Venta venta, Producto producto)
	{
		itemventaID = id;
		cantidadV = cant;
		precioU = pre;
		numVenta = venta;
		producto = producto;
	}


	public ItemVenta()
	{

	}
}
