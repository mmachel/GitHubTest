//Frage 1
class MayaKalender
{
	private int kin;

	public int Kin
	{
		get{return kin;}
		set{kin = value;}
	}
	public int Uinal
	{
		get{return 20*kin;}
		set{kin = value;}
	}
	public int Tun
	{
		get{return 360*kin;}
		set{kin = value;}
	}
	public int Katun
	{
		get{return 7200*kin;}
		set{kin = value;}
	}
	public int Baktun
	{
		get{return 14400*kin;}
		set{kin = value;}
	}
	public int getTage()
	{
		return (Kin + Uinal + Tun + Katun + Baktun);
	}
}
//Frage 2
class Scrollbar
{
	public void Show()
	{
		Console.WriteLine("Scrolling");
	}
}
class ClientArea
{
	public void Show()
	{
		Console.WriteLine("Client Area");
	}
}
class View
{
	private ClientArea clientarea = new ClientArea();
	public virtual void Show()
	{
		clientarea.Show();
	}
}
class Scrollview: View
{
	private Scrollbar horizontal, vertical;
	public override void Show()
	{
		horizontal.Show();
		vertical.Show();
	}
}
// a) Es soll eine override an Show von Scrollview für die Zugriff an der virtuellen Methode Show()
//von der Klasse View 
//b
var views = new View[5];