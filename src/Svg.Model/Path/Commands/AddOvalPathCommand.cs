﻿
using Svg.Model.Primitives;

namespace Svg.Model.Path.Commands
{
    public sealed class AddOvalPathCommand : PathCommand
    {
        public Rect Rect { get; }

        public AddOvalPathCommand(Rect rect)
        {
            Rect = rect;
        }
    }
}
