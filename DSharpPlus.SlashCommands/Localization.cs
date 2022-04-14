namespace DSharpPlus.SlashCommands
{
	// hey d#+ devs please make DiscordLanguage enum a thing ty <3
	public enum Localization
	{
		Danish,
		German,
		BritishEnglish,
		AmericanEnglish,
		Spanish,
		French,
		Croatian,
		Italian,
		Lithuanian,
		Hungarian,
		Dutch,
		Norwegian,
		Polish,
		Portuguese,
		Romanian,
		Finnish,
		Swedish,
		Vietnamese,
		Turkish,
		Czech,
		Greek,
		Bulgarian,
		Russian,
		Ukrainian,
		Hindi,
		Thai,
		Chinese,
		Japanese,
		TaiwanChinese,
		Korean
	}

	public enum LocalizationContext
	{
		SlashCommandName,
		SlashCommandDescription,
		SlashCommandOptionName,
		SlashCommandOptionDescription,
		ContextMenuName
	}

	public static class LocalizationExtensions
	{
		public static string GetNativeName(this Localization l) => l switch
		{
			Localization.Danish => "Dansk",
			Localization.German => "Deutsch",
			Localization.BritishEnglish => "English, UK",
			Localization.AmericanEnglish => "English, US",
			Localization.Spanish => "Español",
			Localization.French => "Français",
			Localization.Croatian => "Hrvatski",
			Localization.Italian => "Italiano",
			Localization.Lithuanian => "Lietuviškai",
			Localization.Hungarian => "Magyar",
			Localization.Dutch => "Nederlands",
			Localization.Norwegian => "Norsk",
			Localization.Polish => "Polski",
			Localization.Portuguese => "Português do Brasil",
			Localization.Romanian => "Română",
			Localization.Finnish => "Suomi",
			Localization.Swedish => "Svenska",
			Localization.Vietnamese => "Tiếng Việt",
			Localization.Turkish => "Türkçe",
			Localization.Czech => "Čeština",
			Localization.Greek => "Ελληνικά",
			Localization.Bulgarian => "български",
			Localization.Russian => "Pусский",
			Localization.Ukrainian => "Українська",
			Localization.Hindi => "हिन्दी",
			Localization.Thai => "ไทย",
			Localization.Chinese => "中文",
			Localization.Japanese => "日本語",
			Localization.TaiwanChinese => "繁體中文",
			Localization.Korean => "한국어",
			_ => ""
		};

		public static string GetLanguageCode(this Localization l) => l switch
		{
			Localization.Danish => "da",
			Localization.German => "de",
			Localization.BritishEnglish => "en-GB",
			Localization.AmericanEnglish => "en-US",
			Localization.Spanish => "es-ES",
			Localization.French => "fr",
			Localization.Croatian => "hr",
			Localization.Italian => "it",
			Localization.Lithuanian => "lt",
			Localization.Hungarian => "hu",
			Localization.Dutch => "nl",
			Localization.Norwegian => "no",
			Localization.Polish => "pl",
			Localization.Portuguese => "pt-BR",
			Localization.Romanian => "ro",
			Localization.Finnish => "fi",
			Localization.Swedish => "sv-SE",
			Localization.Vietnamese => "vi",
			Localization.Turkish => "tr",
			Localization.Czech => "cs",
			Localization.Greek => "el",
			Localization.Bulgarian => "bg",
			Localization.Russian => "ru",
			Localization.Ukrainian => "uk",
			Localization.Hindi => "hi",
			Localization.Thai => "th",
			Localization.Chinese => "zh-CN",
			Localization.Japanese => "ja",
			Localization.TaiwanChinese => "zh-TW",
			Localization.Korean => "ko",
			_ => ""
		};

		public static Localization GetLanguageFromCode(string code) => code switch
		{
			"da" => Localization.Danish,
			"de" => Localization.German,
			"en-GB" => Localization.BritishEnglish,
			"en-US" => Localization.AmericanEnglish,
			"es-ES" => Localization.Spanish,
			"fr" => Localization.French,
			"hr" => Localization.Croatian,
			"it" => Localization.Italian,
			"lt" => Localization.Lithuanian,
			"hu" => Localization.Hungarian,
			"nl" => Localization.Dutch,
			"no" => Localization.Norwegian,
			"pl" => Localization.Polish,
			"pt-BR" => Localization.Portuguese,
			"ro" => Localization.Romanian,
			"fi" => Localization.Finnish,
			"sv-SE" => Localization.Swedish,
			"vi" => Localization.Vietnamese,
			"tr" => Localization.Turkish,
			"cs" => Localization.Czech,
			"el" => Localization.Greek,
			"bg" => Localization.Bulgarian,
			"ru" => Localization.Russian,
			"uk" => Localization.Ukrainian,
			"hi" => Localization.Hindi,
			"th" => Localization.Thai,
			"zh-CN" => Localization.Chinese,
			"ja" => Localization.Japanese,
			"zh-TW" => Localization.TaiwanChinese,
			"ko" => Localization.Korean,
			_ => Localization.AmericanEnglish // america, fuck yeah!
		};
	}
}