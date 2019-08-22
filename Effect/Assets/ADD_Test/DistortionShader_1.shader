Shader "DistortionShader_1"
{
	Properties
	{
		_Color("Color", Color) = (1,1,1,1)
		_DistortionTex("Disortion Texture(RG)", 2D) = "grey" {}
		_DistortionPower("Distortion Power", Range(0, 0.1)) = 0
		_width("Width", Range(0, 0.2)) = 0.05

	}

		SubShader
		{
			Tags {"Queue" = "Transparent" "RenderType" = "Transparent" }

			GrabPass { "_GrabPassTexture" }

			Pass {

				CGPROGRAM
			   #pragma vertex vert
			   #pragma fragment frag

			   #include "UnityCG.cginc"
				//矩形パルス関数
				#define pulse(a, b, x) (step((a),(x)) - step((b),(x)))

				 struct appdata {
					 half4 vertex                : POSITION;
					 half4 texcoord              : TEXCOORD0;
				 };

				 struct v2f {
					 half4 vertex                : SV_POSITION;
					 half2 uv                    : TEXCOORD0;
					 half4 grabPos               : TEXCOORD1;
				 };

				 sampler2D _DistortionTex;
				 half4 _DistortionTex_ST;
				 sampler2D _GrabPassTexture;
				 half _DistortionPower;
				 fixed4 _Color;
				 float _width;

				 v2f vert(appdata v)
				 {
					 v2f o = (v2f)0;

					 o.vertex = UnityObjectToClipPos(v.vertex);
					 o.uv = TRANSFORM_TEX(v.texcoord, _DistortionTex);
					 o.grabPos = ComputeGrabScreenPos(o.vertex);
					 return o;
				 }

				 fixed4 frag(v2f i) : SV_Target
				 {
					 half2 uv = i.grabPos.xy / i.grabPos.w;

					 //歪み用テクスチャをuvスクロール
					 float2 uvTmp = i.uv;
					 uvTmp.y += _Time.x * 2;

					 //rgは0~1の範囲にあるので、-0.5~0.5にずらす
					 half2 distortion = tex2D(_DistortionTex, uvTmp).rg - 0.5;

					 //歪みの強さ
					 distortion *= _DistortionPower;

					 //円外(uv座標内の半径0.5の外)のピクセルは破棄
					 float dst = distance(float2(0.5, 0.5), i.uv);
					 if (dst > 0.5)
						 discard;

					 //円の内側の半径
					 float insideRad = 0.5 - _width;

					 //背面の歪み
					 uv += distortion;
					 fixed4 distortColor = tex2D(_GrabPassTexture, uv)* step(dst,insideRad);
					 //円縁
					 fixed4 circleOutline = _Color * pulse(insideRad,0.5,dst);

					 return distortColor + circleOutline;
				 }
				 ENDCG
			 }
		}
}