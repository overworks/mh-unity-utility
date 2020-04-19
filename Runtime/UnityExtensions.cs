using UnityEngine;

namespace Mh
{
    public static class UnityExtensions
    {
        public static bool IsRealNull(this Object obj)
        {
            return ReferenceEquals(obj, null);
        }

        public static bool IsFakeNull(this Object obj)
        {
            return !IsRealNull(obj) && obj;
        }

        public static bool IsAssigned(this Object obj)
        {
            return obj;
        }

        public static Vector2 Rotate(this Vector2 v, float degree)
        {
            var radian = degree * Mathf.Deg2Rad;

            var cos = Mathf.Cos(radian);
            var sin = Mathf.Sin(radian);

            var vx = v.x;
            var vy = v.y;

            return new Vector2((vx * cos) - (vy * sin), (vx * sin) + (vy * cos));
        }
    }
}