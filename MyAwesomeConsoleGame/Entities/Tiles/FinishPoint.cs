﻿using System;
using ConsoleEngine.Infrastructure.Rendering;

namespace MyAwesomeConsoleGame.Entities.Tiles
{
    public class FinishPoint : MapTile
    {
        private static readonly Sprite FinishSprite = Sprite.FromStringArray(new []{
            "F▓▒",
            "▓▒▓",
            "▒▓▒",
        }, ConsoleColor.DarkGreen);
        
        public FinishPoint(MyAwesomeGame game) : base(game) {}

        public override Sprite GetSprite() => FinishSprite;
    }
}