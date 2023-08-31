/* 
*** Source: LeetCode ***

Given an integer x, return true if x is a 
palindrome
, and false otherwise.

* Example 1:

Input: x = 121
Output: true
> Explanation: 121 reads as 121 from left to right and from right to left.

* Example 2:

Input: x = -121
Output: false

> Explanation: From left to right, it reads -121. 
> From right to left, it becomes 121-. Therefore it is not a palindrome.
> Example 3:

Input: x = 10
Output: false

> Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Author: Irfan Ghat

 */

class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new();
        solution.IsPalindrome(200);
    }
}

public class Solution
{
    public static string? reversedInput;
    public static string? parsedInput;

    public bool IsPalindrome(int x)
    {
        // Check if x is < 0
        if (x < 0)
        {
            return false;
        }
        else
        {
            // Convert input to string
            parsedInput = x.ToString();

            if (parsedInput.Length >= 0)
            {
                // Convert string to array
                char[] chars = parsedInput.ToCharArray();

                // Reverse the array
                Array.Reverse(chars);

                // Create a new string from the array
                reversedInput = new(chars);
            }
            // Check if both strings are equal
            if (parsedInput == reversedInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}