using System.Text;

namespace LeetCode.Problems._003;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var longest = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var local = 0;
            var hash = new HashSet<char>();
            for (int j = i; j < s.Length; j++)
            {
                if (hash.Contains(s[j]))
                {
                    break;
                }
                hash.Add(s[j]);
                local++;
            }

            longest = Math.Max(longest, local);
        }

        return longest;
    }
}

public class SolutionTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void TestCase(string input, int expected)
    {
        var sol = new Solution();
        Assert.Equal(expected, sol.LengthOfLongestSubstring(input));
    }
}