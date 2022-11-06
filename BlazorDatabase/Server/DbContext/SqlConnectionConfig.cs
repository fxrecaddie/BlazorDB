namespace BlazorDatabase.Server.DbContext
{
    public class SqlConnectionConfig
    {
        public SqlConnectionConfig(string value) => Value = value;
        public string Value { get; set; }
    }
}
