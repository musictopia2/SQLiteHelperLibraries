namespace SQLiteHelperLibraries;
public class CustomSQLiteConnectionClass : ISQLiteConnector
{
    EnumDatabaseCategory IDbConnector.GetCategory(IDbConnection connection)
    {
        if (connection is System.Data.SQLite.SQLiteConnection)
        {
            return EnumDatabaseCategory.SQLite;
        }
        if (connection is Microsoft.Data.Sqlite.SqliteConnection)
        {
            return EnumDatabaseCategory.SQLite;
        }
        throw new CustomBasicException("Should have been a sql lite connection.  Rethink");
    }
    IDbCommand IDbConnector.GetCommand()
    {
        if (bb1.OS == bb1.EnumOS.Android)
        {
            return new Microsoft.Data.Sqlite.SqliteCommand();
        }
        return new System.Data.SQLite.SQLiteCommand();
    }
    IDbConnection IDbConnector.GetConnection(EnumDatabaseCategory category, string connectionString)
    {
        if (category != EnumDatabaseCategory.SQLite)
        {
            throw new CustomBasicException("Only sqlite is supported for this category.  Rethink");
        }
        if (bb1.OS == bb1.EnumOS.Android)
        {
            return new Microsoft.Data.Sqlite.SqliteConnection(connectionString);
        }
        return new System.Data.SQLite.SQLiteConnection(connectionString);
    }
    DbParameter IDbConnector.GetParameter()
    {
        if (bb1.OS == bb1.EnumOS.Android)
        {
            return new Microsoft.Data.Sqlite.SqliteParameter();
        }
        return new System.Data.SQLite.SQLiteParameter();
    }
}