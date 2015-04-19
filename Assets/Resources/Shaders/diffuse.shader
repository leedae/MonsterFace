Shader "hubfirst/diffuse"

{  

    Properties

    {

        _MainTex ("Texture", 2D) = ""

    }

 

    SubShader

    {

        ZWrite On // "Off" might make more sense in very specific games

        Pass

        {

            SetTexture[_MainTex]

        }

    }

}