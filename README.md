# C# Player's Guide - Final Battle

This repository contains my implementation of **The Final Battle** challenge (including all expansions) from *The C# Player’s Guide* by RB Whitaker.

## Overview

The game is a turn-based console RPG encounter where a hero party fights through multiple enemy waves, ending in a final battle against **The Uncoded One**.

The following challenges has been implemented:

**Core Game**

- [x] Building Character
- [x] The True Programmer
- [x] Actions and Players
- [x] Attacks
- [x] Damage and HP
- [x] Death
- [x] Battle Series
- [x] The Uncoded One
- [x] The Player Decides

**Expansions**
- [x] The Game's Status
- [x] Items
- [ ] Gear
- [ ] Stolen Inventory
- [ ] Vin Fletcher
- [ ] Attack Modifiers
- [ ] Damage Types
- [ ] Making It Yours
- [ ] Restoring Balance

## Tech Stack

- Language: C#
- Runtime: .NET 10 (`net10.0`)
- App type: Console application

## Project Structure

The source code is organized under `FinalBattle/`:

- `Actions/` - Turn actions (attack, do nothing)
- `AttackTypes/` - Attack definitions and damage data
- `Battles/` - Battle loop and party resolution
- `Characters/` - Hero and enemy character types
- `Parties/` - Party and factory setup for heroes/enemies
- `Player/` - Human and computer player behavior
- `Game.cs` - Overall game setup and progression
- `Program.cs` - Application entry point

## Requirements

Make sure the following is installed:

- .NET SDK 10.0+

Check your version:

```bash
dotnet --version
```

## Getting the Project

```bash
git clone https://github.com/<your-username>/csharp-players-guide-final-battle.git
cd csharp-players-guide-final-battle
```

> Replace `<your-username>` with the correct GitHub username.

## Build and Run

From the repository root:

```bash
dotnet restore
dotnet build
dotnet run --project csharp-players-guide-final-battle.csproj
```

## How to Play

When the game starts:

1. Choose a game mode from the menu.
2. Enter the True Programmer's name (if applicable).
3. Follow console prompts each turn to select actions/targets.
4. Defeat all enemy parties to win.
