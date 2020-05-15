
namespace palindrome_number_test
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            // Shortcut for Negative use case
            if (x < 0)
            {
                return false;
            }

            // Shortcut for single digit
            if (x < 10)
            {
                return true;
            }

            // For the rest of the numbers
            // ===========================

            // Convert to string
            var palindrome = x.ToString();

            // Find the ends of string
            var left = 0;
            var right = palindrome.Length;

            var isEven = palindrome.Length % 2 == 0;

            // Compare with beginning until they're both the same character
            var isPalindrome = true;
            do
            {
                if (palindrome[left++] != palindrome[(right--) - 1])
                {
                    isPalindrome = false;
                    break;
                }
            } while (isEven ? left != right: left != ((int)palindrome.Length / 2));

            // Return if it's a palindrome
            return isPalindrome;
        }
    }
}