using DavidAlmkvistUppg3.Server.DataAccess.Models;
using DavidAlmkvistUppg3.Shared;

namespace DavidAlmkvistUppg3.Server.DataAccess
{
	public class CompanyRepository
	{
		private readonly CompanyContext _context;

		public CompanyRepository(CompanyContext context)
		{
			_context = context;
		}

		public void Add(Company company)
		{
			var newCompanyModel = new CompanyModel();

			newCompanyModel.CompanyName = company.CompanyName;
			newCompanyModel.Location = company.Location;
			newCompanyModel.Description = company.Description;
			newCompanyModel.Applied = company.Applied;
			newCompanyModel.Comment = company.Comment;

			_context.Company.Add(newCompanyModel);
			_context.SaveChanges();
		}

		public IEnumerable<Company> GetAll()
		{
			return _context.Company.Select(cm => new Company(cm.CompanyName, cm.Location, cm.Description, cm.Applied, cm.Comment));
		}
	}
}
