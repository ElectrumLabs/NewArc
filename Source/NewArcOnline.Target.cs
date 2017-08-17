// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NewArcOnlineTarget : TargetRules
{
	public NewArcOnlineTarget(TargetInfo Target) : base(Target)
    {
		Type = TargetType.Game;
        ExtraModuleNames.Add("NewArcOnline");
	}
}
