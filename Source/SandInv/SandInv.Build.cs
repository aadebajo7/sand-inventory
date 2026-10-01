// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SandInv : ModuleRules
{
	public SandInv(ReadOnlyTargetRules Target) : base(Target)
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
			"SandInv",
			"SandInv/Variant_Platforming",
			"SandInv/Variant_Platforming/Animation",
			"SandInv/Variant_Combat",
			"SandInv/Variant_Combat/AI",
			"SandInv/Variant_Combat/Animation",
			"SandInv/Variant_Combat/Gameplay",
			"SandInv/Variant_Combat/Interfaces",
			"SandInv/Variant_Combat/UI",
			"SandInv/Variant_SideScrolling",
			"SandInv/Variant_SideScrolling/AI",
			"SandInv/Variant_SideScrolling/Gameplay",
			"SandInv/Variant_SideScrolling/Interfaces",
			"SandInv/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
