namespace Ludibuks.Infrastructure.Data;

public static class DatabasePathHelper
{
    public static string GetConnectionString(string databaseName = "ludibuks.db")
    {
        // Almacenado seguro en %LocalAppData%/Ludibuks/ludibuks.db
        var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ludibuks");
        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
        return $"Data Source={Path.Combine(folder, databaseName)}";
    }
}
