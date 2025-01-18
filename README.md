<p align="center"><h1>Headbangers 7DaysToDie Mod Menu</h1></p>
<p align="center"><img src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic.wikia.nocookie.net%2F7daystodie%2Fimages%2F5%2F5e%2FDrugHackers.png%2Frevision%2Flatest%3Fcb%3D20210131082426%26path-prefix%3Dru&f=1&nofb=1&ipt=6db851c3c44f4c97b9665de652ffa0dae272f6b990f58274a03d3f87090d8bb8&ipo=images"></p>

[![GitHub release](https://img.shields.io/github/release/alloy252/7days_hack_menu?include_prereleases=&sort=semver&color=blue)](https://github.com/alloy252/7days_hack_menu/releases/)
[![License](https://img.shields.io/github/license/alloy252/7days_hack_menu)](https://opensource.org/licenses/GPL-3.0)
![Language](https://img.shields.io/badge/language-C%23-green)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue)
![Platforms](https://img.shields.io/badge/Platforms-Windows-blue)

## Table of Contents
1. [Basic Overview and Requirements](#basic-overview-and-requirements)
    - [Requirements](#requirements)
    - [Features](#features)
3. [Installation](#installation)
4. [Contributing](#contributing)

## Basic Overview and Requirements
Tired of editing .dll files every update? Look no more. This hack serves as a mod directly integrated in the 7Days ModAPI.
This repository consists of a mod including a hack menu for the game 7DaysToDie.
It is written in C# for VS2022.

### Requirements
| Operating System | .NET Framework | Installation knowledge |
| --- | --- | --- |
| Windows 7 - 11   | 4.8+ | Minimal |

### Features
* CM / DM menu : Activated on game startup whenever joining any server.
* Complete Hack GUI menu when pressing "Delete(Del)" key.
* Set your dig and build distance via menu
* Set your Build Intervall
* Set your collecting item distance
* Set a collection of constants (unfinished) consisting of:
    + dig and build distance to 75
    + build intervall to 0.2
    + sneak damage multiplier to 99
    + collecting item distance to 75
    + max player food and water to 500 (not working)
* Set your EXP multiplier
* Show all players on the map regardless of teaming up (seems not to work anymore)

## Installation
The repo uses a single tree release strategy with one release channel.
Steps on how to use this hack:
* Download the latest release on the release page [![GitHub release](https://img.shields.io/github/release/alloy252/7days_hack_menu?include_prereleases=&sort=semver&color=blue)](https://github.com/alloy252/7days_hack_menu/releases/)
* Unzip the content into your 7DaysToDie Mods folder, e.g. C:\Steam\steamapps\common\7 Days To Die\Mods
* If no Mods folder is available then create one
<pre>
📁 ~/7 Days To Die\
├── 📁Mods\
│   ├── 📁7DaysToCheat\
│       ├──📄7DaysToCheat.dll
│       └──📄Modinfo.xml
    ...
</pre>

* Start the game with EAC turned off.
* Join a server.
* After loading in press the delete button.
* Pick an option with arrow keys and confirm with keypad´s enter button.
* If asked pick an amount then press the ok button (see also at the pictures).

## Contributing
@Speegie : for pointing out how to set up a 7 Days To Die Mod using the ModAPI.

Anyone who wants to contribute is welcome. Feel free to provide aditional features and stuff.
