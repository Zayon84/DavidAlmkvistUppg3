
namespace DavidAlmkvistUppg3.Shared;

public class Company
{
	public string CompanyName { get; set; }
	public bool Applied { get; set; }
	public string Comment { get; set; }
	public String Description { get; set; }
	public string Location { get; set; }

	public Company(string name, bool applied, string comment , string description, string location)
	{
		CompanyName = name;
		Applied = applied;
		Comment = comment;
		Description = description;
		Location = location;
	}
}

