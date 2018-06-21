using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace PresentationLayer
{
    public static partial class StringExtensions
    {

        #region String Methods
        #region String Basic Type Converstion
        /// <summary>
        ///  it will Convert a string into int?
        ///  if Fails then return null
        /// </summary>
        /// <param name="IntStr">Int Convertable String</param>
        /// <returns>Int ? </returns>
        /// <example > int i = "23".toInt() ?? 0 </example>
        public static int? ToInt(this string IntStr)
        {
            int i;
            return int.TryParse(IntStr, out i) ? (int?)i : null;
        }

        /// <summary>
        ///  it will Convert a string into decimal?
        ///  if Fails then return null
        /// </summary>
        /// <param name="decimalStr">decimal Convertable String</param>
        /// <returns>decimal ? </returns>
        /// <example > decimal d = "23.2".toDecimal() ?? 0 </example>
        public static decimal? ToDecimal(this string decimalStr)
        {
            decimal i;
            return decimal.TryParse(decimalStr, out i) ? (decimal?)i : null;
        }

        /// <summary>
        ///  it will Convert a string into double?
        ///  if Fails then return null
        /// </summary>
        /// <param name="dobuleStr">Double Convertable String</param>
        /// <returns>double ? </returns>
        /// <example > double d = "23.2".toDouble() ?? 0.0; </example>
        public static double? ToDouble(this string dobuleStr)
        {

            double i;
            return double.TryParse(dobuleStr, out i) ? (double?)i : null;
        }

        /// <summary>
        ///  it will Convert a string into float?
        ///  if Fails then return null
        /// </summary>
        /// <param name="floatStr">float Convertable String</param>
        /// <returns> float? </returns>
        /// <example > float f = "23.2".toFloat() ?? 0.0; </example>
        public static float? ToFloat(this string floatStr)
        {

            float i;
            return float.TryParse(floatStr, out i) ? (float?)i : null;

        }

        /// <summary>
        ///  it will Convert a string into long?
        ///  if Fails then return null
        /// </summary>
        /// <param name="longStr">toLong Convertable String</param>
        /// <returns> long? </returns>
        /// <example > long l = "23".toLong() ?? 0; </example>
        public static long? ToLong(this string longStr)
        {
            long i;
            return long.TryParse(longStr, out i) ? (long?)i : null;

        }

        /// <summary>
        ///  it will Convert a string into short?
        ///  if Fails then return null
        /// </summary>
        /// <param name="shortStr">short Convertable String</param>
        /// <returns> short? </returns>
        /// <example > short s = "23".toShort() ?? 0; </example>
        public static short? ToShort(this string shortStr)
        {
            short i;
            return short.TryParse(shortStr, out i) ? (short?)i : null;


        }

        /// <summary>
        ///  it will Convert a string into bool?
        ///  if Fails then return null
        /// </summary>
        /// <param name="BoolStr">boolStr Convertable String</param>
        /// <returns>bool ? </returns>
        /// <example > bool i = "true".toBool() ?? 0 </example>
        public static bool? ToBool(this string boolStr)
        {
            bool i;
            return bool.TryParse(boolStr, out i) ? (bool?)i : null;
        }

        #endregion
        #region DateTime
        /// <summary>
        /// It will try to Convert a given string int DateTime
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string str)
        {
            DateTime i;
            return DateTime.TryParse(str, out i) ? (DateTime?)i : null;
        }


        /// 
        /// It will Conver the String into the Given Format. Note : it will Return DateTime.MinValue Back if Unable to Convert due to Exceptions
        /// Date Pattern MM-dd-yyyy / dd-MM-yyyy
        /// It will return DateTime in a give Format
        public static string ToDateFormat(this string str, string ShortDatePattern = "MMM-dd-yyyy")
        {
            DateTime date = DateTime.MinValue;
            if (DateTime.TryParse(str, out date))
            {
                return date.ToString(ShortDatePattern);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// it will compare the given date with DateTime.Now and Return you Difference in Seconds,Minuts,Hours
        /// But Not In Days
        /// </summary>
        /// <param name="date">this will be Compare with Current DateTime.Now</param>
        /// <param name="TimesAgoSuffix">Any Suffix after Difference</param>
        /// <param name="DateFormat">Return String Format</param>
        /// <returns> 4 Seconds Ago , 5 Hours Ago</returns>
        public static string GetTimeAgo(this DateTime date, string TimesAgoSuffix = "ago", string DateFormat = "dd MMM yyyy")
        {
            TimeSpan ts = DateTime.Now - date;
            if (date.Date == DateTime.Today)
            {
                if (((int)ts.TotalDays) > 0)
                {
                    return date.ToDateFormat(DateFormat);
                }
                else if (((int)ts.TotalHours) > 0)
                {
                    int h = (int)ts.TotalHours;
                    return h + (h == 1 ? "hour" : " hours ") + TimesAgoSuffix;
                }
                else if (((int)ts.TotalMinutes) > 0)
                {
                    int m = (int)ts.TotalMinutes;
                    return m + (m == 1 ? " minute " : " minutes") + TimesAgoSuffix;
                }
                else if (((int)ts.TotalSeconds) > 0)
                {
                    int sec = (int)ts.TotalSeconds;
                    return sec + (sec == 1 ? " second " : " seconds ") + TimesAgoSuffix;
                }
            }
            return date.ToDateFormat(DateFormat);
        }

        #endregion



        #region Regex Extensions
        public static string RegexReplace(this string input, string pattern, string replacement)
        {
            return Regex.Replace(input, pattern, replacement);
        }
        public static MatchCollection RegexMatches(this string input, string pattern, RegexOptions regexOptions = RegexOptions.IgnoreCase)
        {
            return Regex.Matches(input, pattern, regexOptions);
        }
        public static Match RegexMatch(this string input, string pattern, RegexOptions regexOptions = RegexOptions.IgnoreCase)
        {
            return Regex.Match(input, pattern, regexOptions);
        }
        #endregion
        #region HTML 
        public static string HtmlDataDecode(this string data)
        {
            return System.Net.WebUtility.HtmlDecode(data);
        }
        public static string HtmlDataEncode(this string data)
        {
            return System.Net.WebUtility.HtmlEncode(data);
        }
        public static string HtmlURLEncode(this string URL)
        {
            return System.Uri.EscapeUriString(URL);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sRelUrl">it is the Relative URL</param>
        /// <param name="sAbsUrl">It must be a Absolute URL i.e http://www.goog.com</param>
        /// <exception cref="System.UriFormatException">Absolute URL must be Valid URL</exception>
        /// <returns>It will Convert a Relative URL to the Absolute URL</returns>
        public static string MakeAbsUrlFrom(this string sRelUrl, string sAbsUrl)
        {

            Uri RelUrl = new Uri(sRelUrl, UriKind.RelativeOrAbsolute);
            if (RelUrl.IsAbsoluteUri)
            {
                return RelUrl.AbsoluteUri;
            }
            if (!Regex.IsMatch(sAbsUrl, "(?<protocol>http|https)://(?<domain>[\\w\\.]+)(?<path>/.*)?"))
            {
                sAbsUrl = "http://" + sAbsUrl;
            }

            Uri AbsUrl = new Uri(sAbsUrl);
            if (AbsUrl.IsAbsoluteUri)
            {
                sRelUrl = new Uri(AbsUrl, sRelUrl).AbsoluteUri;
            }



            return sRelUrl;
        }


        #region BoolReturnd Functions
        // Function to test for Positive Integers. 
        public static bool IsNaturalNumber(this String strNumber)
        {
            Regex objNotNaturalPattern = new Regex("[^0-9]");
            Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");
            return !objNotNaturalPattern.IsMatch(strNumber) &&
            objNaturalPattern.IsMatch(strNumber);
        }
        // Function to test for Positive Integers with zero inclusive 
        public static bool IsWholeNumber(this String strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }
        // Function to Test for Integers both Positive & Negative 
        public static bool IsInteger(this String strNumber)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");
            return !objNotIntPattern.IsMatch(strNumber) && objIntPattern.IsMatch(strNumber);
        }
        // Function to Test for Positive Number both Integer & Real 
        public static bool IsPositiveNumber(this String strNumber)
        {
            Regex objNotPositivePattern = new Regex("[^0-9.]");
            Regex objPositivePattern = new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            return !objNotPositivePattern.IsMatch(strNumber) &&
            objPositivePattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber);
        }
        // Function to test whether the string is valid number or not
        public static bool IsNumber(this String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }
        // Function To test for Alphabets. 
        public static bool IsAlpha(this String strToCheck)
        {
            Regex objAlphaPattern = new Regex("[^a-zA-Z]");
            return !objAlphaPattern.IsMatch(strToCheck);
        }
        // Function to Check for AlphaNumeric.
        public static bool IsAlphaNumeric(this String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }

        public static bool IsValidEmail(this string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region String IO

        /// 
        /// Save this String As Text File

        public static bool SaveAsTextFile(this string Text, string FileName, string FilePath, bool append = false)
        {
            bool IsFileSaved = false;
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(FilePath);
                if (!Directory.Exists(FilePath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(FilePath);
                }
                string path = System.IO.Path.Combine(FilePath, FileName);
                System.IO.StreamWriter Writer =
                   new System.IO.StreamWriter(path, append);
                Writer.Write(Text);
                Writer.Close();
                IsFileSaved = true;

            }
            catch
            {
                IsFileSaved = false;
            }
            return IsFileSaved;
        }



        #endregion
        #endregion


        /// <summary>
        /// Similirty is computed using edit distance formula
        /// and if returns  1.0 then boths string are 100% similar
        /// otherwise similarity is computed between 0.0 to 1.0
        /// </summary>
        public static double ComputeSimilarity(this string thisString, string computeWith)
        {

            int n = thisString.Length;
            int m = computeWith.Length;
            double TotalLength = m > n ? m : n;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return 0.0;
            }

            if (m == 0)
            {
                return 0.0;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (computeWith[j - 1] == thisString[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            double difference = d[n, m];

            return 1.0 - (difference / TotalLength);

        }


        /// 
        /// if An Exceptions Occurs or unable to parse then Null String will be returned
        /// 
        /// 
        /// 
        /// 
        public static string ToDateFormat(this DateTime date, string ShortDatePattern = "MMM-dd-yyyy")
        {


            try
            {
                return date.ToString(ShortDatePattern);
            }
            catch (Exception ex)
            {
                return null;
            }




        }

        /// <summary>
        /// It will convert a string into T
        /// If Fails then Return Default Value given as arugment
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="Str">String which will be converted into T</param>
        /// <param name="defaultValue">if Fails then return this</param>
        /// <returns>Return T</returns>
        public static T To<T>(this string Str, T defaultValue) where T : IConvertible
        {
            try
            {
                return (T)Convert.ChangeType(Str, typeof(T));
            }
            catch (Exception exception)
            {
                return defaultValue;
            }
        }



        /// <summary>
        /// Remove the Consective muliple occurence of chars
        /// 
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="Occure">the character which consectiviely occure's and required Once</param>
        /// <example>"1    2   3  4  5" can be turn into "1 2 3 4 5"
        ///            var out = "1    2   3  4  5".RemoveMultipleOccurence(' ');
        /// </example>

        public static string RemoveMultipleOccurence(this string Str, char Occure)
        {
            Regex regex = new Regex(string.Format(@"[{0}]", Occure) + "{2,}", RegexOptions.None);
            return regex.Replace(Str, Occure.ToString());
        }
        public static string RemoveMultipleOccurence(this string Str, string Occure)
        {
            Regex regex = new Regex(string.Format(@"[{0}]", Occure) + "{2,}", RegexOptions.None);
            return regex.Replace(Str, Occure.ToString());
        }

        /// <summary>
        /// Generates tree of items from item list
        /// </summary>
        /// 
        /// <typeparam name="T">Type of item in collection</typeparam>
        /// <typeparam name="K">Type of parent_id</typeparam>
        /// 
        /// <param name="collection">Collection of items</param>
        /// <param name="id_selector">Function extracting item's id</param>
        /// <param name="parent_id_selector">Function extracting item's parent_id</param>
        /// <param name="root_id">Root element id</param>
        /// 
        /// <returns>Tree of items</returns>
        //public static IEnumerable<TreeItem<T>> GenerateTree<T, K>(
        //    this IEnumerable<T> collection,
        //    Func<T, K> id_selector,
        //    Func<T, K> parent_id_selector,
        //    K root_id = default(K))
        //{
        //    foreach (var c in collection.Where(c => parent_id_selector(c).Equals(root_id)))
        //    {
        //        yield return new TreeItem<T>
        //        {
        //            Item = c,
        //            Children = collection.GenerateTree(id_selector, parent_id_selector, id_selector(c))
        //        };
        //    }
        //}





    }

}
