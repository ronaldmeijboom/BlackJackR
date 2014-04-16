﻿using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Blackjack.Models
{
    public class Player
    {
        public List<Image> Images { get; set; }
        public BitmapImage ImageBack { get; set; }
        public SplitDeck SplitDeck { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public int CurrentScore { get; set; }
        public int PlayerAcesCount { get; set; }
        public int CurrentImage { get; set; }

        public Player(string name, int money, BitmapImage backSide, int currentImage)
        {
            this.Images = new List<Image>();
            this.SplitDeck = new SplitDeck();
            this.Name = name;
            this.Money = money;
            this.ImageBack = backSide;
            this.CurrentImage = currentImage;
        }
    }
}
