using DavidAlmkvistUppg3.Server.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DavidAlmkvistUppg3.Server.DataAccess
{
	public class CompanyContext:DbContext
	{
		public DbSet<CompanyModel> Company { get; set; }


		public CompanyContext(DbContextOptions options) : base(options)
		{
		}
	}
}
