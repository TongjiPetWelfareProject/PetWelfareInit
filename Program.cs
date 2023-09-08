using Database_CourseDesign;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
ManageSystemInit manageSystemInit = new ManageSystemInit();
manageSystemInit.PreInit();
app.Run();

