namespace Hash.Cryptography.Common;

public static class AlphabetHelper
{
    private static readonly char[] CharAlphas = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    /// <summary>
    /// متد کمکی برای گرفتن ایندکس یک کاراکتر در آرایه
    /// </summary>
    public static int GetIndex(char ch) => Array.IndexOf(CharAlphas, ch);

    /// <summary>
    /// بررسی اینکه آیا یک کاراکتر در آرایه موجود است یا خیر
    /// </summary>
    public static bool Contains(char ch) => GetIndex(ch) >= 0;

    /// <summary>
    /// متد کمکی برای گرفتن کاراکتر در آرایه براساس ایندکس
    /// </summary>
    public static char GetChar(int index)
    {
        if (index >= 0 && index < CharAlphas.Length)
            return CharAlphas[index];
        throw new ArgumentOutOfRangeException(nameof(index), "Index is out of bounds");
    }
}