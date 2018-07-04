using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateNodeMenu("Style/Filter/Find Transform Filter")]
public class FindFilter : StyleFilter
{

    public string path;

    public override void Apply(GameObject obj)
    {
        base.Apply(obj);

        if (obj == null) return;

        if (string.IsNullOrEmpty(path)) return;

        Transform t = obj.transform.Find(path);

        if (t == null) return;

        Forward(t.gameObject);
    }
}
