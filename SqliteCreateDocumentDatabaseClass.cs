namespace SQLiteHelperLibraries;
public static class SqliteCreateDocumentDatabaseClass
{
    public static void RegisterCreatingDocumentDatabase()
    {
        dd1.CreateSqliteDatabase = CreateSqliteDatabase;
    }
    private static void CreateSqliteDatabase(string path)
    {
        string connectionString = $"Data Source={path};Version=3;";
        SQLiteConnection m_dbConnection = new(connectionString);
        m_dbConnection.Open();
        string sql;
        SQLiteCommand command;
        sql = "Create Table DocumentTable (ID INTEGER PRIMARY KEY AutoIncrement, DatabaseName Text, CollectionName Text, JsonData Text)";
        command = new(sql, m_dbConnection);
        command.ExecuteNonQuery();
    }
}