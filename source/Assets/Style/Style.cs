using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[ExecuteInEditMode]
public class Style : MonoBehaviour {
    
    public StyleGraph style;
    
    private void Update()
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            if (style == null) return;

            style.Apply(gameObject);
        }
#endif
    }
}
