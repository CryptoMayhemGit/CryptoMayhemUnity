// Amplify Shader Editor - Visual Shader Editing Tool
// Copyright (c) Amplify Creations, Lda <info@amplify.pt>
using UnityEditor;

namespace AmplifyShaderEditor
{
	public class TemplateMenuItems
	{
		[MenuItem( "Assets/Create/Amplify Shader/Custom Render Texture/Initialize", false, 85 )]
		public static void ApplyTemplateCustomRenderTextureInitialize()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "6ce779933eb99f049b78d6163735e06f" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Custom Render Texture/Update", false, 85 )]
		public static void ApplyTemplateCustomRenderTextureUpdate()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "32120270d1b3a8746af2aca8bc749736" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/HD/Decal", false, 85 )]
		public static void ApplyTemplateHDDecal()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "d345501910c196f4a81c9eff8a0a5ad7" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/HD/Fabric", false, 85 )]
		public static void ApplyTemplateHDFabric()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "41e04be03f2c20941bc749271be1c937" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/HD/Hair", false, 85 )]
		public static void ApplyTemplateHDHair()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "e4fe21624ace6de4b9fbaabdda0c51de" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/HDRP/Lit", false, 85 )]
		public static void ApplyTemplateHDRPLit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "53b46d85872c5b24c8f4f0a1c3fe4c87" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/HDRP/Unlit", false, 85 )]
		public static void ApplyTemplateHDRPUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "7f5cb9c3ea6481f469fdd856555439ef" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Default Sprites", false, 85 )]
		public static void ApplyTemplateLegacyDefaultSprites()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "0f8ba0101102bb14ebf021ddadce9b49" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Image Effect", false, 85 )]
		public static void ApplyTemplateLegacyImageEffect()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "c71b220b631b6344493ea3cf87110c93" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Lit", false, 85 )]
		public static void ApplyTemplateLegacyLit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "ed95fe726fd7b4644bb42f4d1ddd2bcd" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Multi Pass Unlit", false, 85 )]
		public static void ApplyTemplateLegacyMultiPassUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "e1de45c0d41f68c41b2cc20c8b9c05ef" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Particles Alpha Blended", false, 85 )]
		public static void ApplyTemplateLegacyParticlesAlphaBlended()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "0b6a9f8b4f707c74ca64c0be8e590de0" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Post-Processing Stack", false, 85 )]
		public static void ApplyTemplateLegacyPostProcessingStack()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "32139be9c1eb75640a847f011acf3bcf" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Unlit", false, 85 )]
		public static void ApplyTemplateLegacyUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "0770190933193b94aaa3065e307002fa" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Legacy/Unlit Lightmap", false, 85 )]
		public static void ApplyTemplateLegacyUnlitLightmap()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "899e609c083c74c4ca567477c39edef0" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Templates/Legacy/DefaultUnlit", false, 85 )]
		public static void ApplyTemplateTemplatesLegacyDefaultUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "6e114a916ca3e4b4bb51972669d463bf" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Templates/UI-Default", false, 85 )]
		public static void ApplyTemplateTemplatesUIDefault()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "4b95d7618843e024194714b7b7fe1767" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/UI/Default", false, 85 )]
		public static void ApplyTemplateUIDefault()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "5056123faa0c79b47ab6ad7e8bf059a4" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/2D Custom Lit", false, 85 )]
		public static void ApplyTemplateUniversal2DCustomLit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "ece0159bad6633944bf6b818f4dd296c" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/2D Lit", false, 85 )]
		public static void ApplyTemplateUniversal2DLit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "199187dac283dbe4a8cb1ea611d70c58" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/2D Unlit", false, 85 )]
		public static void ApplyTemplateUniversal2DUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "cf964e524c8e69742b1d21fbe2ebcc4a" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/Decal", false, 85 )]
		public static void ApplyTemplateUniversalDecal()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "c2a467ab6d5391a4ea692226d82ffefd" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/Lit", false, 85 )]
		public static void ApplyTemplateUniversalLit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "94348b07e5e8bab40bd6c8a1e3df54cd" );
		}
		[MenuItem( "Assets/Create/Amplify Shader/Universal/Unlit", false, 85 )]
		public static void ApplyTemplateUniversalUnlit()
		{
			AmplifyShaderEditorWindow.CreateConfirmationTemplateShader( "2992e84f91cbeb14eab234972e07ea9d" );
		}
	}
}
