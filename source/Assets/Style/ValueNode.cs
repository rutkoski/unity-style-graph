using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNode;

[NodeTint("#aaffaa")]
public abstract class ValueNode<T> : Node
{
    [Input]
    public T value;

    [Output]
    public T _value;

    public override object GetValue(NodePort port)
    {
        return GetInputValue<T>("value", value);
    }
}
