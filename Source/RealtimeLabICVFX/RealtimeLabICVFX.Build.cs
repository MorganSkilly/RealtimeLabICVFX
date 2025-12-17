// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RealtimeLabICVFX : ModuleRules
{
	public RealtimeLabICVFX(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
            {
                "Core",
                "MoSysAPI",
                "MoSysTracking",
                "MoSysTrackingEditor",
                "MoSysLensDistortion",
                "CanonLiveLinkPlugin",
			}
		);
	}
}
