// See https://aka.ms/new-console-template for more information
using AssignmentDay3;
EmpWageBuilder empWageBuilder = new EmpWageBuilder();
empWageBuilder.addCompanyEmpWage("visionet", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("situs", 10, 4, 20);
empWageBuilder.computeEmpWage();
