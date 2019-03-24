﻿using System.Numerics;
using DirectX12GameEngine.Shaders;

namespace DirectX12GameEngine.Rendering.Core
{
    public struct ViewProjectionTransform
    {
        [ShaderResource] public Matrix4x4 ViewMatrix { get; set; }

        [ShaderResource] public Matrix4x4 InverseViewMatrix { get; set; }

        [ShaderResource] public Matrix4x4 ProjectionMatrix { get; set; }

        [ShaderResource] public Matrix4x4 ViewProjectionMatrix { get; set; }
    }
}