# Augmented Reality Particle System
## Introduction
This is an experimental programme for a research on Computer-Human Interface.  
This project aims at making real-time particle effects on mobile devices using Augmented Reality.  
## Platform
Unity 2017.4.2f2  
Vuforia 8.3 (Unity version)
## Project Document Structure
AR_DIY_AND_ANIMATION  
---Assets                       // core file  
------Models                    // primitive or in-progress particle models  
------Prefabs                   // well-done particle prefabs  
------Scripts                   // scripts file    
------------CORE                // core scripts  
---------------Field_Change     // scripts for change in Field parameters  
---------------Particle_Change  // scripts for change in Particle parameters  
---------------CubeController.cs  // game controller of the whole programme    
---------------GlobalVariables.cs // global variables  
---------------ModeControl.cs   // switch between Audience Mode and Director Mode  
---------------TryAllMover.cs   // particle movement controller  
---.apk                         // built apks                                      
