using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

public class Program
{
    public static void Main(string[] args)
    {
        string keyVaultName = "mazpqltcikv01";
        string secretName = "sqlconnectionstring";

        var keyVaultUri = new Uri($"https://mazpqltcikv01.vault.azure.net/");
        var client = new SecretClient(keyVaultUri, new DefaultAzureCredential());

        try
        {
            KeyVaultSecret secret = client.GetSecret(secretName);
            Console.WriteLine($"Secret value: {secret.Value}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching secret: {ex.Message}");
        }
    }
}
