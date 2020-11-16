# mklink /D <ProjectName> ../../Blend/<ProjectName>/<ProjectName>/Assets

@setlocal enableextensions
@cd /d "%~dp0"
mklink /D Menu ..\..\Blend\Menu\Menu\Assets