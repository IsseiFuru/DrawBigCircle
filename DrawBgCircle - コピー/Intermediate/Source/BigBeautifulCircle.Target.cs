using UnrealBuildTool;

public class BigBeautifulCircleTarget : TargetRules
{
	public BigBeautifulCircleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BigBeautifulCircle");
	}
}
