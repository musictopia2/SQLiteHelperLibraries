namespace SQLiteHelperLibraries;
public static class SqliteCreateDocumentDatabaseClass
{
    public static void RegisterCreatingDocumentDatabase()
    {
        if (bb1.OS == bb1.EnumOS.Android)
        {
            dd1.CreateSqliteDatabase = AndroidCreateSqliteDatabase;
        }
        else
        {
            dd1.CreateSqliteDatabase = DesktopCreateSqliteDatabase;
        }
    }
    private static void AndroidCreateSqliteDatabase(string path)
    {
        string connectionString = $"Data Source={path};Version=3;";
        Microsoft.Data.Sqlite.SqliteConnection m_dbConnection = new(connectionString);
        m_dbConnection.Open();
        string sql;
        Microsoft.Data.Sqlite.SqliteCommand command;
        sql = "Create Table DocumentTable (ID INTEGER PRIMARY KEY AutoIncrement, DatabaseName Text, CollectionName Text, Data Text)";
        command = new(sql, m_dbConnection);
        command.ExecuteNonQuery();
    }
    private static void DesktopCreateSqliteDatabase(string path)
    {
        string connectionString = $"Data Source={path};Version=3;";
        System.Data.SQLite.SQLiteConnection m_dbConnection = new(connectionString);
        m_dbConnection.Open();
        string sql;
        System.Data.SQLite.SQLiteCommand command;
        sql = "Create Table DocumentTable (ID INTEGER PRIMARY KEY AutoIncrement, DatabaseName Text, CollectionName Text, Data Text)";
        command = new(sql, m_dbConnection);
        command.ExecuteNonQuery();
    }
}