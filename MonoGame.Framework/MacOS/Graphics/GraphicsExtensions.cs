﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoMac.OpenGL;

namespace Microsoft.Xna.Framework.Graphics
{
    public static class GraphicsExtensions
    {
        public static All OpenGL11(CullMode cull)
        {
            switch (cull)
            {
                case CullMode.CullClockwiseFace:
                    return All.Cw;
                case CullMode.CullCounterClockwiseFace:
                    return All.Ccw;
                default:
                    throw new NotImplementedException();
            }
        }

        public static int OpenGLNumberOfElements(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    throw new NotImplementedException();

                case VertexElementFormat.Vector2:
                    return 2;

                case VertexElementFormat.Vector3:
                    return 3;

                case VertexElementFormat.Vector4:
                    return 4;

                case VertexElementFormat.Color:
                    return 4;

                case VertexElementFormat.Byte4:
                    return 4;

                case VertexElementFormat.Short2:
                    return 2;

                case VertexElementFormat.Short4:
                    return 2;

                case VertexElementFormat.NormalizedShort2:
                    return 2;

                case VertexElementFormat.NormalizedShort4:
                    return 4;

                case VertexElementFormat.HalfVector2:
                    return 2;

                case VertexElementFormat.HalfVector4:
                    return 4;
            }

            throw new NotImplementedException();
        }

        public static VertexPointerType OpenGLVertexPointerType(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    throw new NotImplementedException();

                case VertexElementFormat.Vector2:
                    return VertexPointerType.Float;

                case VertexElementFormat.Vector3:
                    return VertexPointerType.Float;

                case VertexElementFormat.Vector4:
                    return VertexPointerType.Float;

                case VertexElementFormat.Color:
                    return VertexPointerType.Float;

                case VertexElementFormat.Byte4:
                    return VertexPointerType.Short;

                case VertexElementFormat.Short2:
                    return VertexPointerType.Short;

                case VertexElementFormat.Short4:
                    return VertexPointerType.Short;

                case VertexElementFormat.NormalizedShort2:
                    return VertexPointerType.Short;

                case VertexElementFormat.NormalizedShort4:
                    return VertexPointerType.Short;

                case VertexElementFormat.HalfVector2:
                    return VertexPointerType.Float;

                case VertexElementFormat.HalfVector4:
                    return VertexPointerType.Float;
            }

            throw new NotImplementedException();
        }

        public static ColorPointerType OpenGLColorPointerType(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    throw new NotImplementedException();

                case VertexElementFormat.Vector2:
                    return ColorPointerType.Float;

                case VertexElementFormat.Vector3:
                    return ColorPointerType.Float;

                case VertexElementFormat.Vector4:
                    return ColorPointerType.Float;

                case VertexElementFormat.Color:
                    return ColorPointerType.Float;

                case VertexElementFormat.Byte4:
                    return ColorPointerType.UnsignedByte;

                case VertexElementFormat.Short2:
                    return ColorPointerType.Short;

                case VertexElementFormat.Short4:
                    return ColorPointerType.Short;

                case VertexElementFormat.NormalizedShort2:
                    return ColorPointerType.UnsignedShort;

                case VertexElementFormat.NormalizedShort4:
                    return ColorPointerType.UnsignedShort;

                case VertexElementFormat.HalfVector2:
                    return ColorPointerType.HalfFloat;

                case VertexElementFormat.HalfVector4:
                    return ColorPointerType.HalfFloat;
            }

            throw new NotImplementedException();
        }

       public static NormalPointerType OpenGLNormalPointerType(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    throw new NotImplementedException();

                case VertexElementFormat.Vector2:
                    return NormalPointerType.Float;

                case VertexElementFormat.Vector3:
                    return NormalPointerType.Float;

                case VertexElementFormat.Vector4:
                    return NormalPointerType.Float;

                case VertexElementFormat.Color:
                    return NormalPointerType.Float;

                case VertexElementFormat.Byte4:
                    return NormalPointerType.Byte;

                case VertexElementFormat.Short2:
                    return NormalPointerType.Short;

                case VertexElementFormat.Short4:
                    return NormalPointerType.Short;

                case VertexElementFormat.NormalizedShort2:
                    return NormalPointerType.Short;

                case VertexElementFormat.NormalizedShort4:
                    return NormalPointerType.Short;

                case VertexElementFormat.HalfVector2:
                    return NormalPointerType.HalfFloat;

                case VertexElementFormat.HalfVector4:
                    return NormalPointerType.HalfFloat;
            }

            throw new NotImplementedException();
        }

       public static TexCoordPointerType OpenGLTexCoordPointerType(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    throw new NotImplementedException();

                case VertexElementFormat.Vector2:
                    return TexCoordPointerType.Float;

                case VertexElementFormat.Vector3:
                    return TexCoordPointerType.Float;

                case VertexElementFormat.Vector4:
                    return TexCoordPointerType.Float;

                case VertexElementFormat.Color:
                    return TexCoordPointerType.Float;

                case VertexElementFormat.Byte4:
                    return TexCoordPointerType.Float;

                case VertexElementFormat.Short2:
                    return TexCoordPointerType.Short;

                case VertexElementFormat.Short4:
                    return TexCoordPointerType.Short;

                case VertexElementFormat.NormalizedShort2:
                    return TexCoordPointerType.Short;

                case VertexElementFormat.NormalizedShort4:
                    return TexCoordPointerType.Short;

                case VertexElementFormat.HalfVector2:
                    return TexCoordPointerType.HalfFloat;

                case VertexElementFormat.HalfVector4:
                    return TexCoordPointerType.HalfFloat;
            }

            throw new NotImplementedException();
        }

        public static int Size(this SurfaceFormat surfaceFormat)
        {
            switch (surfaceFormat)
            {
                case SurfaceFormat.Color:
                    return 0;
                case SurfaceFormat.Dxt3:
                    return 4;
                case SurfaceFormat.Bgra4444:
                    return 2;
                case SurfaceFormat.Bgra5551:
                    return 2;
                case SurfaceFormat.Alpha8:
                    return 1;
                default:
                    throw new NotImplementedException();
            }
        }
		
        public static int GetTypeSize(this VertexElementFormat elementFormat)
        {
            switch (elementFormat)
            {
                case VertexElementFormat.Single:
                    return 4;

                case VertexElementFormat.Vector2:
                    return 8;

                case VertexElementFormat.Vector3:
                    return 12;

                case VertexElementFormat.Vector4:
                    return 0x10;

                case VertexElementFormat.Color:
                    return 4;

                case VertexElementFormat.Byte4:
                    return 4;

                case VertexElementFormat.Short2:
                    return 4;

                case VertexElementFormat.Short4:
                    return 8;

                case VertexElementFormat.NormalizedShort2:
                    return 4;

                case VertexElementFormat.NormalizedShort4:
                    return 8;

                case VertexElementFormat.HalfVector2:
                    return 4;

                case VertexElementFormat.HalfVector4:
                    return 8;
            }
            return 0;
        }
    }
}
