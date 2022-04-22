namespace MIME_Dictionary;

public static class MimeTypes
{
    public static Dictionary<string, List<string>> MimeDictionary { get; set; } = new();

    static MimeTypes()
    {
        #region Add Mime Type and Extensions
        MimeDictionary.Add(".aac", new List<string> { "audio/aac" });
        MimeDictionary.Add(".abw", new List<string> { "application/x-abiword" });
        MimeDictionary.Add(".arc", new List<string> { "application/x-freearc" });
        MimeDictionary.Add(".avi", new List<string> { "video/x-msvideo" });
        MimeDictionary.Add(".azw", new List<string> { "application/vnd.amazon.ebook" });
        MimeDictionary.Add(".bin", new List<string> { "application/octet-stream" });
        MimeDictionary.Add(".bmp", new List<string> { "image/bmp" });
        MimeDictionary.Add(".bz", new List<string> { "application/x-bzip" });
        MimeDictionary.Add(".bz2", new List<string> { "application/x-bzip2" });
        MimeDictionary.Add(".csh", new List<string> { "application/x-csh" });
        MimeDictionary.Add(".css", new List<string> { "text/css" });
        MimeDictionary.Add(".csv", new List<string> { "text/csv" });
        MimeDictionary.Add(".doc", new List<string> { "application/msword" });
        MimeDictionary.Add(".docx", new List<string> { "application/vnd.openxmlformats-officedocument.wordprocessingml.document" });
        MimeDictionary.Add(".eot", new List<string> { "application/vnd.ms-fontobject" });
        MimeDictionary.Add(".epub", new List<string> { "application/epub+zip" });
        MimeDictionary.Add(".gz", new List<string> { "application/gzip" });
        MimeDictionary.Add(".gif", new List<string> { "image/gif" });
        MimeDictionary.Add(".htm", new List<string> { "text/html" });
        MimeDictionary.Add(".html", new List<string> { "" });
        MimeDictionary.Add(".ico", new List<string> { "image/vnd.microsoft.icon" });
        MimeDictionary.Add(".ics", new List<string> { "text/calendar" });
        MimeDictionary.Add(".jar", new List<string> { "application/java-archive" });
        MimeDictionary.Add(".jpeg", new List<string> { "image/jpeg" });
        MimeDictionary.Add(".jpg", new List<string> { "" });
        MimeDictionary.Add(".js", new List<string> { "text/javascript" });
        MimeDictionary.Add(".json", new List<string> { "application/json" });
        MimeDictionary.Add(".jsonld", new List<string> { "application/ld+json" });
        MimeDictionary.Add(".mid", new List<string> { "audio/midi audio/x-midi" });
        MimeDictionary.Add(".midi", new List<string> { "" });
        MimeDictionary.Add(".mjs", new List<string> { "text/javascript" });
        MimeDictionary.Add(".mp3", new List<string> { "audio/mpeg" });
        MimeDictionary.Add(".mpeg", new List<string> { "video/mpeg" });
        MimeDictionary.Add(".mpkg", new List<string> { "application/vnd.apple.installer+xml" });
        MimeDictionary.Add(".odp", new List<string> { "application/vnd.oasis.opendocument.presentation" });
        MimeDictionary.Add(".ods", new List<string> { "application/vnd.oasis.opendocument.spreadsheet" });
        MimeDictionary.Add(".odt", new List<string> { "application/vnd.oasis.opendocument.text" });
        MimeDictionary.Add(".oga", new List<string> { "audio/ogg" });
        MimeDictionary.Add(".ogv", new List<string> { "video/ogg" });
        MimeDictionary.Add(".ogx", new List<string> { "application/ogg" });
        MimeDictionary.Add(".opus", new List<string> { "audio/opus" });
        MimeDictionary.Add(".otf", new List<string> { "font/otf" });
        MimeDictionary.Add(".png", new List<string> { "image/png" });
        MimeDictionary.Add(".pdf", new List<string> { "application/pdf" });
        MimeDictionary.Add(".php", new List<string> { "application/x-httpd-php" });
        MimeDictionary.Add(".ppt", new List<string> { "application/vnd.ms-powerpoint" });
        MimeDictionary.Add(".pptx", new List<string> { "application/vnd.openxmlformats-officedocument.presentationml.presentation" });
        MimeDictionary.Add(".rar", new List<string> { "application/vnd.rar" });
        MimeDictionary.Add(".rtf", new List<string> { "application/rtf" });
        MimeDictionary.Add(".sh", new List<string> { "application/x-sh" });
        MimeDictionary.Add(".svg", new List<string> { "image/svg+xml" });
        MimeDictionary.Add(".swf", new List<string> { "application/x-shockwave-flash" });
        MimeDictionary.Add(".tar", new List<string> { "application/x-tar" });
        MimeDictionary.Add(".tif", new List<string> { "image/tiff" });
        MimeDictionary.Add(".tiff", new List<string> { "" });
        MimeDictionary.Add(".ts", new List<string> { "video/mp2t" });
        MimeDictionary.Add(".ttf", new List<string> { "font/ttf" });
        MimeDictionary.Add(".txt", new List<string> { "text/plain" });
        MimeDictionary.Add(".vsd", new List<string> { "application/vnd.visio" });
        MimeDictionary.Add(".wav", new List<string> { "audio/wav" });
        MimeDictionary.Add(".weba", new List<string> { "audio/webm" });
        MimeDictionary.Add(".webm", new List<string> { "video/webm" });
        MimeDictionary.Add(".webp", new List<string> { "image/webp" });
        MimeDictionary.Add(".woff", new List<string> { "font/woff" });
        MimeDictionary.Add(".woff2", new List<string> { "font/woff2" });
        MimeDictionary.Add(".xhtml", new List<string> { "application/xhtml+xml" });
        MimeDictionary.Add(".xls", new List<string> { "application/vnd.ms-excel" });
        MimeDictionary.Add(".xlsx", new List<string> { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" });
        MimeDictionary.Add(".xml", new List<string> { "text/xml" });
        MimeDictionary.Add(".xul", new List<string> { "application/vnd.mozilla.xul+xml" });
        MimeDictionary.Add(".zip", new List<string> { "application/zip" });
        MimeDictionary.Add(".3gp", new List<string> { "video/3gpp" });
        MimeDictionary.Add(".3g2", new List<string> { "video/3gpp2" });
        MimeDictionary.Add(".7z", new List<string> { "application/x-7z-compressed" });

        // Extensions with multiple MIME types
        MimeDictionary[".xml"].Add("application/xml");
        MimeDictionary[".3gp"].Add("audio/3gpp");
        MimeDictionary[".3g2"].Add("audio/3gpp2");




        #endregion
    }
    /// <summary>
    /// Get MIME type from extension
    /// </summary>
    /// <param name="extension"></param>
    /// <returns>MIME type</returns>
    public static string GetMimeType(this string extension)
    {
        return MimeDictionary[extension][0];
    }
    /// <summary>
    /// Get list of all existing MIME types
    /// </summary>
    /// <param name="extension"></param>
    /// <returns></returns>
    public static List<string> GetMimeTypeS(this string extension)
    {
        return MimeDictionary[extension];
    }
    /// <summary>
    /// Get extension from MIME type
    /// </summary>
    /// <param name="mimeType"></param>
    /// <returns>extension</returns>
    public static string GetExtension(this string mimeType)
    {
        return MimeDictionary.First(x => x.Value.Contains(mimeType)).Key;
    }
}
