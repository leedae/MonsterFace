using UnityEngine;
using System.Collections;

public class BtnRandomColor : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Clicked Random Color Button");

        int iRandom = 0;
        
        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EAR] = iRandom;
        CommonFunc.ChangeColor_Ear(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EAR]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EYE] = iRandom;
        CommonFunc.ChangeColor_Eye(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EYE]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EYEBLOW] = iRandom;
        CommonFunc.ChangeColor_Eyeblow(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.EYEBLOW]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.FACE] = iRandom;
        CommonFunc.ChangeColor_Face(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.FACE]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.FACE_ACC] = iRandom;
        CommonFunc.ChangeColor_FaceAcc(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.FACE_ACC]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.HAIR] = iRandom;
        CommonFunc.ChangeColor_Hair(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.HAIR]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.HAIR_ACC] = iRandom;
        CommonFunc.ChangeColor_HairAcc(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.HAIR_ACC]);

        iRandom = Random.Range(0, 4);
        CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.NECK] = iRandom;
        CommonFunc.ChangeColor_Neck(CommonFunc.s_iColorIndex[(int)CommonFunc._FaceParts.NECK]);

        //mouth
        /*
        iRandomR = Random.Range(0, 256);
        iRandomG = Random.Range(0, 256);
        iRandomB = Random.Range(0, 256);
        Material MaterialMouth = Resources.Load("Atlas/mouth/mouthAtlas", typeof(Material)) as Material;
        MaterialMouth.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
        */
        //neck
        //iRandomR = CommonFunc.colorArray_neck[Random.Range(0, 4), 0];
        //iRandomG = CommonFunc.colorArray_neck[Random.Range(0, 4), 1];
        //iRandomB = CommonFunc.colorArray_neck[Random.Range(0, 4), 2];
        //Material MaterialNeck = Resources.Load("Atlas/neck/neckAtlas", typeof(Material)) as Material;
        //MaterialNeck.SetColor("_Color", CommonFunc.ConvertColor(iRandomR, iRandomG, iRandomB));

        //iRandomR = Random.Range(0, 256);
        //iRandomG = Random.Range(0, 256);
        //iRandomB = Random.Range(0, 256);
        //Material MaterialNeckMask = Resources.Load("Atlas/neck/neckMaskAtlas", typeof(Material)) as Material;
        //MaterialNeckMask.SetColor("_Color", CommonFunc.ConvertColor(iRandomR, iRandomG, iRandomB));

        //nose
        /*
        iRandomR = Random.Range(0, 256);
        iRandomG = Random.Range(0, 256);
        iRandomB = Random.Range(0, 256);
        Material MaterialNose = Resources.Load("Atlas/nose/noseAtlas", typeof(Material)) as Material;
        MaterialNose.SetColor("_Color", ConvertColor(iRandomR, iRandomG, iRandomB));
        */

        UIPanel panel;
        panel = GameObject.Find("Panel_Game").GetComponent<UIPanel>();
        panel.Refresh();
    }
}
