/// playgames v13.2.3 Para UndertaleModTool
/// @author Booker-Mcarthur
/// @version v1.0

void Thecakeisalie()
{
	var extension = new UndertaleExtension()
	{
		ClassName = Data.Strings.MakeString("YYGooglePlayServices"),
		FolderName = Data.Strings.MakeString(""),
		Name = Data.Strings.MakeString("GooglePlayServices"),
		Version = Data.Strings.MakeString("1.3.0"),
		Files = new UndertalePointerList<UndertaleExtensionFile>()
	};
	
	extension.Files.Add(
		new UndertaleExtensionFile()
		{
			Filename = Data.Strings.MakeString("GooglePlayServices.ext"),
			InitScript = Data.Strings.MakeString(""),
			CleanupScript = Data.Strings.MakeString(""),
			Kind = UndertaleExtensionKind.Generic,
			Functions = new UndertalePointerList<UndertaleExtensionFunction>()
			{
				new UndertaleExtensionFunction()
				{
					ID = 5,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_Show"),
					Kind = 1,
					Name = Data.Strings.MakeString("googleplayservices_achievements_Show"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
			    new UndertaleExtensionFunction()
				{
					ID = 6,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_Increment"),
					Kind = 2,
					Name = Data.Strings.MakeString("googleplayservices_achievements_Increment"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
					},
					RetType = UndertaleExtensionVarType.Double
				},
			    new UndertaleExtensionFunction()
				{
					ID = 7,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_Reveal"),
					Kind = 3,
					Name = Data.Strings.MakeString("googleplayservices_achievements_Reveal"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
					},
					RetType = UndertaleExtensionVarType.Double
				},
			    new UndertaleExtensionFunction()
				{
					ID = 8,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_SetSteps"),
					Kind = 4,
					Name = Data.Strings.MakeString("googleplayservices_achievements_SetSteps"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                        new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
					},
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 9,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_Unlock"),
					Kind = 5,
					Name = Data.Strings.MakeString("googleplayservices_achievements_Unlock"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
    
					},
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 10,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Achievements_GetStatus"),
					Kind = 6,
					Name = Data.Strings.MakeString("googleplayservices_achievements_GetStatus"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
					{
						new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
    
					},
					RetType = UndertaleExtensionVarType.String
				},
                  new UndertaleExtensionFunction()
				{
					ID = 11,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_ShowAll"),
					Kind = 7,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_ShowAll"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 12,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_Show"),
					Kind = 8,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_Show"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 13,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_SubmitScore"),
					Kind = 9,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_SubmitScore"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                 new UndertaleExtensionFunction()
				{
					ID = 14,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_LoadPlayerCenteredScores"),
					Kind = 10,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_LoadPlayerCenteredScores"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 15,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_LoadTopScores"),
					Kind = 11,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_LoadTopScores"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                    },
					RetType = UndertaleExtensionVarType.String
				},
                new UndertaleExtensionFunction()
				{
					ID = 16,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_ShowSavedGamesUI"),
					Kind = 12,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_ShowSavedGamesUI"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 17,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_CommitAndClose"),
					Kind = 13,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_CommitAndClose"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 18,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_Load"),
					Kind = 14,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_Load"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 19,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_Delete"),
					Kind = 15,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_Delete"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                new UndertaleExtensionFunction()
				{
					ID = 20,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_DiscardAndClose"),
					Kind = 16,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_DiscardAndClose"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 21,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_Open"),
					Kind = 17,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_Open"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                   new UndertaleExtensionFunction()
				{
					ID = 22,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_ResolveConflict"),
					Kind = 18,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_ResolveConflict"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 23,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SavedGames_CommitNew"),
					Kind = 19,
					Name = Data.Strings.MakeString("googleplayservices_savedGames_CommitNew"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 24,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Player_Current"),
					Kind = 20,
					Name = Data.Strings.MakeString("googleplayServices_player_Current"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
                  new UndertaleExtensionFunction()
				{
					ID = 24,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Player_CurrentID"),
					Kind = 21,
					Name = Data.Strings.MakeString("googleplayServices_player_CurrentID"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.String
				},
                 new UndertaleExtensionFunction()
				{
					ID = 25,
					ExtName = Data.Strings.MakeString("GooglePlayServices_UriToPath"),
					Kind = 22,
					Name = Data.Strings.MakeString("googlePlayServices_UriToPath"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 26,
					ExtName = Data.Strings.MakeString("GooglePlayServices_IsAvailable"),
					Kind = 23,
					Name = Data.Strings.MakeString("googlePlayServices_IsAvailable"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                  new UndertaleExtensionFunction()
				{
					ID = 27,
					ExtName = Data.Strings.MakeString("GooglePlayServices_SignIn"),
					Kind = 24,
					Name = Data.Strings.MakeString("googlePlayServices_SignIn"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                 new UndertaleExtensionFunction()
				{
					ID = 28,
					ExtName = Data.Strings.MakeString("GooglePlayServices_IsAuthenticated"),
					Kind = 25,
					Name = Data.Strings.MakeString("googlePlayServices_IsAuthenticated"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>(),
					RetType = UndertaleExtensionVarType.Double
				},
                 new UndertaleExtensionFunction()
				{
					ID = 30,
					ExtName = Data.Strings.MakeString("GooglePlayServices_RequestServerSideAccess"),
					Kind = 26,
					Name = Data.Strings.MakeString("googlePlayServices_RequestServerSideAccess"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },   
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                 new UndertaleExtensionFunction()
				{
					ID = 31,
					ExtName = Data.Strings.MakeString("GooglePlayServices_PlayerStats_LoadPlayerStats"),
					Kind = 27,
					Name = Data.Strings.MakeString("googleplayServices_playerStats_LoadPlayerStats"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },   
                    },
					RetType = UndertaleExtensionVarType.Double
				},
                 new UndertaleExtensionFunction()
				{
					ID = 32,
					ExtName = Data.Strings.MakeString("GooglePlayServices_Leaderboard_LoadTopScores"),
					Kind = 28,
					Name = Data.Strings.MakeString("googleplayservices_leaderboard_LoadTopScores"),
					Arguments = new UndertaleSimpleList<UndertaleExtensionFunctionArg>()
                    {
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.String },
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },   
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },   
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },   
                     new UndertaleExtensionFunctionArg() { Type = UndertaleExtensionVarType.Double },      
                    },
					RetType = UndertaleExtensionVarType.Double
				},
            }
		});		
		
	Data.Extensions.Add(extension);
	// generate "function" entries for every extension function EXCEPT THE HIDDEN ONES!
	foreach (var function in extension.Files[0].Functions)
	{
		if (function.Name.Content == "GooglePlayServices_Achievements_Show" || function.Name.Content == "GooglePlayServices_Achievements_Show") continue;
		Data.Functions.Add(new UndertaleFunction()
		{
			Name = function.Name
		});
	}
	// add productId
	if (Data.IsGameMaker2() || Data.GeneralInfo.Build == 9999)
	{
		byte[] throwawayData = System.Text.Encoding.ASCII.GetBytes("BOOKPRLIBSASDEFL");
		Data.FORM.EXTN.productIdData.Add(throwawayData);
	}
}
if (!ScriptQuestion("Google Play Juegos Android")) return;
Thecakeisalie();
ScriptMessage("Hecho");