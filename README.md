<p align="center"><h1>Headbangers 7DaysToDie Mod Menu</h1></p>
<p align="center"><img src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic.wikia.nocookie.net%2F7daystodie%2Fimages%2F5%2F5e%2FDrugHackers.png%2Frevision%2Flatest%3Fcb%3D20210131082426%26path-prefix%3Dru&f=1&nofb=1&ipt=6db851c3c44f4c97b9665de652ffa0dae272f6b990f58274a03d3f87090d8bb8&ipo=images"></p>

[![GitHub release](https://img.shields.io/github/release/alloy252/7days_hack_menu?include_prereleases=&sort=semver&color=blue)](https://github.com/alloy252/7days_hack_menu/releases/)
[![License](https://img.shields.io/github/license/alloy252/7days_hack_menu)](https://opensource.org/licenses/GPL-3.0)

## Basic Overview
This repository consists of a mod including a hack menu for the game 7DaysToDie.
It is written in C# for VS2022.

## Features

* CM / DM menu : Activated on game startup whenever joining any server.
* Complete Hack menu when pressing "Delete(Del)" key.
* Theoretical simulation of EAC. Not really working since its just the checked Game Prefs.
* Set dig and build distance via menu
* Set Build Intervall
* Set collecting item distance
* Set a collection of constants (unfinished) consisting of:
    + Show all players on the map regardless of teaming up 
    + dig and build distance to 500
    + build intervall to 0.2
    + sneak damage multiplier to 99
    + collecting item distance to 99
    + theoretical max entities per mob spawner to 15 (should be only clientsided)
    + max player food and water to 500
    + other vrious nonfunctional stuff like airdrop timer, Animal count, Score Zombie Multiplier, etc.

## Requirements
| Operating System | .NET Framework | Installation knowledge |
| --- | --- | --- |
| Windows 7 - 11   | 4.8+ | Minimal |

## Installation - Windows

The repo uses a single tree release strategy with one release channel.
Steps on how to use this hack:
* Go to releases: [![GitHub release](https://img.shields.io/github/release/alloy252/7days_hack_menu?include_prereleases=&sort=semver&color=blue)](https://github.com/alloy252/7days_hack_menu/releases/)
* Download the latest release (7DaysToCheat.zip).
* Unzip the content into your 7DaysToDie installation folder, e.g. C:\Steam\steamapps\common\7 Days To Die\
* Start the game with EAC turned off.

## Credits
@Speegie : for pointing out how to set up a 7 Days To Die Mod using the ModAPI.
