using UnityEngine;
using System.Collections;
using System.IO;

public class CommonFunc : MonoBehaviour
{
    public static int[] s_iPartsIndex = new int[13];
    public static int[] s_iColorIndex = new int[13];
    public static int s_iScrollIndex;
    public enum _FaceParts
    {
        FACE = 0,
        HAIR,
        EAR,
        EYEBLOW,
        EYE,
        NOSE,
        MOUTH,
        HAIR_ACC,
        FACE_ACC,
        NECK,
        EMOTION,
        TALK,
        BG,
        PACEPARTS_MAX
    };
    public static int[,] colorArray_ear = new int[,]{
                                        { 46, 30, 36 },
                                        { 202, 172, 99 },
                                        { 209, 200, 229 },
                                        { 227, 181, 166 },
                                      };
    public static int[,] colorArray_eyeblow = new int[,]{
                                        { 240, 235, 231 },
                                        { 135, 184, 212 },
                                        { 159, 151, 147 },
                                        { 189, 208, 247 },
                                      };
    public static int[,] colorArray_face = new int[,]{
                                        { 254, 71, 85 },
                                        { 245, 211, 63 },
                                        { 247, 237, 233 },
                                        { 228, 118, 171 },
                                      };
    public static int[,] colorArray_hair = new int[,]{
                                        { 240, 235, 231 },
                                        { 135, 184, 212 },
                                        { 159, 151, 147 },
                                        { 189, 208, 247 },
                                      };
    public static int[,] colorArray_eye = new int[,]{
                                        { 35, 187, 115 },
                                        { 185, 32, 44 },
                                        { 85, 65, 88 },
                                        { 85, 218, 160 },
                                      };
    public static int[,] colorArray_neck = new int[,]{
                                        { 125, 64, 122 },
                                        { 32, 116, 111 },
                                        { 94, 74, 100 },
                                        { 76, 95, 178 },
                                      };
    public static int[,] colorArray_hair_acc = new int[,]{
                                        { 226, 200, 97 },
                                        { 61, 36, 30 },
                                        { 225, 237, 255 },
                                        { 52, 30, 33 },
                                      };
    public static int[,] colorArray_face_acc = new int[,]{
                                        { 49, 163, 216 },
                                        { 96, 208, 90 },
                                        { 216, 11, 32 },
                                        { 212, 238, 33 },
                                      };
    public static int[,] colorArray_bg = new int[,]{
                                        { 123, 84, 144 },
                                        { 158, 159, 115 },
                                        { 87, 160, 175 },
                                        { 200, 155, 157 },
                                      };

    private static GameObject goLeftArrow;
	// Use this for initialization
	void Start () {
        Debug.Log("1212121212");
        Screen.SetResolution(Screen.width, Screen.width / 2 * 3, true);
        goLeftArrow = GameObject.Find("Anchor_Center/Panel_SelectedBox/ImgBntLeft");
	}
	
	// Update is called once per frame
	void Update () {
        if (CommonFunc.s_iScrollIndex == 0)
            goLeftArrow.SetActive(false);
        else
        {

            goLeftArrow.SetActive(true);
        }
	}

    public static void ChangeFaceParts_Ear(int iIndex)
    {
        string strImageName;
        //Ear
        UISprite SpriteEar = GameObject.Find("Sprite_ear").GetComponent<UISprite>();
        SpriteEar.atlas = Resources.Load("Atlas/ear/earAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("ear{0:D2}", iIndex+1);
        SpriteEar.spriteName = strImageName;
        SpriteEar.MakePixelPerfect();

        UISprite SpriteEarMask = GameObject.Find("Sprite_ear_mask").GetComponent<UISprite>();
        SpriteEarMask.atlas = Resources.Load("Atlas/ear/earMaskAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("ear{0:D2}_a", iIndex + 1);
        SpriteEarMask.spriteName = strImageName;
        SpriteEarMask.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Eye(int iIndex)
    {
        string strImageName;

        Debug.Log("Change Eye " + iIndex + 1);
        //Eye
        UISprite SpriteEye = GameObject.Find("Sprite_eye").GetComponent<UISprite>();
        SpriteEye.atlas = Resources.Load("Atlas/eye/eyeAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("eye{0:D2}", iIndex + 1);
        SpriteEye.spriteName = strImageName;
        SpriteEye.MakePixelPerfect();

        UISprite SpriteEyeMask = GameObject.Find("Sprite_eye_mask").GetComponent<UISprite>();
        SpriteEyeMask.atlas = Resources.Load("Atlas/eye/eyeMaskAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("eye{0:D2}_a", iIndex + 1);
        SpriteEyeMask.spriteName = strImageName;
        SpriteEyeMask.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Eyeblow(int iIndex)
    {
        string strImageName;

        //Eyeblow
        UISprite SpritEyeblow = GameObject.Find("Sprite_eyeblow").GetComponent<UISprite>();
        SpritEyeblow.atlas = Resources.Load("Atlas/eyeblow/eyeblowAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("eyeblow{0:D2}", iIndex + 1);
        SpritEyeblow.spriteName = strImageName;
        SpritEyeblow.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Face(int iIndex)
    {
        string strImageName;

        //face
        UISprite Spriteface = GameObject.Find("Sprite_face").GetComponent<UISprite>();
        Spriteface.atlas = Resources.Load("Atlas/face/faceAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("face{0:D2}", iIndex + 1);
        Spriteface.spriteName = strImageName;
        Spriteface.MakePixelPerfect();
    }
    public static void ChangeFaceParts_FaceAcc(int iIndex)
    {
        string strImageName;

        //face_acc
        UISprite SpriteFaceAcc = GameObject.Find("Sprite_face_acc").GetComponent<UISprite>();
        SpriteFaceAcc.atlas = Resources.Load("Atlas/face_acc/faceAccAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("face_acc{0:D2}", iIndex + 1);
        SpriteFaceAcc.spriteName = strImageName;
        SpriteFaceAcc.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Hair(int iIndex)
    {
        string strImageName;

        //hair
        UISprite SpriteHair = GameObject.Find("Sprite_hair").GetComponent<UISprite>();
        SpriteHair.atlas = Resources.Load("Atlas/hair/hairAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("hair{0:D2}", iIndex + 1);
        SpriteHair.spriteName = strImageName;
        SpriteHair.MakePixelPerfect();
    }
    public static void ChangeFaceParts_HairAcc(int iIndex)
    {
        string strImageName;

        //hair_acc
        UISprite SpriteHairAcc = GameObject.Find("Sprite_hair_acc").GetComponent<UISprite>();
        SpriteHairAcc.atlas = Resources.Load("Atlas/hair_acc/hairAccAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("hair_acc{0:D2}", iIndex + 1);
        SpriteHairAcc.spriteName = strImageName;
        SpriteHairAcc.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Mouth(int iIndex)
    {
        string strImageName;

        //mouth
        UISprite SpriteMouth = GameObject.Find("Sprite_mouth").GetComponent<UISprite>();
        SpriteMouth.atlas = Resources.Load("Atlas/mouth/mouthAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("mouth{0:D2}", iIndex + 1);
        SpriteMouth.spriteName = strImageName;
        SpriteMouth.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Neck(int iIndex)
    {
        string strImageName;

        //neck
        UISprite SpriteNeck = GameObject.Find("Sprite_neck").GetComponent<UISprite>();
        SpriteNeck.atlas = Resources.Load("Atlas/neck/neckAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("neck{0:D2}", iIndex + 1);
        SpriteNeck.spriteName = strImageName;
        SpriteNeck.MakePixelPerfect();

        UISprite SpriteNeckMask = GameObject.Find("Sprite_neck_mask").GetComponent<UISprite>();
        SpriteNeckMask.atlas = Resources.Load("Atlas/neck/neckMaskAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("neck{0:D2}_a", iIndex + 1);
        SpriteNeckMask.spriteName = strImageName;
        SpriteNeckMask.MakePixelPerfect();
    }
    public static void ChangeFaceParts_Nose(int iIndex)
    {
        string strImageName;

        //nose
        UISprite SpriteNose = GameObject.Find("Sprite_nose").GetComponent<UISprite>();
        SpriteNose.atlas = Resources.Load("Atlas/nose/noseAtlas", typeof(UIAtlas)) as UIAtlas;
        strImageName = string.Format("nose{0:D2}", iIndex + 1);
        SpriteNose.spriteName = strImageName;
        SpriteNose.MakePixelPerfect();
    }

    public static void ChangeColor_Ear(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //ear
        iRandomR = colorArray_ear[iIndex, 0];
        iRandomG = colorArray_ear[iIndex, 1];
        iRandomB = colorArray_ear[iIndex, 2];
        Material MaterialEar = Resources.Load("Atlas/ear/earAtlas", typeof(Material)) as Material;
        MaterialEar.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }

    public static void ChangeColor_Eye(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        iRandomR = colorArray_eye[iIndex, 0];
        iRandomG = colorArray_eye[iIndex, 1];
        iRandomB = colorArray_eye[iIndex, 2];
        Material MaterialEyeMask = Resources.Load("Atlas/eye/eyeMaskAtlas", typeof(Material)) as Material;
        MaterialEyeMask.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }

    public static void ChangeColor_Eyeblow(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //eyeblow
        iRandomR = colorArray_eyeblow[iIndex, 0];
        iRandomG = colorArray_eyeblow[iIndex, 1];
        iRandomB = colorArray_eyeblow[iIndex, 2];
        Material MaterialEyeblow = Resources.Load("Atlas/eyeblow/eyeblowAtlas", typeof(Material)) as Material;
        MaterialEyeblow.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }

    public static void ChangeColor_Face(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //face
        iRandomR = colorArray_face[iIndex, 0];
        iRandomG = colorArray_face[iIndex, 1];
        iRandomB = colorArray_face[iIndex, 2];
        Material MaterialFace = Resources.Load("Atlas/face/faceAtlas", typeof(Material)) as Material;
        MaterialFace.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }

    public static void ChangeColor_FaceAcc(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //face_acc
        iRandomR = colorArray_face_acc[iIndex, 0];
        iRandomG = colorArray_face_acc[iIndex, 1];
        iRandomB = colorArray_face_acc[iIndex, 2];
        Material MaterialFaceAcc = Resources.Load("Atlas/face_acc/faceAccAtlas", typeof(Material)) as Material;
        MaterialFaceAcc.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }
    public static void ChangeColor_Hair(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //hair
        iRandomR = colorArray_hair[iIndex, 0];
        iRandomG = colorArray_hair[iIndex, 1];
        iRandomB = colorArray_hair[iIndex, 2];
        Material MaterialHair = Resources.Load("Atlas/hair/hairAtlas", typeof(Material)) as Material;
        MaterialHair.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }
    public static void ChangeColor_HairAcc(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //hair_acc
        iRandomR = colorArray_hair_acc[iIndex, 0];
        iRandomG = colorArray_hair_acc[iIndex, 1];
        iRandomB = colorArray_hair_acc[iIndex, 2];
        Material MaterialHairAcc = Resources.Load("Atlas/hair_acc/hairAccAtlas", typeof(Material)) as Material;
        MaterialHairAcc.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }
    public static void ChangeColor_Neck(int iIndex)
    {
        int iRandomR = 0;
        int iRandomG = 0;
        int iRandomB = 0;

        //neck
        iRandomR = colorArray_neck[iIndex, 0];
        iRandomG = colorArray_neck[iIndex, 1];
        iRandomB = colorArray_neck[iIndex, 2];
        Material MaterialNeck = Resources.Load("Atlas/neck/neckAtlas", typeof(Material)) as Material;
        MaterialNeck.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));

        iRandomR = Random.Range(0, 256);
        iRandomG = Random.Range(0, 256);
        iRandomB = Random.Range(0, 256);
        Material MaterialNeckMask = Resources.Load("Atlas/neck/neckMaskAtlas", typeof(Material)) as Material;
        MaterialNeckMask.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
    }

    public static Color ConvertColor(int r, int g, int b)
    {
        Color color = new Color(r / 255.0F, g / 255.0F, b / 255.0F, 255 / 255.0F);

        return color;
    }

    public static void Capture()
    {
        if (Application.isEditor == true)
            Application.CaptureScreenshot("screenshot" + 1 + ".png");
        else
            Application.CaptureScreenshot("..\\screenshot" + 1 + ".png");
    }


    public static IEnumerator saveRenderTexture()
    {
        CommonFunc.AllHideUI();
        // We should only read the screen after all rendering is complete
        yield return new WaitForEndOfFrame();
        // Create a texture the size of the screen, RGB24 format
        int width = Screen.width;
        int height = Screen.width;
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        // Read screen contents into the texture
        tex.ReadPixels(new Rect(0, 70, width, height), 0, 0);
        tex.Apply();
        
        // Encode texture into PNG
        byte[] bytes = tex.EncodeToPNG();
        Destroy(tex);
        yield return 0;

        File.WriteAllBytes("capture.png", bytes);

        CommonFunc.AllViewUI();
    }
    private static GameObject goCenter;
    private static GameObject goLeft;
    private static GameObject goRight;
    private static GameObject goTopLeft;

    public static void AllHideUI()
    {
        goCenter = GameObject.Find("Anchor_Center");
        goCenter.SetActive(false);
        goLeft = GameObject.Find("Anchor_Left");
        goLeft.SetActive(false);
        goRight = GameObject.Find("Anchor_Right");
        goRight.SetActive(false);
        goTopLeft = GameObject.Find("Anchor_TopLeft");
        goTopLeft.SetActive(false);
        //GameObject goTopRight = GameObject.Find("Anchor_TopRight");
        //goTopRight.SetActive(false);
    }

    public static void AllViewUI()
    {
        goCenter.SetActive(true);
        goLeft.SetActive(true);
        goRight.SetActive(true);
        goTopLeft.SetActive(true);
        //GameObject goTopRight = GameObject.Find("Anchor_TopRight");
        //goTopRight.SetActive(true);
    }
}
