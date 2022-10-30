using MyGuide.BLL;
using MyGuide.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

const string BPMPolicy = "MyGuidePolicy";

builder.Services.AddControllers();

builder.Services.AddCors(options => options.AddPolicy(BPMPolicy, builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithExposedHeaders("Token-Expired");
}));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICityService, CityService>();

BLLModule.Load(builder.Services, builder.Configuration);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
