//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2014 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;

/// <summary>
/// Attaching this script to an element of a scroll view will make it possible to center on it by clicking on it.
/// </summary>

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Click")]
public class UICenterOnClick : MonoBehaviour
{
	//UIPanel mPanel;
	UICenterOnChild mCenter;

	void Start ()
	{
		mCenter = NGUITools.FindInParents<UICenterOnChild>(gameObject);
		//mPanel = NGUITools.FindInParents<UIPanel>(gameObject);
	}

	void OnClick ()
	{
        if (mCenter != null)
        {
            //if (mCenter.enabled)
		    mCenter.CenterOn(transform);

            Camera curCamera;
            curCamera = GameObject.Find("Camera").GetComponent<Camera>(); 

            Ray ray = curCamera.camera.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButtonUp(0))
            {
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    string name = hit.collider.gameObject.name;
                    CommonFunc.s_iScrollIndex = int.Parse(name);
                    Debug.Log(name);
                }
            } 
        }
        //if (mPanel != null && mPanel.clipping != UIDrawCall.Clipping.None)
        //{
        //    SpringPanel.Begin(mPanel.cachedGameObject, mPanel.cachedTransform.InverseTransformPoint(transform.position), 6f);
        //    Debug.Log("111?");
        //}
	}
}
