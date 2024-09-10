using UserManagement.Application;
using UserManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplicationServices();
    builder.Services.AddInfrastructure();
    builder.Services.AddSwaggerGen();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
}


var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

