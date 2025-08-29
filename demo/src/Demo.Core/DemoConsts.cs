using Demo.Debugging;

namespace Demo;

public class DemoConsts
{
    public const string LocalizationSourceName = "Demo";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c5d5b53ef08341d586b64c4516070414";
}
