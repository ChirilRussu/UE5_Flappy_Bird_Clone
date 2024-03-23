using UnrealBuildTool;

public class FlappyBirdEditorTarget : TargetRules
{
	public FlappyBirdEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FlappyBird");
	}
}
