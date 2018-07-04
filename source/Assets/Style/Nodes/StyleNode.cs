using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using XNode;

public abstract class StyleNode : Node
{

    [Input(ShowBackingValue.Never)]
    public StyleNode origin;

    public override object GetValue(NodePort port)
    {
        if (port.fieldName == "origin")
        {
            return GetInputValue<StyleNode>("origin");
        }

        return null;// base.GetValue(port);
    }

    public virtual void Apply(GameObject obj)
    {
    }

    protected void Forward(GameObject obj)
    {
        NodePort target = GetOutputPort("target");

        int c = target.ConnectionCount;
        for (int i = 0; i < c; i++)
        {
            NodePort port = target.GetConnection(i);

            if (port == null) continue;

            StyleNode styleNode = port.node as StyleNode;

            if (styleNode == null) continue;

            styleNode.Apply(obj);
        }
    }
}
