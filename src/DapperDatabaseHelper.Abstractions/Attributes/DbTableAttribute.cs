namespace DapperDatabaseHelper.Abstractions.Attributes;

public class DbTableAttribute(string name) : Attribute
{
    public string Name => name;
}