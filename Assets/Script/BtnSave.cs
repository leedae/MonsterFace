using UnityEngine;
using System.Collections;

public class BtnSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick()
    {
        Debug.Log("Clicked BtnSave");
        //CommonFunc.Capture();
        StartCoroutine(CommonFunc.saveRenderTexture());
    }
}
