﻿using System;
using Svg.Model.Primitives;

namespace Svg.Model.Path
{
    public class PathClip : IDisposable
    {
        public Path? Path { get; set; }
        public Matrix? Transform { get; set; }
        public ClipPath? Clip { get; set; }

        public void Dispose()
        {
        }
    }
}
