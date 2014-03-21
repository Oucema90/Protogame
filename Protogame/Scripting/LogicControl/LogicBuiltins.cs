﻿// <auto-generated />
namespace LogicControl
{
    using System;
    using Microsoft.Xna.Framework;

    public static class LogicBuiltins
    {
    public static object Max(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Max(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Max(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Max(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }                if (values[0] is float)
        {
            return MathHelper.Max(
                            Convert.ToSingle(values[0])
                ,                Convert.ToSingle(values[1])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Max");
    }
        public static object Min(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Min(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Min(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Min(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }                if (values[0] is float)
        {
            return MathHelper.Min(
                            Convert.ToSingle(values[0])
                ,                Convert.ToSingle(values[1])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Min");
    }
        public static object Lerp(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Lerp(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                ,                Convert.ToSingle(values[2])
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Lerp(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                ,                Convert.ToSingle(values[2])
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Lerp(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                ,                Convert.ToSingle(values[2])
);
        }        if (values[0] is Matrix&&values[1] is Matrix)
        {
            return Matrix.Lerp(
                            (Matrix)values[0]
                ,                (Matrix)values[1]
                ,                Convert.ToSingle(values[2])
);
        }
                        if (values[0] is float)
        {
            return MathHelper.Lerp(
                            Convert.ToSingle(values[0])
                ,                Convert.ToSingle(values[1])
                ,                Convert.ToSingle(values[2])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Lerp");
    }
        public static object Sin(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Sin(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Sin(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Sin(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Sin(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Sin(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Sin(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Sin(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Sin(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Sin(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Sin(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Sin");
    }
        public static object Cos(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Cos(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Cos(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Cos(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Cos(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Cos(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Cos(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Cos(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Cos(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Cos(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Cos(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Cos");
    }
        public static object Tan(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Tan(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Tan(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Tan(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Tan(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Tan(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Tan(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Tan(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Tan(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Tan(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Tan(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Tan");
    }
        public static object Asin(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Asin(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Asin(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Asin(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Asin(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Asin(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Asin(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Asin(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Asin(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Asin(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Asin(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Asin");
    }
        public static object Acos(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Acos(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Acos(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Acos(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Acos(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Acos(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Acos(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Acos(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Acos(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Acos(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Acos(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Acos");
    }
        public static object Atan(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Atan(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Atan(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Atan(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Atan(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Atan(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Atan(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Atan(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Atan(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Atan(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Atan(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Atan");
    }
        public static object Atan2(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return new Vector2(
                (float)Math.Atan2(
                            ((Vector2)values[0]).X
                ,                ((Vector2)values[1]).X
                ),
                (float)Math.Atan2(
                            ((Vector2)values[0]).Y
                ,                ((Vector2)values[1]).Y
                ));
        }
                if (values[0] is Vector3&&values[1] is Vector3)
        {
            return new Vector3(
                (float)Math.Atan2(
                            ((Vector3)values[0]).X
                ,                ((Vector3)values[1]).X
                ),
                (float)Math.Atan2(
                            ((Vector3)values[0]).Y
                ,                ((Vector3)values[1]).Y
                ),
                (float)Math.Atan2(
                            ((Vector3)values[0]).Z
                ,                ((Vector3)values[1]).Z
                ));
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return new Vector4(
                (float)Math.Atan2(
                            ((Vector4)values[0]).X
                ,                ((Vector4)values[1]).X
                ),
                (float)Math.Atan2(
                            ((Vector4)values[0]).Y
                ,                ((Vector4)values[1]).Y
                ),
                (float)Math.Atan2(
                            ((Vector4)values[0]).Z
                ,                ((Vector4)values[1]).Z
                ),
                (float)Math.Atan2(
                            ((Vector4)values[0]).W
                ,                ((Vector4)values[1]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Atan2(
                            Convert.ToSingle(values[0])
                ,                Convert.ToSingle(values[1])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Atan2");
    }
        public static object Abs(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Abs(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Abs(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Abs(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Abs(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Abs(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Abs(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Abs(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Abs(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Abs(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Abs(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Abs");
    }
        public static object Ceiling(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Ceiling(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Ceiling(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Ceiling(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Ceiling(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Ceiling(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Ceiling(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Ceiling(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Ceiling(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Ceiling(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Ceiling(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Ceiling");
    }
        public static object Floor(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Floor(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Floor(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Floor(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Floor(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Floor(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Floor(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Floor(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Floor(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Floor(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Floor(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Floor");
    }
        public static object Round(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return new Vector2(
                (float)Math.Round(
                            ((Vector2)values[0]).X
                ),
                (float)Math.Round(
                            ((Vector2)values[0]).Y
                ));
        }
                if (values[0] is Vector3)
        {
            return new Vector3(
                (float)Math.Round(
                            ((Vector3)values[0]).X
                ),
                (float)Math.Round(
                            ((Vector3)values[0]).Y
                ),
                (float)Math.Round(
                            ((Vector3)values[0]).Z
                ));
        }
                if (values[0] is Vector4)
        {
            return new Vector4(
                (float)Math.Round(
                            ((Vector4)values[0]).X
                ),
                (float)Math.Round(
                            ((Vector4)values[0]).Y
                ),
                (float)Math.Round(
                            ((Vector4)values[0]).Z
                ),
                (float)Math.Round(
                            ((Vector4)values[0]).W
                ));
        }
                    if (values[0] is float)
        {
            return (float)Math.Round(
                            Convert.ToSingle(values[0])
                );
        }
        
        throw new InvalidOperationException("Invalid type for Round");
    }
        public static object Add(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Add(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Add(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Add(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        if (values[0] is Matrix&&values[1] is Matrix)
        {
            return Matrix.Add(
                            (Matrix)values[0]
                ,                (Matrix)values[1]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Add");
    }
        public static object Subtract(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Subtract(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Subtract(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Subtract(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        if (values[0] is Matrix&&values[1] is Matrix)
        {
            return Matrix.Subtract(
                            (Matrix)values[0]
                ,                (Matrix)values[1]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Subtract");
    }
        public static object Multiply(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Multiply(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Multiply(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Multiply(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        if (values[0] is Matrix&&values[1] is Matrix)
        {
            return Matrix.Multiply(
                            (Matrix)values[0]
                ,                (Matrix)values[1]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Multiply");
    }
        public static object Divide(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Divide(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Divide(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Divide(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        if (values[0] is Matrix&&values[1] is Matrix)
        {
            return Matrix.Divide(
                            (Matrix)values[0]
                ,                (Matrix)values[1]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Divide");
    }
        public static object Negate(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return Vector2.Negate(
                            (Vector2)values[0]
                );
        }
        if (values[0] is Vector3)
        {
            return Vector3.Negate(
                            (Vector3)values[0]
                );
        }
                if (values[0] is Vector4)
        {
            return Vector4.Negate(
                            (Vector4)values[0]
                );
        }        if (values[0] is Matrix)
        {
            return Matrix.Negate(
                            (Matrix)values[0]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Negate");
    }
        public static object Dot(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Dot(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Dot(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Dot(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        
        throw new InvalidOperationException("Invalid type for Dot");
    }
        public static object Cross(System.Collections.Generic.List<object> values)
    {
    
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Cross(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                
        throw new InvalidOperationException("Invalid type for Cross");
    }
        public static object Normalize(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2)
        {
            return Vector2.Normalize(
                            (Vector2)values[0]
                );
        }
        if (values[0] is Vector3)
        {
            return Vector3.Normalize(
                            (Vector3)values[0]
                );
        }
                if (values[0] is Vector4)
        {
            return Vector4.Normalize(
                            (Vector4)values[0]
                );
        }        
        throw new InvalidOperationException("Invalid type for Normalize");
    }
        public static object Distance(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.Distance(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.Distance(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.Distance(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        
        throw new InvalidOperationException("Invalid type for Distance");
    }
        public static object DistanceSquared(System.Collections.Generic.List<object> values)
    {
            if (values[0] is Vector2&&values[1] is Vector2)
        {
            return Vector2.DistanceSquared(
                            (Vector2)values[0]
                ,                (Vector2)values[1]
                );
        }
        if (values[0] is Vector3&&values[1] is Vector3)
        {
            return Vector3.DistanceSquared(
                            (Vector3)values[0]
                ,                (Vector3)values[1]
                );
        }
                if (values[0] is Vector4&&values[1] is Vector4)
        {
            return Vector4.DistanceSquared(
                            (Vector4)values[0]
                ,                (Vector4)values[1]
                );
        }        
        throw new InvalidOperationException("Invalid type for DistanceSquared");
    }
    
        public static object Transform(params object[] values)
        {
            if (values[0] is Vector2 && values[1] is Matrix)
            {
                return Vector2.Transform(
                    (Vector2)values[0],
                    (Matrix)values[1]);
            }

            if (values[0] is Vector3 && values[1] is Matrix)
            {
                return Vector3.Transform(
                    (Vector3)values[0],
                    (Matrix)values[1]);
            }

            if (values[0] is Vector4 && values[1] is Matrix)
            {
                return Vector4.Transform(
                    (Vector4)values[0],
                    (Matrix)values[1]);
            }

            throw new InvalidOperationException("Invalid type for Transform");
        }
    }
}
