using UnityEngine;
using System.Collections;

public class GUIMgr : MonoBehaviour
 {
     public void OnClick()
     {
        Debug.Log ("Clicked Random Face Button");

        int iRandom = 0;

        //Ear
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EAR] = iRandom;
        CommonFunc.ChangeFaceParts_Ear(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EAR]);
        
        //Eye
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EYE] = iRandom;
        CommonFunc.ChangeFaceParts_Eye(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EYE]);

        //Eyeblow
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EYEBLOW] = iRandom;
        CommonFunc.ChangeFaceParts_Eyeblow(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.EYEBLOW]);

        //face
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.FACE] = iRandom;
        CommonFunc.ChangeFaceParts_Face(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.FACE]);

        //face_acc
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.FACE_ACC] = iRandom;
        CommonFunc.ChangeFaceParts_FaceAcc(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.FACE_ACC]);

        //hair
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.HAIR] = iRandom;
        CommonFunc.ChangeFaceParts_Hair(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.HAIR]);

        //hair_acc
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.HAIR_ACC] = iRandom;
        CommonFunc.ChangeFaceParts_HairAcc(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.HAIR_ACC]);

        //mouth
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.MOUTH] = iRandom;
        CommonFunc.ChangeFaceParts_Mouth(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.MOUTH]);

        //neck
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.NECK] = iRandom;
        CommonFunc.ChangeFaceParts_Neck(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.NECK]);

        //nose
        iRandom = Random.Range(0, 3);
        CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.NOSE] = iRandom;
        CommonFunc.ChangeFaceParts_Nose(CommonFunc.s_iPartsIndex[(int)CommonFunc._FaceParts.NOSE]);
     }
 }