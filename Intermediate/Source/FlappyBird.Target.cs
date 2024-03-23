using UnrealBuildTool;

public class FlappyBirdTarget : TargetRules
{
	public FlappyBirdTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FlappyBird");
	}
}
