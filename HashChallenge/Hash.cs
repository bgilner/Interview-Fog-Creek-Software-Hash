using System;
using System.Linq;

namespace HashChallenge
{
    public static class Hash
    {
        private const string LETTERS = "acdegilmnoprstuw";
        public static readonly Func<string, long> ToHash = x => x.Aggregate(7L, (hash, current) => (hash * 37 + LETTERS.IndexOf(current)));

        public static string ToSource(long hash, int length)
        {
            var source = new string(LETTERS[0], length);
            for (int index = 0; index < source.Length; index++)
            {
                foreach (var letter in LETTERS.Skip(1))
                {
                    var nextSource = source.Substring(0, index) + letter + source.Substring(index + 1);
                    if (ToHash(nextSource) <= hash)
                        source = nextSource;
                }
            }

            return source;
        }
    }
}
