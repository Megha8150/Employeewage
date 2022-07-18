// See https://aka.ms/new-console-template for more information
using AssignmentDay3;
EmployeeWage visionet = new EmployeeWage("visionet", 20, 2, 10);
EmployeeWage situs = new EmployeeWage("Situs", 10, 4, 20);
visionet.Employee();
Console.WriteLine(visionet.ToString());
situs.Employee();
Console.WriteLine(situs.ToString());
