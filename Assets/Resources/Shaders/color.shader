Shader "hubfirst/color"

{  

    Properties

    {

        _Color ("Main Color", Color) = (1,1,1)

    }

    

    SubShader

    {

        ZWrite On // "Off" might make more sense in very specific games

        Pass

        {

            Color [_Color]

        }

    }

}