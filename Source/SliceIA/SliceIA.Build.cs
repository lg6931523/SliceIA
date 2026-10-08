// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SliceIA : ModuleRules
{
	public SliceIA(ReadOnlyTargetRules Target) : base(Target)
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
			"SliceIA",
			"SliceIA/Variant_Platforming",
			"SliceIA/Variant_Platforming/Animation",
			"SliceIA/Variant_Combat",
			"SliceIA/Variant_Combat/AI",
			"SliceIA/Variant_Combat/Animation",
			"SliceIA/Variant_Combat/Gameplay",
			"SliceIA/Variant_Combat/Interfaces",
			"SliceIA/Variant_Combat/UI",
			"SliceIA/Variant_SideScrolling",
			"SliceIA/Variant_SideScrolling/AI",
			"SliceIA/Variant_SideScrolling/Gameplay",
			"SliceIA/Variant_SideScrolling/Interfaces",
			"SliceIA/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
