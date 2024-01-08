/* Task:
 * For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).
 * Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
 */

/* Solution:
 * Find first repeated substring, then check remaining part of short string, then check long string, find GDC of short and long strings
 */

namespace Greatest_Common_Divisor_of_Strings___1071 {
	public static class MainClass {
		public static void Main(string[] args)
		{
			var gcdOfStrings = new Solution();
			Console.WriteLine(gcdOfStrings.GcdOfStrings("AAAAAAAAA", "AAACCC"));
		}
	}

	public class Solution {
		private string GetShortDivider(string shortString)
		{
			string shortStringDivider = "";
			switch (shortString.Length)
			{
				case 0:
				case 1:
					return shortString;
				default:
					for (int i = 0; i < shortString.Length / 2; i++)
					{
						if (shortString.Substring(0, i + 1).Equals(shortString.Substring(i + 1, i + 1)))
						{
							shortStringDivider = shortString.Substring(0, i + 1);
							if (shortString.Length % (i + 1) == 0)
							{
								var leftOver = shortString.Substring((i + 1) * 2);
								while (leftOver.StartsWith(shortStringDivider))
								{
									leftOver = leftOver.Remove(0, shortStringDivider.Length);
								}

								if (leftOver.Length == 0) return shortStringDivider;
								shortStringDivider = "";
							}
						}
					}

					break;
			}

			return (shortStringDivider == "") ? shortString : shortStringDivider;
		}

		public string GcdOfStrings(string str1, string str2)
		{
			var (longString, shortString) = str1.Length > str2.Length ? (str1, str2) : (str2, str1);
			// TODO Сделать результатом switch

			var shortStringDivider = GetShortDivider(shortString);
			int m = longString.Length / shortStringDivider.Length, n = shortString.Length / shortStringDivider.Length;
			if (longString.Length % shortStringDivider.Length == 0)
			{
				while (longString.StartsWith(shortStringDivider))
				{
					longString = longString.Remove(0, shortStringDivider.Length);
				}

				if (longString.Length == 0)
				{
					Console.WriteLine("length " + n + " " + m);
					while(m != n)
					{
						if(m > n)
						{
							m = m - n;
						}
						else
						{
							n = n - m;
						}
					}
					
					return string.Concat(Enumerable.Repeat(shortStringDivider, n));
				}
			}
			
			return "";
		}

	}
}
