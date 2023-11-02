using NVelocity;
using NVelocity.App;

VelocityEngine ve = new VelocityEngine();
ve.Init();

VelocityContext context = new VelocityContext();

//Khai báo biến
context.Put("variable1", "Value 1");
context.Put("variable2", "Value 2");

//Khai báo list
List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
context.Put("items", items);


Template template = ve.GetTemplate("layout.html");

System.IO.StringWriter writer = new System.IO.StringWriter();
template.Merge(context, writer);

string result = writer.ToString();
Console.WriteLine(result);