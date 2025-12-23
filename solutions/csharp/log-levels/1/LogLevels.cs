static class LogLine
{
    public static string Message(string logLine)
    {
        int i = logLine.IndexOf(":");
        return logLine[(i+2)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[");
        int end = logLine.IndexOf("]");
        return logLine.Substring(start+1, end-1).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        string m = Message(logLine);
        string l = LogLevel(logLine);
        return $"{m} ({l})";
    }
}
