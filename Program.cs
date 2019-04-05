using System;

using Practice.HR;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = Builders.ClientBuilder()
                .Name("Иван", "Иванов", "Иванович") 
                .Discount(.1f)
                .Build();

            IEmployee employee = Builders.EmployeeBuilder()
                .Name("Григорий", "Сидоров", "Петрович")
                .Department("Бухгалтерия")
                .Build();

            /*
             * TODO #8: Собрать приложение. 
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             */

            /*
             *  Employee
             *
             *  Department [IDepartment] : Name [string]: "Бухгалтерия"
             *
             *  Name [IName]:
             *      FirstName [string]: "Григорий"
             *      FullName [stirng]: "Сидоров Григорий Петрович"
             *      Patronymic [string]: "Петрович"
             *      ShortName [string]: "Г.П. Сидоров"
             *      Surname [string]: "Сидоров"
             */

            /*
             *  Client
             *
             *  Name [IName]:
             *      FirstName [string]: "Иван"
             *      FullName [stirng]: "Иванов Иван Иванович"
             *      Patronymic [string]: "Иванович"
             *      ShortName [string]: "И.И. Иванов"
             *      Surname [string]: "Иванов"
            */
        }
    }
}
