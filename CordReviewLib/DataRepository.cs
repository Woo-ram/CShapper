namespace CordReviewLib
{
    public static class DataRepository
    {
        public static UserData User { get; set; } = new UserData();
        public static VersionData Version { get; set; } = new VersionData();
        public static CodeData Code { get; set; } = new CodeData();
        public static HistoryData History { get; set; } = new HistoryData();
        public static CommentData User { get; set; } = new CommentData();
    }
}