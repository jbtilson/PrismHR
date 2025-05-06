namespace PrismHRAPI.Extensions;

internal static class IntExtensions
{

    /// <summary>
    /// Converts the provided client id number to a formatted/padded client id string
    /// </summary>
    /// <returns></returns>
    internal static string ToClientId(this int forClientID)
    {
        switch (forClientID)
        {
            case 77:
                return forClientID.ToString();
            default:
                return forClientID.ToString().PadLeft(6, '0');
        }
    }

    /// <summary>
    /// Converts the provided client id number to a formatted/padded client id string
    /// </summary>
    /// <returns></returns>
    internal static string ToClientId(this int? forClientID)
    {
        if (forClientID == null) return string.Empty;

        var cidString = forClientID.ToString() ?? string.Empty;
        if (cidString == string.Empty) return string.Empty;

        switch (forClientID)
        {
            case 77:
                return cidString;
            default:
                return cidString.PadLeft(6, '0');
        }
    }
}

