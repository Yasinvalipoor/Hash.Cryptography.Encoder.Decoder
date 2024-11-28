using Hash.Cryptography.Common;
using Hash.Cryptography.Interfaces;

namespace Hash.Cryptography.Services.EncoderDecoder;

public class RatioKeyEncodeDecodeService : IEncoderDecoderService
{
    private readonly IKeyGenerationService _keyGenerationService;

    public RatioKeyEncodeDecodeService(IKeyGenerationService keyGenerationService)
    {
        _keyGenerationService = keyGenerationService;
    }

    public string Decode(string encodedText, string From, string To)
    {
        int key = _keyGenerationService.RatioKey(From, To); // Initial key based on From and To
        string result = "";

        foreach (char ch in encodedText)
        {
            int index = AlphabetHelper.GetIndex(ch);
            if (index >= 0)
            {
                int originalIndex = index - key - 1;

                while (originalIndex < 0)
                    originalIndex += 52;

                result += AlphabetHelper.GetChar(originalIndex);

                key += originalIndex + 1;
            }
        }
        return result;
    }

    public string Encode(string text, string From, string To)
    {
        int key = _keyGenerationService.RatioKey(From, To); // Initial key based on From and To
        string result = "";

        foreach (char ch in text)
        {
            int index = AlphabetHelper.GetIndex(ch);
            if (index >= 0)
            {
                key += index + 1;
                key %= 52; // Ensure key wraps correctly within 0-51

                result += AlphabetHelper.GetChar(key);
            }
        }
        return result;
    }
}