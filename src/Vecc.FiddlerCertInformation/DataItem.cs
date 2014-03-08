namespace Vecc.FiddlerCertInformation
{
    internal class DataItem
    {
        #region Public Properties

        public string Name { get; private set; }
        public string Value { get; private set; }

        #endregion Public Properties

        #region Constructors

        public DataItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public DataItem(string name, int value)
        {
            Name = name;
            Value = value.ToString();
        }

        public DataItem(string name, bool value)
        {
            Name = name;

            if (value)
            {
                Value = "Yes";
            }
            else
            {
                Value = "No";
            }
        }

        #endregion Constructors
    }
}
