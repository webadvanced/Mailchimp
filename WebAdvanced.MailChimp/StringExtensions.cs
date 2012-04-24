using System.Globalization;

namespace WebAdvanced.MailChimp {
    public static class StringExtenstions {
        public static string FormatWith(this string instance, params object[] args) {
            Check.Argument.IsNotNullOrEmpty(instance, "instance");

            return string.Format(CultureInfo.CurrentUICulture, instance, args);
        }
    }
}