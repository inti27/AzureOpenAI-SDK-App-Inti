using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;

namespace AzureOpenAI_SDK_App;

// Keep it secret, keep it safe. It is precious to us.
public static class KeyManager
{
    private static readonly IConfigurationBuilder ConfigurationBuilder = new ConfigurationBuilder().AddUserSecrets<Program>();
    private static readonly IConfiguration Config = ConfigurationBuilder.Build();

    public static bool UseAzure { get; set; } = true;

    // This is the key that you get from the OpenAI or Azure websites.
    // It's a secret, so we don't want to check it into source control.
    // Instead, we'll use the .NET user secrets feature to store it locally.
    //public static string SecretKey => UseAzure ? Config["AzureOpenAIKey"] : Config["OpenAIKey"];
    public static string SecretKey => "30f46bcc2ea7469b89f704c45e7e556c";

    // These are the URLs and model names for the Azure OpenAI service. They are different from the OpenAI service
    // and are only needed if you're using the Azure service because they'll be unique to your Azure deployment.
    //public static string AzureOpenAIUrl => Config["AzureOpenAIUrl"];
    public static string AzureOpenAIUrl => "https://inti-ai-sample.openai.azure.com/";


    //public static string AzureOpenAIModel => Config["AzureOpenAIModel"];
    public static string AzureOpenAIModel => "GPT16K";

    ////used for sotring the inbound prompts
    //public class MyChatMessage
    //{
    //    public string role { get; set; }
    //    public string content { get; set; }
    //}

}