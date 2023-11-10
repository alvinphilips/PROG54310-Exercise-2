#if OPENGL
	#define SV_POSITION POSITION
	#define VS_SHADERMODEL vs_3_0
	#define PS_SHADERMODEL ps_3_0
#else
	#define VS_SHADERMODEL vs_4_0_level_9_1
	#define PS_SHADERMODEL ps_4_0_level_9_1
#endif

matrix WorldViewProjection;

static float3x3 RGBtoYUV = { 0.299,		0.587,		0.114,
							-0.14713,  -0.28886,	0.436,
							 0.615,	   -0.51499,   -0.10001};

static float3x3 YUVtoRGB = {1,	0,			1.13983,
							1, -0.39465,   -0.58060,
							1,	2.03211,	0};

float3 YUV_ratio;
float invert = 0;

texture Texture;
sampler BasicTextureSampler = sampler_state
{
    texture = <Texture>;
};

struct VertexShaderInput
{
	float4 Position : POSITION0;
	float3 Color : NORMAL0;
    float2 UV : TEXCOORD0;
};

struct VertexShaderOutput
{
    float4 Position : SV_POSITION;
    float3 Color : NORMAL0;
    float2 UV : TEXCOORD0;
};

VertexShaderOutput MainVS(in VertexShaderInput input)
{
	VertexShaderOutput output = (VertexShaderOutput)0;

	output.Position = mul(input.Position, WorldViewProjection);
	output.Color = input.Color;
    output.UV = input.UV;

	return output;
}

float4 MainPS(VertexShaderOutput input) : COLOR
{
    float3 color = tex2D(BasicTextureSampler, input.UV);
    float3 yuv = mul(RGBtoYUV, color);
    yuv *= YUV_ratio;
    color = mul(YUVtoRGB, yuv) - float3(invert, invert, invert);
    return float4(abs(color), 1);
}

technique BasicColorDrawing
{
	pass P0
	{
		VertexShader = compile VS_SHADERMODEL MainVS();
		PixelShader = compile PS_SHADERMODEL MainPS();
	}
};