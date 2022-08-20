#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED


#define cmp -
void main_float(
    SamplerState s1_s,
    SamplerState s2_s,
    SamplerState s3_s,
    SamplerState s4_s,
    SamplerState s5_s,
    SamplerState s6_s,
    SamplerState s7_s,

    float2 tx,

    Texture2D<float4> t0,
    Texture2D<float4> t1,
    Texture2D<float4> t2,
    Texture2D<float4> t3,
    Texture2D<float4> t4,
    Texture2D<float4> t5,
    Texture2D<float4> t6,
    Texture2D<float4> t7,
    Texture2D<float4> t8,
    Texture2D<float4> t9,
    Texture2D<float4> t10,
    Texture2D<float4> t11,
    Texture2D<float4> t12,
    Texture2D<float4> t13,
    Texture2D<float4> t14,
    Texture2D<float4> t15,
    Texture2D<float4> t16,
    Texture2D<float4> t17,
    Texture2D<float4> t18,
    Texture2D<float4> t19,
    Texture2D<float4> t20,
    Texture2D<float4> t21,
    Texture2D<float4> t22,
    Texture2D<float4> t23,
    Texture2D<float4> t24,
    Texture2D<float4> t25,
    Texture2D<float4> t26,
    Texture2D<float4> t27,
    Texture2D<float4> t28,
    Texture2D<float4> t29,

    out float3 Base,
    out float3 Normal,
    out float Metallic,
    out float EmissiveColor,
    out float Smoothness,
    out float AO,
    out float Alpha
)
{
    Base = float3(1, 1, 1);
    Normal = float3(1, 1, 1);
    Metallic = 1;
    EmissiveColor = 1;
    Smoothness = 1;
    AO = 1;
    Alpha = 1;

}
#endif
