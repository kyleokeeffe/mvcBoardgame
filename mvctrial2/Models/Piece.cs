﻿using mvctrial2.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using mvctrial2.Services;

namespace mvctrial2.Models
{
    public class Piece
    {
        private System.Windows.Media.Brush _Color;
        private int _X;
        private int _Y;
        private Square _Location;
        

        public int X { get {return this._X; } set {this._X = value; } }
        public int Y { get {return this._Y; } set {this._Y = value; } }
        public System.Windows.Media.Brush Color { get { return this._Color; } set { this._Color = value; } }
        public Square Location { get {return this._Location; } set { this._Location = value; } }
        
        public Piece(System.Windows.Media.Brush color, int x, int y)
        {
            this._Color = color;
            this.X = x;
            this.Y = y;
            this.Location = ControllerService.BoardCon.GetSquare(x, y);

        }

    }
}
