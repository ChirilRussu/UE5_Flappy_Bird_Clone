using UnrealBuildTool;

public class FlappyBirdClientTarget : TargetRules
{
	public FlappyBirdClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FlappyBird");
	}
}
