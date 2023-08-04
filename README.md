# YarnSpinner-Godot

This is meant to be used as a git submodule. The entire contents of this repository will go into a sub-folder of the addons folder. This is a C# solution that will be based on GDYarn (https://github.com/kyperbelt/GDYarn)

# Installation 

It is suggested to add this library as a git submodule. 

Inside the `addons` folder (create one in the root of your project if it doesnt exist), run:
`git submodule add https://github.com/VadyaRus/YarnSpinner-Godot.git`

This will clone the plugin repo inside your addons folder.

## Configure solution

You'll need to add the Yarn DLLs into your C# solution so that the compiler can path them when building.
If there is no .csproj file in the root of your project, you can generate a new one from the editor. Go to the Project Tab -> Tools -> C# -> Create C# solution

Add the following to your {project-name}.csproj inside the top level <Project> </Project> node
```
<ItemGroup>
  <Reference Include="Yarn.Antlr4.Runtime.Standard">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.Antlr4.Runtime.Standard.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.CsvHelper">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.CsvHelper.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.Google.Protobuf">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.Google.Protobuf.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.Microsoft.Bcl.AsyncInterfaces">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.Microsoft.Bcl.AsyncInterfaces.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.Microsoft.Extensions.FileSystemGlobbing">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.Microsoft.Extensions.FileSystemGlobbing.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Buffers">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Buffers.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Memory">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Memory.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Numerics.Vectors">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Numerics.Vectors.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Reflection.TypeExtensions">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Reflection.TypeExtensions.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Runtime.CompilerServices.Unsafe">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Runtime.CompilerServices.Unsafe.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Text.Encodings.Web">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Text.Encodings.Web.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Text.Json">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Text.Json.dll</HintPath>
  </Reference>
  <Reference Include="Yarn.System.Threading.Tasks.Extensions">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\Yarn.System.Threading.Tasks.Extensions.dll</HintPath>
  </Reference>
  <Reference Include="YarnSpinner">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\YarnSpinner.dll</HintPath>
  </Reference>
  <Reference Include="YarnSpinner.Compiler">
    <HintPath>addons\YarnSpinner-Godot\Runtime\DLLs\YarnSpinner.Compiler.dll</HintPath>
  </Reference>
</ItemGroup>
```

Note: Make sure to rebuild your project after editing your csproj file

## Enable the plugin

Access the plugin settings for your project from the editor by navigating to the 
Project Tab -> Project Settings
and locating the Plugins tab.

You should see the YarnSpinner-Godot plugin, click the pencil icon to edit the plugin settings and make sure the language is set to C# and not GDScript.

Then click the Enable button to enable the plugin. 