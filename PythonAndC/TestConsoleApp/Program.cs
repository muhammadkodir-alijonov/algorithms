using System.Globalization;

TextInfo textInfo = new CultureInfo("en-US").TextInfo;
string title = textInfo.ToTitleCase("the quick brown fox jumps over the lazy dog"); 
Console.WriteLine(title); // The Quick Brown Fox Jumps Over The Lazy Dog