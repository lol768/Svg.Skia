﻿
using Svg.Model.Primitives;

namespace Svg.Model.Path.Commands
{
    public sealed class AddRoundRectPathCommand : PathCommand
    {
        public Rect Rect { get; }
        public float Rx { get; }
        public float Ry { get; }

        public AddRoundRectPathCommand(Rect rect, float rx, float ry)
        {
            Rect = rect;
            Rx = rx;
            Ry = ry;
        }
    }
}
