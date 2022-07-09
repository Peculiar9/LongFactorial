public class LongestCommonPrefixClass
{
     public static string LongestCommonPrefix(string[] strs) {
      string prefixString = strs[0];
      for (int i = 1; i < strs.Length; i++)
      {
          while (strs[i].IndexOf(prefixString) != 0)
          {
              prefixString = prefixString.Substring(0, prefixString.Length - 1);
          }
      }  
      return prefixString;
    }
}
          