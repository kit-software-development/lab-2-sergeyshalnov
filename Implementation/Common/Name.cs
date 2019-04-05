namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name: IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */

        public string FirstName { get; }
        public string Surname { get; }
        public string Patronymic { get; }

        // MARK: - IName Interface 
        public string FullName { get; }
        public string ShortName { get; }

        // MARK: - Initialization

        public Name(string FirstName, string Surname, string Patronymic) 
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Patronymic = Patronymic;

            this.FullName = FormatFullName(FirstName, Surname, Patronymic);
            this.ShortName = FormatShortName(FirstName, Surname, Patronymic);
        }

        public Name(IName Name) 
        {
            this.FullName = Name.FullName;
            this.ShortName = Name.ShortName;

            var split = Name.FullName.Split(' ');

            this.FirstName = split[0];
            this.Surname = split[1];
            this.Patronymic = split[2];
        }

        // MARK: - Private functions

        private static string FormatFullName(string FirstName, string Surname, string Patronymic) 
        {
            return $"{Surname} {FirstName} {Patronymic}";
        }

        private static string FormatShortName(string FirstName, string Surname, string Patronymic)
        {
            var FirstSymbol = FirstName.ToUpper().Substring(0, 1);
            var SecondSymbol = Patronymic.ToUpper().Substring(0, 1);

            return $"{FirstSymbol}.{SecondSymbol}. {Surname}";
        }

    }
}
