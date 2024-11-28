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

//    }
//    return count;
//}
