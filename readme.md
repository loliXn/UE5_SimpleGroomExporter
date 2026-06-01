Unreal Engine 5 groom exporter to alembic.

just right click the groom asset -> asset actions -> export

the export very bare bones at the moment, it only exports base curves without hair attributes like width etc, so pull requests are welcome! 

once you import into your DDC you can convert to blender hair curves, particle systems etc.

## install from source
- use UE 5.8.0 (the .uplugin targets 5.8.0); if you’re on a different UE version, update the EngineVersion field in SimpleGroomExporter.uplugin.
- copy this repo into one of these locations:
  - project: <YourProject>/Plugins/SimpleGroomExporter/
  - engine: <UE>/Engine/Plugins/Marketplace/SimpleGroomExporter/
- ensure dependencies are enabled in your project: HairStrands and AlembicImporter (links AlembicLib/AlembicLibrary).
- generate project files and build (or let the editor compile on first open), then enable the plugin in the Plugins window if needed.

## package a release
- in editor: plugins window -> SimpleGroomExporter -> package plugin
- or run:
  ```
  RunUAT BuildPlugin -plugin=<path to SimpleGroomExporter.uplugin> -package=<output folder> -targetplatforms=Win64
  ```
- copy the packaged output into the engine or project Plugins folder, reopen the editor, and verify the export action appears on Groom assets.

feel free to open issues if you have any.

for quick question join my discord server https://discord.gg/PvbKTYbKR5
if you need binaries, they are available on the discord server

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/V7V6YBSIL)
