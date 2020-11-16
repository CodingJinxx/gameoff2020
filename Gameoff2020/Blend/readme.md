# Blend Unity Project Integration

## Blend Project

The Blend/GUI.sln contains multiple projects, each project corresponding to a ui element. The resulting assets are then linked to the Assets/Views folder. This lets unity access the files needed for noesis to create ui, while allowing active development of the ui outside of unity without having to update the files.

## Adding a new UI Project

### VS Project Creation
To add a project simply add a new Unity App Project using the noesis template

### Linking the project to unity

Using a symbolic link unity can have access to the .xaml files. To create this symbolic link a admin commandline must be opened. Then navigate to ~/Gameoff2020/Assets/Views. 

Then execute the following command
```
mklink /D <ProjectName> ../../Blend/<ProjectName>/<ProjectName>/Assets
```
