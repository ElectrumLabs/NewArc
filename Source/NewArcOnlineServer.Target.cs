// Copyright 1998-2014 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

 [SupportedPlatforms(UnrealPlatformClass.Server)]
public class NewArcOnlineServerTarget : TargetRules
{
    public NewArcOnlineServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
		bUsesSteam = false;
        ExtraModuleNames.Add("NewArcOnline");
    }
}
