namespace SQLiteHelperLibraries;
//specialized
public class SQLServerConnectionManager : IDatabaseConnectionManager
{
    EnumDatabaseCategory IDatabaseConnectionManager.PrepareDatabase()
    {
        dd1.SQLiteConnector ??= new CustomSQLiteConnectionClass();
        return EnumDatabaseCategory.SQLServer;
    }
}