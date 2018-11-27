using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SeURL.Helper
{

    public class SeoHelper
    {

        public static string ToSeoUrl(string IncomingText)
        {
            IncomingText = IncomingText.Replace("ş", "s");
            IncomingText = IncomingText.Replace("Ş", "s");
            IncomingText = IncomingText.Replace("İ", "i");
            IncomingText = IncomingText.Replace("I", "i");
            IncomingText = IncomingText.Replace("ı", "i");
            IncomingText = IncomingText.Replace("ö", "o");
            IncomingText = IncomingText.Replace("Ö", "o");
            IncomingText = IncomingText.Replace("ü", "u");
            IncomingText = IncomingText.Replace("Ü", "u");
            IncomingText = IncomingText.Replace("Ç", "c");
            IncomingText = IncomingText.Replace("ç", "c");
            IncomingText = IncomingText.Replace("ğ", "g");
            IncomingText = IncomingText.Replace("Ğ", "g");
            IncomingText = IncomingText.Replace(" ", "-");
            IncomingText = IncomingText.Replace("---", "-");
            IncomingText = IncomingText.Replace("?", "");
            IncomingText = IncomingText.Replace("/", "");
            IncomingText = IncomingText.Replace(".", "");
            IncomingText = IncomingText.Replace("'", "");
            IncomingText = IncomingText.Replace("#", "");
            IncomingText = IncomingText.Replace("%", "");
            IncomingText = IncomingText.Replace("&", "");
            IncomingText = IncomingText.Replace("*", "");
            IncomingText = IncomingText.Replace("!", "");
            IncomingText = IncomingText.Replace("@", "");
            IncomingText = IncomingText.Replace("+", "");

            IncomingText = IncomingText.ToLower();
            IncomingText = IncomingText.Trim();

            // tüm harfleri küçült
            string encodedUrl = (IncomingText ?? "").ToLower();

            // & ile " " yer değiştirme
            encodedUrl = Regex.Replace(encodedUrl, @"&+", "and");

            // " " karakterlerini silme
            encodedUrl = encodedUrl.Replace("'", "");

            // geçersiz karakterleri sil
            encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9]", "-");

            // tekrar edenleri sil
            encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");

            // karakterlerin arasına tire koy
            encodedUrl = encodedUrl.Trim('-');

            return encodedUrl;
        }


        //public static string UrlCevir(string kelime)
        //{
        //    if (kelime == "" || kelime == null) { return string.Empty; }

        //    kelime = kelime.Replace(".", "");
        //    kelime = kelime.Replace(":", "");
        //    kelime = kelime.Replace(";", "");
        //    kelime = kelime.Replace(",", "");
        //    kelime = kelime.Replace(" ", "-");
        //    kelime = kelime.Replace("!", "");
        //    kelime = kelime.Replace("(", "");
        //    kelime = kelime.Replace(")", "");
        //    kelime = kelime.Replace("'", "'");
        //    kelime = kelime.Replace("ğ", "g");
        //    kelime = kelime.Replace("Ğ", "G");
        //    kelime = kelime.Replace("ı", "i");
        //    kelime = kelime.Replace("I", "i");
        //    kelime = kelime.Replace("ç", "c");
        //    kelime = kelime.Replace("Ç", "C");
        //    kelime = kelime.Replace("ö", "o");
        //    kelime = kelime.Replace("Ö", "O");
        //    kelime = kelime.Replace("ü", "u");
        //    kelime = kelime.Replace("Ü", "U");
        //    kelime = kelime.Replace("ş", "s");
        //    kelime = kelime.Replace("Ş", "S");
        //    kelime = kelime.Replace("`", "");
        //    kelime = kelime.Replace("=", "");
        //    kelime = kelime.Replace("&", "");
        //    kelime = kelime.Replace("%", "");
        //    kelime = kelime.Replace("#", "");
        //    kelime = kelime.Replace("<", "");
        //    kelime = kelime.Replace(">", "");
        //    kelime = kelime.Replace("*", "");
        //    kelime = kelime.Replace("?", "");
        //    kelime = kelime.Replace("+", "-");
        //    kelime = kelime.Replace("\"", "-");
        //    kelime = kelime.Replace("»", "-");
        //    kelime = kelime.Replace("|", "-");
        //    kelime = kelime.Replace("^", "");
        //    return kelime;
        //}

    }
}
