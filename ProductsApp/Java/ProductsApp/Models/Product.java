package ProductsApp.Models;

public class Product
{
	private int privateId;
	public final int getId()
	{
		return privateId;
	}
	public final void setId(int value)
	{
		privateId = value;
	}
	private String privateName;
	public final String getName()
	{
		return privateName;
	}
	public final void setName(String value)
	{
		privateName = value;
	}
	private String privateCategory;
	public final String getCategory()
	{
		return privateCategory;
	}
	public final void setCategory(String value)
	{
		privateCategory = value;
	}
	private java.math.BigDecimal privatePrice = new java.math.BigDecimal(0);
	public final java.math.BigDecimal getPrice()
	{
		return privatePrice;
	}
	public final void setPrice(java.math.BigDecimal value)
	{
		privatePrice = value;
	}
}