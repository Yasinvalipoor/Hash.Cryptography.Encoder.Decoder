namespace Hash.Cryptography.Interfaces;

public interface IKeyGenerationService
{
    int SumBasedKey(string fromTo);
    int RatioKey(string from, string to);
}