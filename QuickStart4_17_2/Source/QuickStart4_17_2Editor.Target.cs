// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class QuickStart4_17_2EditorTarget : TargetRules
{
	public QuickStart4_17_2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "QuickStart4_17_2" } );
	}
}
