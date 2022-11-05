

using Microsoft.EntityFrameworkCore;
namespace CRM_Application.DAL;

public class CRMDbContext:DbContext
{
	public DbSet<Product> Products { get; set; }

	public DbSet<Customer> Customers { get; set; }

	public DbSet<OrderHeader> OrderHeaders { get; set; }

	public DbSet<OrderDetials> OrderDetials { get; set; }

	public DbSet<CustomerAddress> CustomerAddresses { get; set; }

	public DbSet<OrderShippingAddress> OrderShippingAddresses { get; set; }

	public DbSet<OrderBillingAddress> OrderBillingAddresses { get; set; }


	public CRMDbContext(DbContextOptions options):base(options)
	{
	}
}
