using System.ComponentModel;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string data = await GetDataFromServerAsync();
    }

    public static async Task<string> GetDataFromServerAsync()
    {
        var client = new HttpClient();
        string result = await client.GetStringAsync("https://example.com");
        return result;
    }
}