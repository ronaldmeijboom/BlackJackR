﻿using System;
using System.Windows.Input;
using Blackjack.ViewModels;

namespace Blackjack.Commands
{
    public class StandRightCommand : ICommand
    {
        private readonly GameViewModel viewModel;

        public StandRightCommand(GameViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (viewModel.Player.SplitDeck.FinishedRight)
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            // Show points left.
            // End left turn

            viewModel.Player.SplitDeck.FinishedRight = true;
        }
    }
}
