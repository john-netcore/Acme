using System.Text;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts space before each capital letter in a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return source;
            }
            var result = new StringBuilder(string.Empty);

            foreach (var letter in source)
            {
                if (char.IsUpper(letter) && result.ToString() != string.Empty && !result.ToString().EndsWith(" "))
                {
                    result.Append(" ");
                }
                result.Append(letter);
            }

            return result.ToString();
        }
    }
}
