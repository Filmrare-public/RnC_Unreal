// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RPMWebHelper : ModuleRules
{
	public RPMWebHelper(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Json", "WebBrowser", "WebBrowserWidget", "UMG" });
				
		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
	}
}
