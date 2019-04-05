using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR

{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson: IPerson
    {
        
        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */

        // MARK: - IPerson interface
        private IName _name;
        public IName Name 
        {
            get 
            {
                return _name;
            }

            set 
            {
                var oldValue = _name;
                _name = value;
                NameChange?.Invoke(this, new ValueChangeEventArgs<IName>(oldValue));
            }
        }

        // MARK: - Methods 
        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
    }
}
