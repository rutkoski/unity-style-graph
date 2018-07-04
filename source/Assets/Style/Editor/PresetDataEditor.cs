/*using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(PresetData.Property_Int))]
[CustomPropertyDrawer(typeof(PresetData.Property_Float))]
[CustomPropertyDrawer(typeof(PresetData.Property_Font))]
[CustomPropertyDrawer(typeof(PresetData.Property_Rect))]
[CustomPropertyDrawer(typeof(PresetData.Property_Sprite))]
[CustomPropertyDrawer(typeof(PresetData.Property_TextAnchor))]
public class PresetDataPropDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty title = property.FindPropertyRelative("title");
        SerializedProperty propertyValue = property.FindPropertyRelative("propertyValue");
        
        EditorGUI.PropertyField(position, propertyValue, new GUIContent(title.stringValue));
    }
}
*/