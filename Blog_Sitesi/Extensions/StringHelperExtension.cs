namespace Blog_Sitesi.Helpers
{
    public static class StringHelperExtension
    {
        public static string NormalizeString(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input
                .Replace("İ", "I")
                .Replace("ı", "i")
                .Replace("Ş", "S")
                .Replace("ş", "s")
                .Replace("Ğ", "G")
                .Replace("ğ", "g")
                .Replace("Ü", "U")
                .Replace("ü", "u")
                .Replace("Ö", "O")
                .Replace("ö", "o")
                .Replace("Ç", "C")
                .Replace("ç", "c");
        }
    }
}
