namespace WebAdvanced.MailChimp {
    public static class MailChimpConfiguration {

        static MailChimpConfiguration() {
            Lists = new MailChimpListCollection();
        }

        public static string ApiKey { get; private set; }
        public static MailChimpListCollection Lists { get; private set; }
        public static void SetApiKey(string apiKey) {
            Check.Argument.IsNotNullOrEmpty(apiKey, "apiKey");
            ApiKey = apiKey;
        }

    }
}