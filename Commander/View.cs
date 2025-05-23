﻿using System;
using Commander.Contracts;
using Commander.Core;

namespace Commander
{
    /// <summary>
    /// Every view in your application has to inherit from this class
    /// </summary>
    public abstract class View
    {
        private IInputHandler _inputStream = new InputHandler();

        public View()
        {
            _inputStream.KeyDownEvent += OnKeyDown;
        }

        public abstract void ConstructView();

        public virtual void OnKeyDown(object sender, ConsoleKey key) {}
    }
}