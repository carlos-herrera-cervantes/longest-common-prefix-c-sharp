namespace LongestCommonPrefixConsoleApp.Models
{
    public class SuperArray
    {
        #region  Snippet_PowerfulMethod

        /// <summary>Get the longest common prefix in a set of strings</summary>
        /// <param name="strs">Set of strings</param>
        /// <returns>Common prefix</returns>
        public static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs is null) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            }

            return prefix;
        }

        #endregion
    }
}