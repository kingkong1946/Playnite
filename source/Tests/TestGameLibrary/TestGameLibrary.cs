﻿using Playnite.SDK;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestGameLibrary
{
    public class TestGameLibrary : ILibraryPlugin
    {
        public ISettings Settings { get; }

        public Guid Id { get; } = Guid.Parse("D625A3B7-1AA4-41CB-9CD7-74448D28E99B");

        public string Name { get; } = "Test Library";

        public string LibraryIcon { get; }

        public UserControl SettingsView { get; }

        public ILibraryClient Client { get; }

        public TestGameLibrary(IPlayniteAPI api)
        {
            LibraryIcon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\installer.ico");
        }

        public void Dispose()
        {

        }

        public IEnumerable<Game> GetGames()
        {
            return new List<Game>()
            {
                new Game("Notepad")
                {
                    GameId = "notepad",
                    PluginId = Id,
                    PlayAction = new GameAction()
                    {
                        Type = GameActionType.File,
                        Path = "notepad.exe"
                    },
                    State = new GameState() { Installed = true },
                    Icon = @"c:\Windows\notepad.exe"
                },
                new Game("Calculator")
                {
                    GameId = "calc",
                    PluginId = Id,
                    PlayAction = new GameAction()
                    {
                        Type = GameActionType.File,
                        Path = "calc.exe"
                    },
                    State = new GameState() { Installed = true },
                    Icon = @"https://playnite.link/applogo.png",
                    BackgroundImage =  @"https://playnite.link/applogo.png"
                },
                new Game("Paint")
                {
                    GameId = "mspaint",
                    PluginId = Id,
                    PlayAction = new GameAction()
                    {
                        Type = GameActionType.File,
                        Path = "mspaint.exe"
                    },
                    State = new GameState() { Installed = true },
                    Icon = LibraryIcon
                },
                new Game("WordPad")
                {
                    GameId = "write",
                    PluginId = Id,
                    PlayAction = new GameAction()
                    {
                        Type = GameActionType.File,
                        Path = "write.exe"
                    },
                    State = new GameState() { Installed = true },
                    Icon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\icon.tga")
                }
            };
        }

        public IGameController GetGameController(Game game)
        {
            return null;
        }

        public ILibraryMetadataProvider GetMetadataDownloader()
        {
            return null;
        }
    }
}
