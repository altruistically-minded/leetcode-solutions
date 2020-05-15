
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

            // reverse number and compare
            var original = x;
            var reverse = 0;

            while(x != 0){
                var digit = x % 10 ;
                reverse = reverse * 10 + digit;

                x = x / 10;
            }

            // Return if it's a palindrome
            return (original == reverse);
        }
    }
}