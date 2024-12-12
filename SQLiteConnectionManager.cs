namespace SQLiteHelperLibraries;
public class SQLiteConnectionManager : IDatabaseConnectionManager
{
    EnumDatabaseCategory IDatabaseConnectionManager.PrepareDatabase()
    {
        dd1.SQLiteConnector ??= new CustomSQLiteConnectionClass();
        return EnumDatabaseCategory.SQLite;
    }
}