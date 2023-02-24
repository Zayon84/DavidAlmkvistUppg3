
namespace DavidAlmkvistUppg3.Shared;

public class Company
{
	public string CompanyName { get; set; }
	public string Location { get; set; }
	public string Description { get; set; }
	public bool Applied { get; set; }
	public string Comment { get; set; }
	

	public Company(string companyName, string location, string description, bool applied, string comment )
	{
		CompanyName = companyName;
		Location = location;
		Description = description;
		Applied = applied;
		Comment = comment;
	}
}

