using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[CreateNodeMenu("Style/Filter/Abstract Filter")]
[NodeTint("#ffaaaa")]
public class StyleFilter : StyleNode
{
    [Output]
    public StyleNode target;
}
