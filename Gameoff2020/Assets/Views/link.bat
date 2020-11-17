# mklink /D <ProjectName> ../../Blend/<ProjectName>/<ProjectName>/Assets

@setlocal enableextensions
@cd /d "%~dp0"
mklink /D ButtonMenu ..\..\Blend\ButtonMenu\ButtonMenu\Assets