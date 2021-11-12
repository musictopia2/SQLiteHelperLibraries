namespace SQLiteHelperLibraries;
public class CustomSQLiteConnectionClass : ISQLiteConnector
{
    EnumDatabaseCategory IDbConnector.GetCategory(IDbConnection connection)
    {
        if (connection is SQLiteConnection == false)
        {
            throw new CustomBasicException("Should have been a sql lite connection.  Rethink");
        }
        return EnumDatabaseCategory.SQLite;
    }
    IDbConnection IDbConnector.GetConnection(EnumDatabaseCategory category, string connectionString)
    {
        if (category != EnumDatabaseCategory.SQLite)
        {
            throw new CustomBasicException("Only sqlite is supported for this category.  Rethink");
        }
        return new SQLiteConnection(connectionString);
    }
}