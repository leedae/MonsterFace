Shader "hubfirst/Mask+Alpha+Tint"
{
   Properties
   {
      _Color ("Color Tint (A = Opacity)", Color) = (1,1,1,1)
      _MainTex ("Base (RGB)", 2D) = "white" {}
      _Mask ("Culling Mask", 2D) = "white" {}
      _Cutoff ("Alpha cutoff", Range (0,1)) = 0.1
   }
   SubShader
   {
      Tags {"Queue"="Transparent"}
      Lighting Off
      ZWrite Off
      Blend SrcAlpha OneMinusSrcAlpha
      AlphaTest GEqual [_Cutoff]
      Pass
      {
         SetTexture [_Mask] {combine texture}
         SetTexture [_MainTex] {combine texture, previous}
         SetTexture[_MainTex] {Combine previous * constant ConstantColor[_Color]}
      }
   }
}