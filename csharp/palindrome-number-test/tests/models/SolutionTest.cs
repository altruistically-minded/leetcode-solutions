using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace palindrome_number_test
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SingleDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(1);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void DoubleDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(12);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void NegativeNumber()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(-12);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void TripleDigitPalindrome()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(121);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void TripleDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(122);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void FourDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(1212);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void Palindrome_FourDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(1221);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void FiveDigitPalindrome()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(14241);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void FiveDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(14221);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void Palindrome_SixDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(123321);

            Assert.IsTrue(isPalindrome);
        }


        [TestMethod]
        public void SevenDigitPalindrome()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(5142415);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void SevenDigit()
        {
            var solution = new Solution();
            
            var isPalindrome = solution.IsPalindrome(5142115);

            Assert.IsFalse(isPalindrome);
        }


    }
}