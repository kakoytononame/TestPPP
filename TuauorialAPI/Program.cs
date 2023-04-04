using Microsoft.EntityFrameworkCore;
using TuauorialAPI.Data;
using TuauorialAPI.Service.ConnectionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// ���������� ��������
ConnectionService.ConnectService(builder);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//����������� � ��
builder.Services.AddDbContext<DataContext>(op =>
{
    // ����� ��������� ����������� � ��
    op.UseNpgsql(builder.Configuration.GetConnectionString("EmployeeAppCon"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
