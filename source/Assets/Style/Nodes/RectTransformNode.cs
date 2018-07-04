using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateNodeMenu("Style/Component/Rect Transform")]
public class RectTransformNode : StyleNode
{

    [Input] public float xOrLeft = 0;
    [Input] public float widthOrRight = 0;
    [Input] public float yOrTop = 100;
    [Input] public float heightOrBottom = 100;
    [Input] public Vector2 anchorMin = new Vector2(0.5f, 0.5f);
    [Input] public Vector2 anchorMax = new Vector2(0.5f, 0.5f);
    [Input] public Vector2 pivot = new Vector2(0.5f, 0.5f);

    public override void Apply(GameObject obj)
    {
        base.Apply(obj);

        if (obj == null) return;

        RectTransform r = obj.GetComponent<RectTransform>();

        if (r == null) return;

        r.anchorMin = anchorMin;
        r.anchorMax = anchorMax;
        r.pivot = pivot;
        
        if (anchorMin.x == anchorMax.x)
        {
            r.anchoredPosition = new Vector2(xOrLeft, r.anchoredPosition.y);
            r.sizeDelta = new Vector2(widthOrRight, r.sizeDelta.y);
        }
        else
        {
            r.offsetMin = new Vector2(xOrLeft, r.offsetMin.y);
            r.offsetMax = new Vector2(- widthOrRight, r.offsetMax.y);
        }

        if (anchorMin.y == anchorMax.y)
        {
            r.anchoredPosition = new Vector2(r.anchoredPosition.x, yOrTop);
            r.sizeDelta = new Vector2(r.sizeDelta.x, heightOrBottom);
        }
        else
        {
            r.offsetMax = new Vector2(r.offsetMax.x, -yOrTop);
            r.offsetMin = new Vector2(r.offsetMin.x, heightOrBottom);
        }
    }
}
