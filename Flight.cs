using System;

[Serializable]
public class Flight
{

	public int Id { get; set; }
	public string EntityName { get; set; }
	public string AicroftType { get; set; }
    public int Speed { get; set; }
	public Location Location { get; set; }
	public Size Size { get; set; }



    public Flight()
	{
	}
}
