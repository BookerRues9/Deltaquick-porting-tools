///This loads all the extensions needed for the project, just because

/// Function list so far:
/// game_change_android(folder_name)
/// init_external_dir(); -> returns internal directory: "/data/user/0/com.bookerpuzzle.deltaquick/files/"
/// init_cache_dir(); -> returns internal cache directory: "/data/user/0/com.bookerpuzzle.deltaquick/cache/"
/// init_code_cache_dir(); -> returns internal code cache directory: "/data/user/0/com.bookerpuzzle.deltaquick/code_cache/"
/// init_no_backup_dir(); -> returns internal no-backup directory: "/data/user/0/com.bookerpuzzle.deltaquick/no_backup/"
/// init_external_files_dir(); -> returns external files directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/"
/// init_external_cache_dir(); -> returns external cache directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/cache/"
/// init_external_alarms_dir(); -> returns external alarms directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Alarms/"
/// init_external_audiobooks_dir(); -> returns external audiobooks directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Audiobooks/"
/// init_external_dcim_dir(); -> returns external DCIM directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/DCIM/"
/// init_external_documents_dir(); -> returns external documents directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Documents/"
/// init_external_downloads_dir(); -> returns external downloads directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Download/"
/// init_external_movies_dir(); -> returns external movies directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Movies/"
/// init_external_music_dir(); -> returns external music directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Music/"
/// init_external_notifications_dir(); -> returns external notifications directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Notifications/"
/// init_external_pictures_dir(); -> returns external pictures directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Pictures/"
/// init_external_podcasts_dir(); -> returns external podcasts directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Podcasts/"
/// init_external_ringtones_dir(); -> returns external ringtones directory: "/storage/emulated/0/Android/data/com.bookerpuzzle.deltaquick/files/Ringtones/"

// I won't delete this ->
/// Game_change_android v3.0.0 for UndertaleModTool
/// UndertaleModTool friendly version of the game_change_android extension, designed to be injected into games.
/// @author Booker-Mcarthur
/// @version v3.0.0
void injectExtensions()
{
	var extension = new UndertaleExtension()
	{
		ClassName = Data.Strings.MakeString("GameConfig"),
		FolderName = Data.Strings.MakeString(""),
		Name = Data.Strings.MakeString("GameChange"),
		Version = Data.Strings.MakeString("3.0.0"),
		Files = new UndertalePointerList<UndertaleExtensionFile>()
	};
	extension.Files.Add(
		new UndertaleExtensionFile()
		{
			Filename = Data.Strings.MakeString("GameChange.ext"),
			InitScript = Data.Strings.MakeString("init_files_dir"),
			CleanupScript = Data.Strings.MakeString(""),
			Kind = UndertaleExtensionKind.Generic,
			Functions = new UndertalePointerList<UndertaleExtensionFunction>()
			{
				new UndertaleExtensionFunction()
				{
					ID = 80,
					ExtName = Data.Strings.MakeString("game_change_android"),
					Kind = 80,
					Name = Data.Strings.MakeString("game_change_android"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
					new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
					},
					RetType = UndertaleExtensionVarType.Double
				},
				new UndertaleExtensionFunction()
				{
					ID = 81,
					ExtName = Data.Strings.MakeString("init_external_dir"),
					Kind = 81,
					Name = Data.Strings.MakeString("init_external_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 82,
					ExtName = Data.Strings.MakeString("init_cache_dir"),
					Kind = 82,
					Name = Data.Strings.MakeString("init_cache_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 83,
					ExtName = Data.Strings.MakeString("init_code_cache_dir"),
					Kind = 83,
					Name = Data.Strings.MakeString("init_code_cache_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 84,
					ExtName = Data.Strings.MakeString("init_no_backup_dir"),
					Kind = 84,
					Name = Data.Strings.MakeString("init_no_backup_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 85,
					ExtName = Data.Strings.MakeString("init_external_files_dir"),
					Kind = 85,
					Name = Data.Strings.MakeString("init_external_files_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 86,
					ExtName = Data.Strings.MakeString("init_external_cache_dir"),
					Kind = 86,
					Name = Data.Strings.MakeString("init_external_cache_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 87,
					ExtName = Data.Strings.MakeString("init_external_alarms_dir"),
					Kind = 87,
					Name = Data.Strings.MakeString("init_external_alarms_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 88,
					ExtName = Data.Strings.MakeString("init_external_audiobooks_dir"),
					Kind = 88,
					Name = Data.Strings.MakeString("init_external_audiobooks_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 89,
					ExtName = Data.Strings.MakeString("init_external_dcim_dir"),
					Kind = 89,
					Name = Data.Strings.MakeString("init_external_dcim_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 90,
					ExtName = Data.Strings.MakeString("init_external_documents_dir"),
					Kind = 90,
					Name = Data.Strings.MakeString("init_external_documents_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 91,
					ExtName = Data.Strings.MakeString("init_external_downloads_dir"),
					Kind = 91,
					Name = Data.Strings.MakeString("init_external_downloads_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 92,
					ExtName = Data.Strings.MakeString("init_external_movies_dir"),
					Kind = 92,
					Name = Data.Strings.MakeString("init_external_movies_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 93,
					ExtName = Data.Strings.MakeString("init_external_music_dir"),
					Kind = 93,
					Name = Data.Strings.MakeString("init_external_music_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 94,
					ExtName = Data.Strings.MakeString("init_external_notifications_dir"),
					Kind = 94,
					Name = Data.Strings.MakeString("init_external_notifications_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
				new UndertaleExtensionFunction()
				{
					ID = 95,
					ExtName = Data.Strings.MakeString("init_external_pictures_dir"),
					Kind = 95,
					Name = Data.Strings.MakeString("init_external_pictures_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
					new UndertaleExtensionFunction()
				{
					ID = 96,
					ExtName = Data.Strings.MakeString("init_external_podcasts_dir"),
					Kind = 96,
					Name = Data.Strings.MakeString("init_external_podcasts_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
					new UndertaleExtensionFunction()
				{
					ID = 97,
					ExtName = Data.Strings.MakeString("init_external_ringtones_dir"),
					Kind = 97,
					Name = Data.Strings.MakeString("init_external_ringtones_dir"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
			}
		});
	Data.Extensions.Add(extension);
	foreach (var function in extension.Files[0].Functions)
	{
		if (function.Name.Content == "" || function.Name.Content == "") continue;
		Data.Functions.Add(new UndertaleFunction()
		{
			Name = function.Name
		});
	}
	if (Data.IsGameMaker2() || Data.GeneralInfo.Build == 9999)
	{
		byte[] throwawayData = System.Text.Encoding.ASCII.GetBytes("CXTDFBOOKERWUTBO");
		Data.FORM.EXTN.productIdData.Add(throwawayData);
	}
	ScriptMessage("game_change_android successfully added!!");
}
// We start here.
if (!ScriptQuestion("Add Deltaquick Utils??")) return;
injectExtensions();
