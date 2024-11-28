namespace Hash.Cryptography.Interfaces;

public interface IEncoderDecoderService
{
    string Encode(string text, string From, string To);
    string Decode(string encodedText, string From, string To);
}