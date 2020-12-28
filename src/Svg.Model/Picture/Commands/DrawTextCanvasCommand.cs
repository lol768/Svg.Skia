﻿
namespace Svg.Model.Picture.Commands
{
    public sealed class DrawTextCanvasCommand : CanvasCommand
    {
        public string Text { get; }
        public float X { get; }
        public float Y { get; }
        public Paint.Paint? Paint { get; }

        public DrawTextCanvasCommand(string text, float x, float y, Paint.Paint paint)
        {
            Text = text;
            X = x;
            Y = y;
            Paint = paint;
        }
    }
}
