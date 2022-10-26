﻿using System.Numerics;

namespace Labb2_library;

public abstract class Shape
{
    public abstract Vector3 Center { get; }
    public abstract float Area { get; }
}