namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department: IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */

         // MAKR: - IDepartment interface
        public string Name { get; }

        // MARK: - Initialization
        public Department(string Name) 
        {
            this.Name = Name;
        }
    }
}
