using Hash.Cryptography.Common;
using Hash.Cryptography.Interfaces;

namespace Hash.Cryptography.Services.Key;

public class KeyGenerationService : IKeyGenerationService
{
    public int RatioKey(string from, string to)
    {
        int countFrom = from.Length;
        int countTo = to.Length;

        foreach (var ch in from)
        {
            if (AlphabetHelper.Contains(ch))
                countFrom += AlphabetHelper.GetIndex(ch);
        }

        foreach (var ch in to)
        {
            if (AlphabetHelper.Contains(ch))
                countTo += AlphabetHelper.GetIndex(ch);
        }

        if (countFrom > 52) countFrom %= 52;
        if (countTo > 52) countTo %= 52;

        return countFrom * countTo / (countFrom + countTo);
    }

    public int SumBasedKey(string fromTo)
    {
        int key = fromTo.Length;
        foreach (char ch in fromTo)
        {
            int index = AlphabetHelper.GetIndex(ch);
            if (index >= 0)
            {
                key += index;
                if (key > 52)
                    key %= 52;
            }
        }
        return key;
    }
}