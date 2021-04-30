// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    internal static partial class MicrosoftStemmingTokenizerLanguageExtensions
    {
        public static string ToSerialString(this MicrosoftStemmingTokenizerLanguage value) => value switch
        {
            MicrosoftStemmingTokenizerLanguage.Arabic => "arabic",
            MicrosoftStemmingTokenizerLanguage.Bangla => "bangla",
            MicrosoftStemmingTokenizerLanguage.Bulgarian => "bulgarian",
            MicrosoftStemmingTokenizerLanguage.Catalan => "catalan",
            MicrosoftStemmingTokenizerLanguage.Croatian => "croatian",
            MicrosoftStemmingTokenizerLanguage.Czech => "czech",
            MicrosoftStemmingTokenizerLanguage.Danish => "danish",
            MicrosoftStemmingTokenizerLanguage.Dutch => "dutch",
            MicrosoftStemmingTokenizerLanguage.English => "english",
            MicrosoftStemmingTokenizerLanguage.Estonian => "estonian",
            MicrosoftStemmingTokenizerLanguage.Finnish => "finnish",
            MicrosoftStemmingTokenizerLanguage.French => "french",
            MicrosoftStemmingTokenizerLanguage.German => "german",
            MicrosoftStemmingTokenizerLanguage.Greek => "greek",
            MicrosoftStemmingTokenizerLanguage.Gujarati => "gujarati",
            MicrosoftStemmingTokenizerLanguage.Hebrew => "hebrew",
            MicrosoftStemmingTokenizerLanguage.Hindi => "hindi",
            MicrosoftStemmingTokenizerLanguage.Hungarian => "hungarian",
            MicrosoftStemmingTokenizerLanguage.Icelandic => "icelandic",
            MicrosoftStemmingTokenizerLanguage.Indonesian => "indonesian",
            MicrosoftStemmingTokenizerLanguage.Italian => "italian",
            MicrosoftStemmingTokenizerLanguage.Kannada => "kannada",
            MicrosoftStemmingTokenizerLanguage.Latvian => "latvian",
            MicrosoftStemmingTokenizerLanguage.Lithuanian => "lithuanian",
            MicrosoftStemmingTokenizerLanguage.Malay => "malay",
            MicrosoftStemmingTokenizerLanguage.Malayalam => "malayalam",
            MicrosoftStemmingTokenizerLanguage.Marathi => "marathi",
            MicrosoftStemmingTokenizerLanguage.NorwegianBokmaal => "norwegianBokmaal",
            MicrosoftStemmingTokenizerLanguage.Polish => "polish",
            MicrosoftStemmingTokenizerLanguage.Portuguese => "portuguese",
            MicrosoftStemmingTokenizerLanguage.PortugueseBrazilian => "portugueseBrazilian",
            MicrosoftStemmingTokenizerLanguage.Punjabi => "punjabi",
            MicrosoftStemmingTokenizerLanguage.Romanian => "romanian",
            MicrosoftStemmingTokenizerLanguage.Russian => "russian",
            MicrosoftStemmingTokenizerLanguage.SerbianCyrillic => "serbianCyrillic",
            MicrosoftStemmingTokenizerLanguage.SerbianLatin => "serbianLatin",
            MicrosoftStemmingTokenizerLanguage.Slovak => "slovak",
            MicrosoftStemmingTokenizerLanguage.Slovenian => "slovenian",
            MicrosoftStemmingTokenizerLanguage.Spanish => "spanish",
            MicrosoftStemmingTokenizerLanguage.Swedish => "swedish",
            MicrosoftStemmingTokenizerLanguage.Tamil => "tamil",
            MicrosoftStemmingTokenizerLanguage.Telugu => "telugu",
            MicrosoftStemmingTokenizerLanguage.Turkish => "turkish",
            MicrosoftStemmingTokenizerLanguage.Ukrainian => "ukrainian",
            MicrosoftStemmingTokenizerLanguage.Urdu => "urdu",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MicrosoftStemmingTokenizerLanguage value.")
        };

        public static MicrosoftStemmingTokenizerLanguage ToMicrosoftStemmingTokenizerLanguage(this string value)
        {
            if (string.Equals(value, "arabic", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Arabic;
            if (string.Equals(value, "bangla", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Bangla;
            if (string.Equals(value, "bulgarian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Bulgarian;
            if (string.Equals(value, "catalan", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Catalan;
            if (string.Equals(value, "croatian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Croatian;
            if (string.Equals(value, "czech", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Czech;
            if (string.Equals(value, "danish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Danish;
            if (string.Equals(value, "dutch", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Dutch;
            if (string.Equals(value, "english", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.English;
            if (string.Equals(value, "estonian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Estonian;
            if (string.Equals(value, "finnish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Finnish;
            if (string.Equals(value, "french", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.French;
            if (string.Equals(value, "german", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.German;
            if (string.Equals(value, "greek", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Greek;
            if (string.Equals(value, "gujarati", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Gujarati;
            if (string.Equals(value, "hebrew", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Hebrew;
            if (string.Equals(value, "hindi", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Hindi;
            if (string.Equals(value, "hungarian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Hungarian;
            if (string.Equals(value, "icelandic", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Icelandic;
            if (string.Equals(value, "indonesian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Indonesian;
            if (string.Equals(value, "italian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Italian;
            if (string.Equals(value, "kannada", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Kannada;
            if (string.Equals(value, "latvian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Latvian;
            if (string.Equals(value, "lithuanian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Lithuanian;
            if (string.Equals(value, "malay", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Malay;
            if (string.Equals(value, "malayalam", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Malayalam;
            if (string.Equals(value, "marathi", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Marathi;
            if (string.Equals(value, "norwegianBokmaal", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.NorwegianBokmaal;
            if (string.Equals(value, "polish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Polish;
            if (string.Equals(value, "portuguese", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Portuguese;
            if (string.Equals(value, "portugueseBrazilian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.PortugueseBrazilian;
            if (string.Equals(value, "punjabi", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Punjabi;
            if (string.Equals(value, "romanian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Romanian;
            if (string.Equals(value, "russian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Russian;
            if (string.Equals(value, "serbianCyrillic", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.SerbianCyrillic;
            if (string.Equals(value, "serbianLatin", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.SerbianLatin;
            if (string.Equals(value, "slovak", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Slovak;
            if (string.Equals(value, "slovenian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Slovenian;
            if (string.Equals(value, "spanish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Spanish;
            if (string.Equals(value, "swedish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Swedish;
            if (string.Equals(value, "tamil", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Tamil;
            if (string.Equals(value, "telugu", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Telugu;
            if (string.Equals(value, "turkish", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Turkish;
            if (string.Equals(value, "ukrainian", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Ukrainian;
            if (string.Equals(value, "urdu", StringComparison.InvariantCultureIgnoreCase)) return MicrosoftStemmingTokenizerLanguage.Urdu;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MicrosoftStemmingTokenizerLanguage value.");
        }
    }
}
