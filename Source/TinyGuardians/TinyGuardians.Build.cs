// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TinyGuardians : ModuleRules
{
	public TinyGuardians(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TinyGuardians",
			"TinyGuardians/Variant_Platforming",
			"TinyGuardians/Variant_Platforming/Animation",
			"TinyGuardians/Variant_Combat",
			"TinyGuardians/Variant_Combat/AI",
			"TinyGuardians/Variant_Combat/Animation",
			"TinyGuardians/Variant_Combat/Gameplay",
			"TinyGuardians/Variant_Combat/Interfaces",
			"TinyGuardians/Variant_Combat/UI",
			"TinyGuardians/Variant_SideScrolling",
			"TinyGuardians/Variant_SideScrolling/AI",
			"TinyGuardians/Variant_SideScrolling/Gameplay",
			"TinyGuardians/Variant_SideScrolling/Interfaces",
			"TinyGuardians/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
