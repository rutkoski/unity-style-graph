using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using XNode;

[CreateNodeMenu("Style/Component/Text")]
public class TextStyleNode : StyleNode
{

    [Input] public int fontSize;
    [Input] public Font font;
    [Input] public Color color;

    [Output] public int _fontSize;
    [Output] public Font _font;
    [Output] public Color _color;
    
    public override object GetValue(NodePort port)
    {
        switch (port.fieldName)
        {
            case "_fontFamily": return GetInputValue("font", font);
            case "_fontSize": return GetInputValue("fontSize", fontSize);
            case "_color": return GetInputValue("color", color);
        }

        return base.GetValue(port);
    }

    public override void Apply(GameObject obj)
    {
        base.Apply(obj);

        if (obj == null) return;

        Text text = obj.GetComponent<Text>();

        if (text == null) return;

        if (GetValue(GetPort("_font")) != null)
        {
            text.font = (Font)GetValue(GetPort("_font"));
        }

        text.fontSize = (int)GetValue(GetPort("_fontSize"));
        text.color = (Color)GetValue(GetPort("_color"));
    }
}
