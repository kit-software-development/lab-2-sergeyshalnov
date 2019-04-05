

using Practice.Common;
using Practice.Organization;

namespace Practice.HR 
{

    class EmployeeBuilder : IEmployeeBuilder
    {
        Employee EmployeeToBuild { get; set; }

        public IEmployee Build()
        {
            var EmployeeReference = EmployeeToBuild;
            EmployeeToBuild = null;
            return EmployeeReference;
        }

        public IEmployeeBuilder Department(IDepartment department)
        {
            isExist();
            EmployeeToBuild.Department = department;
            return this;
        }

        public IEmployeeBuilder Department(string department)
        {
            isExist();
            EmployeeToBuild.Department = new Department(department);
            return this;
        }

        public IEmployeeBuilder Name(IName name)
        {
            isExist();
            EmployeeToBuild.Name = new Name(name);
            return this;
        }

        public IEmployeeBuilder Name(string name, string surname, string patronymic)
        {
            isExist();
            EmployeeToBuild.Name = new Name(name, surname, patronymic);
            return this;
        }

        private void isExist() {
            if (EmployeeToBuild is null) 
            {
                EmployeeToBuild = new Employee();
            }
        }
    }

}