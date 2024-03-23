using UnrealBuildTool;

public class FlappyBirdServerTarget : TargetRules
{
	public FlappyBirdServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FlappyBird");
	}
}
