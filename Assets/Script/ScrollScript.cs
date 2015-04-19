using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {
    public UIScrollView scrollView;
    // Use this for initialization
    void Start()
    {
        scrollView = GameObject.Find("Scroll View").GetComponent<UIScrollView>(); 
        //draggablePanel.onDragFinished = new UIDraggablePanel.OnDragFinished(OnDragFinished);
    }

    void OnDestory()
    {
        //draggablePanel.onDragFinished -= OnDragFinished;
    }

	// Update is called once per frame
    void Update()
    {
        int Index = (int)scrollView.transform.localPosition.x;
        CommonFunc.s_iScrollIndex = Index/-119;
    }
}
