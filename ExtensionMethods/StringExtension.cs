namespace System    
{
    public static class StringExtension
    {
        public static bool IsPalindrome(this String str)
        {
            for (var i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}