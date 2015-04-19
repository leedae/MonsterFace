using UnityEngine;
using System.Collections;

public class BtnRight : MonoBehaviour {

    private static GameObject goRight;
    // Use this for initialization
    void Start()
    {
        goRight = GameObject.Find("Anchor_Center/Panel_SelectedBox/ImgBntRight");
    }

    // Update is called once per frame
    void Update()
    {
        if (CommonFunc.s_iScrollIndex == 12)
            goRight.SetActive(false);
        else
            goRight.SetActive(true);
    }
    public void OnClick()
    {
        Debug.Log("Clicked BtnRight");
        if (CommonFunc.s_iScrollIndex < 13)
            CommonFunc.s_iScrollIndex++;
    }
}
