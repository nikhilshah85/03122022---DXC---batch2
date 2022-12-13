var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(policyset =>
{

    //policyset.AddPolicy("productControllerPolicy", policy =>
    //{
    //    policy.WithOrigins(new string[] { "https://www.google.com", "https://localhost:7156/Products/ShowProducts", "https://www.iiht.com", "http://www.dxc.com" })
    //          .WithMethods(new string[] { "GET", "PUT" })
    //          .AllowAnyHeader();
    //});

    //policyset.AddPolicy("employeeManagementPolicy", policy =>
    //{
    //    policy.WithOrigins(new string[] { "https://www.iiht.com", "http://www.dxc.com" })
    //          .WithMethods(new string[] { "GET", "PUT", "DELETE" })
    //          .AllowAnyHeader();
    //});


    policyset.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });

    

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
