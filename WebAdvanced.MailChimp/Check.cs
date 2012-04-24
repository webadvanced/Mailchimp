using System;
using System.Diagnostics;

namespace WebAdvanced.MailChimp {
    public static class Check {
        public static class Argument {
            [DebuggerStepThrough]
            public static void IsNotNull(object parameter, string parameterName) {
                if (parameter == null) {
                    throw new ArgumentNullException(parameterName, TextMessages.ArgumentCannotBeNull.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotNullOrEmpty(string parameter, string parameterName) {
                if (string.IsNullOrWhiteSpace(parameter)) {
                    throw new ArgumentException(TextMessages.ArgumentCannotBeNullOrEmpty.FormatWith(parameterName), parameterName);
                }
            }

            [DebuggerStepThrough]
            public static void IsNotZeroOrNegative(int parameter, string parameterName) {
                if (parameter <= 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegativeOrZero.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotNegative(int parameter, string parameterName) {
                if (parameter < 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegative.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotZeroOrNegative(long parameter, string parameterName) {
                if (parameter <= 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegativeOrZero.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotNegative(long parameter, string parameterName) {
                if (parameter < 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegative.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotZeroOrNegative(float parameter, string parameterName) {
                if (parameter <= 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegativeOrZero.FormatWith(parameterName));
                }
            }

            [DebuggerStepThrough]
            public static void IsNotNegative(float parameter, string parameterName) {
                if (parameter < 0) {
                    throw new ArgumentOutOfRangeException(parameterName, TextMessages.ArgumentCannotBeNegative.FormatWith(parameterName));
                }
            }
        }
    }
}