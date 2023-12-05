using System;

public sealed class ApiKeySingleton
{
    private static ApiKeySingleton instance;
    private string apiKey;

    private ApiKeySingleton()
    {
        apiKey = "your_api_key_here";
    }

    public static ApiKeySingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ApiKeySingleton();
            }
            return instance;
        }
    }

    public string ApiKey
    {
        get { return apiKey; }
    }
}

class Program
{
    static void Main()
    {
        ApiKeySingleton apiKeySingleton = ApiKeySingleton.Instance;

        string apiKey = apiKeySingleton.ApiKey;
        
        Console.WriteLine("API Key: " + apiKey);
    }
}