namespace System
{
    static class StringExtensions
    {
        public static string Cut(this String str, int count)
        {
            if(str.Length <= count) return str;
            return str.Substring(0, count)+"...";
        }

    }
}
