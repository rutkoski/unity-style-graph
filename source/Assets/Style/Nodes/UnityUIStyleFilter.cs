using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[CreateNodeMenu("Style/Filter/Unity UI")]
public class UnityUIStyleFilter : StyleFilter
{
    public enum Type
    {
        Text,
        InputField
    }

    public Type type;

    public override void Apply(GameObject obj)
    {
        base.Apply(obj);

        if (obj == null) return;

        switch (type)
        {
            case Type.InputField: CheckComponent<InputField>(obj); break;
            case Type.Text: CheckComponent<Text>(obj); break;
        }
    }

    private void CheckComponent<T>(GameObject obj)
    {
        T component = obj.GetComponent<T>();

        if (component == null) return;

        Forward(obj);
    }
}
