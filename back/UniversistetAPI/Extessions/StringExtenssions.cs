namespace UniversistetAPI.Extessions
{
    public static class StringExtenssions
    {
        public static string ToUpperFirstChar(this string str)
        {
            var chars = str.ToCharArray();
            var result = char.ToUpper(chars[0]) + str.Substring(1);
            return result.ToString();
        }
    }
}
