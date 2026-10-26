// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PortFolioProject : ModuleRules
{
	public PortFolioProject(ReadOnlyTargetRules Target) : base(Target)
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
			"PortFolioProject",
			"PortFolioProject/Variant_Horror",
			"PortFolioProject/Variant_Horror/UI",
			"PortFolioProject/Variant_Shooter",
			"PortFolioProject/Variant_Shooter/AI",
			"PortFolioProject/Variant_Shooter/UI",
			"PortFolioProject/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
