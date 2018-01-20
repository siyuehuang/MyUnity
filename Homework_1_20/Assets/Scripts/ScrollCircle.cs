using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollCircle : ScrollRect {

    protected float mRadius = 0f;
    protected float mWidth;
	// Use this for initialization
	protected override void Start () {
        base.Start();
        mWidth = transform.GetComponentInParent<Canvas>().pixelRect.width;
        //mRadius = (transform as RectTransform).anchorMax.x;
        //mRadius = (transform as RectTransform).sizeDelta.x * 0.5f - 25;
        //content.anchorMax.x 相对于父物体的
        mRadius = ((transform as RectTransform).anchorMax.x - (transform as RectTransform).anchorMin.x) * mWidth * 0.5f - (content.anchorMax.x-content.anchorMin.x) * mWidth * 0.5f;
        //print(content.anchorMax.x);
        //print(mRadius);
        //print(gameObject.transform.parent.name);
        //Canvas

    }

    // Update is called once per frame
    void Update()
    {
        mWidth = transform.GetComponentInParent<Canvas>().pixelRect.width;
        mRadius = ((transform as RectTransform).anchorMax.x - (transform as RectTransform).anchorMin.x) * mWidth * 0.5f - (content.anchorMax.x - content.anchorMin.x) * mWidth * 0.5f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        var contentPosition = this.content.anchoredPosition;
        //print(contentPosition);
        if (contentPosition.magnitude > mRadius)
        {
            //print(contentPosition.magnitude);
            contentPosition = contentPosition.normalized * (mRadius);
            SetContentAnchoredPosition(contentPosition);
        }
    }
}
