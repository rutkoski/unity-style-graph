using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class StyleGraph : NodeGraph
{
    public void Apply(GameObject obj)
    {
        nodes.ForEach(node =>
        {
            StyleNode styleNode = node as StyleNode;

            if (styleNode == null) return;

            if (styleNode.GetPort("origin").ConnectionCount > 0) return;

            styleNode.Apply(obj);
        });
    }
}
