using UnityEngine;
using System.Collections;

public class DragEventScript : MonoBehaviour {
    static int dragType;
    static int s_iDragType;
    bool blDrag;
    // Use this for initialization
    void Start()
    {
        dragType = 0;
        s_iDragType = 0;
        blDrag = false;
    }

    void OnDestory()
    {
        //draggablePanel.onDragFinished -= OnDragFinished;
    }

	// Update is called once per frame
    void Update()
    {
   
    }

    void OnDrag(Vector2 delta)
    {
        if (!blDrag)
            blDrag = true;

        Debug.Log("x : " + delta.x + "y : " + delta.y);
        if (Mathf.Abs(delta.x) < Mathf.Abs(delta.y))
        {
            if (delta.y > 0)
            {
                dragType = 0;
                Debug.Log("세로+");
            }
            else
            {
                dragType = 2;
                Debug.Log("세로-");
            }
        }
        else
        {
            if (delta.x > 0)
            {
                dragType = 1;
                Debug.Log("가로+");
            }
            else
            {
                dragType = 3;
                Debug.Log("가로-");
            }
            
        }
    }
 
    void OnPress()
    {
        if (blDrag)
        {
            if (dragType == 0 || dragType == 2)
            {
                int iIndex;
                switch (CommonFunc.s_iScrollIndex)
                {
                    case (int)CommonFunc._FaceParts.FACE:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.FACE, 4);
                        CommonFunc.ChangeColor_Face(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.HAIR:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.HAIR, 4);
                        CommonFunc.ChangeColor_Hair(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EAR:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.EAR, 3);
                        CommonFunc.ChangeColor_Ear(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EYEBLOW:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.EYEBLOW, 3);
                        CommonFunc.ChangeColor_Eyeblow(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EYE:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.EYE, 3);
                        CommonFunc.ChangeColor_Eye(iIndex);
                        break;
                    case 5:
                    case 6:
                        break;
                    case (int)CommonFunc._FaceParts.FACE_ACC:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.FACE_ACC, 3);
                        CommonFunc.ChangeColor_FaceAcc(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.NECK:
                        iIndex = GetChangeColorIndex((int)CommonFunc._FaceParts.NECK, 3);
                        CommonFunc.ChangeColor_Neck(iIndex);
                        break;
                    case 10:
                    case 11:
                    case 12:
                        break;
                }
                UIPanel panel;
                panel = GameObject.Find("Panel_Game").GetComponent<UIPanel>();
                panel.Refresh();
            }
            else //if (dragType == 1)
            {
                int iIndex;
                switch (CommonFunc.s_iScrollIndex)
                {
                    case (int)CommonFunc._FaceParts.FACE:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.FACE, 3);
                        CommonFunc.ChangeFaceParts_Face(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.HAIR:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.HAIR, 3);
                        CommonFunc.ChangeFaceParts_Hair(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EAR:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.EAR, 3);
                        CommonFunc.ChangeFaceParts_Ear(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EYEBLOW:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.EYEBLOW, 3);
                        CommonFunc.ChangeFaceParts_Eyeblow(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EYE:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.EYE, 3);
                        CommonFunc.ChangeFaceParts_Eye(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.NOSE:
                        Debug.Log("nose");
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.NOSE, 3);
                        CommonFunc.ChangeFaceParts_Nose(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.MOUTH:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.MOUTH, 3);
                        CommonFunc.ChangeFaceParts_Mouth(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.HAIR_ACC:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.HAIR_ACC, 3);
                        CommonFunc.ChangeFaceParts_HairAcc(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.FACE_ACC:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.FACE_ACC, 3);
                        CommonFunc.ChangeFaceParts_FaceAcc(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.NECK:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.NECK, 3);
                        CommonFunc.ChangeFaceParts_Neck(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.EMOTION:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.EMOTION, 3);
                        //CommonFunc.ChangeFaceParts_Eye(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.TALK:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.TALK, 3);
                        //CommonFunc.ChangeFaceParts_Eye(iIndex);
                        break;
                    case (int)CommonFunc._FaceParts.BG:
                        iIndex = GetChangePartsIndex((int)CommonFunc._FaceParts.BG, 3);
                        //CommonFunc.ChangeFaceParts_Eye(iIndex);
                        break;
                }
            }
            blDrag = false;
        }
        else
        {
            Debug.Log("터치 누름");
        }
    }
    int GetChangeColorIndex(int iPartsIndex, int iMaxColor)
    {
        int iIndex;

        if (dragType == 0)
            iIndex = ++(CommonFunc.s_iColorIndex[iPartsIndex]) % iMaxColor;
        else
        {
            iIndex = --(CommonFunc.s_iColorIndex[iPartsIndex]) % iMaxColor;
            if (iIndex < 0)
            {
                CommonFunc.s_iColorIndex[iPartsIndex] = iMaxColor - 1;
                iIndex = CommonFunc.s_iColorIndex[iPartsIndex];
            }
        }

        return iIndex;
    }
    int GetChangePartsIndex(int iPartsIndex, int iMaxParts)
    {
        int iIndex;

        if (dragType == 1)
            iIndex = ++(CommonFunc.s_iPartsIndex[iPartsIndex]) % iMaxParts;
        else
        {
            iIndex = --(CommonFunc.s_iPartsIndex[iPartsIndex]) % iMaxParts;
            if (iIndex < 0)
            {
                CommonFunc.s_iPartsIndex[iPartsIndex] = iMaxParts - 1;
                iIndex = CommonFunc.s_iPartsIndex[iPartsIndex];
            }
        }

        return iIndex;
    }
}
