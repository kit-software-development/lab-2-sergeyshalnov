using System;
using Practice.Organization;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */

        private IDepartment _department;
        public IDepartment Department
        {
            get => _department;
            set
            {
                var oldValue = _department;
                _department = value;
                DepartmentChange?.Invoke(this, new ValueChangeEventArgs<IDepartment>(oldValue));
            }
        }

        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
