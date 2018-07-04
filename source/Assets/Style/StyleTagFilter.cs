using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateNodeMenu("Style/Filter/Style Tag")]
public class StyleTagFilter : StyleFilter
{

    public string tag;

    public override void Apply(GameObject obj)
    {
        base.Apply(obj);

        if (obj == null) return;

        StyleTags tags = obj.GetComponent<StyleTags>();

        if (tags == null) return;

        if (tags.tags == null || !tags.tags.Contains(tag)) return;

        Forward(obj);
    }
}
