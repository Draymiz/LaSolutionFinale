Shader "Custom/Portail"

ZWrite Off
ColorMask 0

Pass{
	Stencil {
		Ref 1
		Comp always
		Pass replace
	}
}