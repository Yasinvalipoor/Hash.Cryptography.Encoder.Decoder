using Hash.Cryptography.Interfaces;
using Hash.Cryptography.Services.EncoderDecoder;
using Hash.Cryptography.Services.Key;


string From = "John";
string To = "Mike";
string text = "HelloWorld";

// Print The Initial Information
Console.WriteLine($"Sender = {From} | Receiver = {To} --> {From + To}");
Console.WriteLine($"Message Text = {text}\n");



IKeyGenerationService keyService = new KeyGenerationService();



Console.WriteLine("\n--------------------- SumBase Key -------------------\n");


IEncoderDecoderService sumBaseEncodeDecode = new SumBaseKeyEncodeDecodeService(keyService);

string encodeMessage_1 = sumBaseEncodeDecode.Encode(text, From, To);
string decodeMessage_1 = sumBaseEncodeDecode.Decode(encodeMessage_1, From, To);

Console.WriteLine($"Encode Text : {encodeMessage_1}");
Console.WriteLine($"Decode Text : {decodeMessage_1}");


Console.WriteLine("\n--------------------- Ratio Key ---------------------\n");


IEncoderDecoderService ratioKeyEncodeDecode = new RatioKeyEncodeDecodeService(keyService);

string encodeMessage_2 = ratioKeyEncodeDecode.Encode(text, From, To);
string decodeMessage_2 = ratioKeyEncodeDecode.Decode(encodeMessage_2, From, To);

Console.WriteLine($"Encode Text : {encodeMessage_2}");
Console.WriteLine($"Decode Text : {decodeMessage_2}");



Console.ReadLine();








// String text



// text Into Encoder


// Saving To =  
// txt
// csv
// ini


// Read files by Decoder 







// --------------------------------------



//static int CalculateKey_1(string input, char[] charAlphas)
//{
//    int key = 0;
//    foreach (char ch in input)
//    {
//        int index = Array.IndexOf(charAlphas, ch);
//        if (index >= 0)
//        {
//            key += (index + 1);
//            if (key > 52)
//                key %= 52;
//        }
//    }
//    return key;
//}

//static int CalculateKey_2(int count_From, int count_To)
//{
//    if (count_From > 52)
//        count_From %= 52;
//    if (count_To > 52)
//        count_To %= 52;

//    return (count_From * count_To) / (count_From + count_To);
//}
//static int CalculateCount(string input, char[] charAlphas)
//{
//    int count = 0;
//    foreach (var ch in input)
//    {
//        int index = Array.IndexOf(charAlphas, ch);
//        if (index >= 0)
//        {
//            count += (index + 1);
//        }
//    }
//    return count;
//}