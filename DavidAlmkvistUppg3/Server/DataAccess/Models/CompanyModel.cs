namespace DavidAlmkvistUppg3.Server.DataAccess.Models;

public class CompanyModel
{
	public Guid Id { get; set; }
	public string CompanyName { get; set; }
	public string Location { get; set; }
	public string Description { get; set; }
	public bool Applied { get; set; }
	public string Comment { get; set; }

}
