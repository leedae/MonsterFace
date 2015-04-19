using UnityEngine;
using System.Collections;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Click")]
public class BtnLeft : MonoBehaviour {

    public static UICenterOnChild mCenter;
    public static UIScrollView scrollView;
	// Use this for initialization
	void Start () {
        scrollView = GameObject.Find("Scroll View").GetComponent<UIScrollView>();
        mCenter = NGUITools.FindInParents<UICenterOnChild>(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void OnClick()
    {
        float Index = scrollView.transform.localPosition.x;
        Index += (float)120;

        Debug.Log("CommonFunc.s_iScrollIndex" + CommonFunc.s_iScrollIndex);
        if (CommonFunc.s_iScrollIndex > 0)
        {
            Debug.Log("index" + Index);
            Vector3 vc = new Vector3(Index, 0, 0);
            scrollView.transform.localPosition = vc;
            Debug.Log("index" + scrollView.transform.localPosition.x);
        }
    }
}
