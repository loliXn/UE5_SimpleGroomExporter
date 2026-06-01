// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class SimpleGroomExporter : ModuleRules
{
	public SimpleGroomExporter(
		ReadOnlyTargetRules Target
	) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(
			new string[]
			{
				// ... add public include paths required here ...
			}
		);
		//OptimizeCode = CodeOptimization.Never;


		PrivateIncludePaths.AddRange(
			new string[]
			{
				// ... add other private include paths required here ...
			}
		);

		PublicIncludePathModuleNames.AddRange(new string[]
			{
				"AlembicLib"
				, "AlembicLibrary"
			}
		);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core"
				, "AlembicLib"
				, "AlembicLibrary"
				, "ToolMenus"
				, "AssetTools"
				, "ContentBrowser"
				// ... add other public dependencies that you statically link with here ...
			}
		);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject"
				, "Engine"
				, "Slate"
				, "SlateCore"
				, "InputCore"
				, "EditorFramework"
				, "AppFramework"
				, "UnrealEd"
				, "HairStrandsCore"
				, "PropertyEditor"
				// ... add private dependencies that you statically link with here ...	
			}
		);

		if (Directory.Exists(Path.Combine(Target.EngineDirectory, "Source/Editor/EditorStyle")))
		{
			PrivateDependencyModuleNames.Add("EditorStyle");
		}


		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
		);
	}
}