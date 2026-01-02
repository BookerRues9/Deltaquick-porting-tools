///This loads all the extensions needed for the project
/// 
/// Function list so far:
/// game_change_android(folder_name)
/// init_external_dir() --> return /data/user/0/com.bookerpuzzle.deltaquick/files/
/// game_change v2.1.1 for UndertaleModTool
/// UndertaleModTool friendly version of the toolsandroid extension, designed to be injected into games.
/// @author Mcarthur
/// @version v2.1.1


void injectExtensions()
{
	var extension = new UndertaleExtension()
	{
		ClassName = Data.Strings.MakeString("GameConfig"),
		FolderName = Data.Strings.MakeString(""),
		Name = Data.Strings.MakeString("GameChange"),
		Files = new UndertalePointerList<UndertaleExtensionFile>()
	};
	extension.Files.Add(
		new UndertaleExtensionFile()
		{
			Filename = Data.Strings.MakeString("GameChange.ext"),
			InitScript = Data.Strings.MakeString(""),
			CleanupScript = Data.Strings.MakeString(""),
			Kind = UndertaleExtensionKind.Generic,
			Functions = new UndertalePointerList<UndertaleExtensionFunction>()
			{
				new UndertaleExtensionFunction()
				{
					ID = 3,
					ExtName = Data.Strings.MakeString("game_change_android"),
					Kind = 6,
					Name = Data.Strings.MakeString("game_change_android"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
					new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
					},
					RetType = UndertaleExtensionVarType.Double
				},
				// add init_external_dir This initializes /android/data/com.bookerpuzzle.deltaquick/files/ so that Game Maker can write to and read from that directory as many times as it wants.
				new UndertaleExtensionFunction()
				{
					ID = 4,
					ExtName = Data.Strings.MakeString("init_external_dir"),
					Kind = 6,
					Name = Data.Strings.MakeString("init_external_dir"),
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
	ScriptMessage("Imported all extensions");
}
//pootis
if (!ScriptQuestion("ADD game_change_android and init_external_dir???")) return;
injectExtensions();
ScriptMessage("Done");