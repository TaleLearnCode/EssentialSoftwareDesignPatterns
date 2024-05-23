#nullable disable

namespace Builder;

// Product
public class Pizza
{
	public string Crust { get; set; }
	public string Sauce { get; set; }
	public List<string> Topping { get; set; } = [];
}