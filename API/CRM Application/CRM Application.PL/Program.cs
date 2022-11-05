using CRM_Application.BL;
using CRM_Application.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();

#region default servces
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Connection To Database
builder.Services.AddDbContext<CRMDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
#endregion

#region inject Repos
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<ICustomerAddressRepo, CustomerAddressRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
#endregion

#region inject Manager DTos
builder.Services.AddScoped<ICustomerManager, CustomerManager>();
builder.Services.AddScoped<IAddressManager, AddressManager>();
builder.Services.AddScoped<IproductManager, ProductManager>();
#endregion

#region inject UnitofWork
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
#endregion

#region 
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
#endregion

#region Middleware
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c=>c
.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion