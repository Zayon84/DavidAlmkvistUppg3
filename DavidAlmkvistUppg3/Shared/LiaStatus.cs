namespace DavidAlmkvistUppg3.Shared;

public class LiaStatus
{
	public Guid CompanyID { get; set; }
	public bool Applied { get; set; }
	public DateTime AppliedDate { get; set; }
	public string Comment { get; set; }

	public LiaStatus(Guid companyId, bool applied, DateTime appliedDate, string comment)
	{
		CompanyID = companyId;
		Applied = applied;
		AppliedDate = appliedDate;
		Comment = comment;
	}
}