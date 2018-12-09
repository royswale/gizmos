﻿using UnityEngine;

namespace Popcron
{
    public class Circle : Drawer
    {
        public override Vector3[] Draw(params object[] values)
        {
            Vector2 position = (Vector2)values[0];
            float radius = (float)values[1];

            return Polygon.Draw(position, Quaternion.identity, radius, 16, 0);
        }
    }
}
