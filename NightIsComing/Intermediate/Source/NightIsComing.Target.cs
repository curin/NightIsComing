using UnrealBuildTool;

public class NightIsComingTarget : TargetRules
{
	public NightIsComingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("NightIsComing");
	}
}
