using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

[CustomNodeEditor(typeof(RectTransformNode))]
public class RectTransformNodeEditor : NodeEditor
{
    
    public override void OnBodyGUI()
    {
        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("origin"));

        SerializedProperty xOrLeftProp = serializedObject.FindProperty("xOrLeft");
        SerializedProperty yOrTopProp = serializedObject.FindProperty("yOrTop");
        SerializedProperty widthOrRightProp = serializedObject.FindProperty("widthOrRight");
        SerializedProperty heightOrBottomProp = serializedObject.FindProperty("heightOrBottom");
        SerializedProperty anchorMinProp = serializedObject.FindProperty("anchorMin");
        SerializedProperty anchorMaxProp = serializedObject.FindProperty("anchorMax");
        SerializedProperty pivotProp = serializedObject.FindProperty("pivot");
        
        NodeEditorGUILayout.PropertyField(xOrLeftProp, new GUIContent(anchorMinProp.vector2Value.x == anchorMaxProp.vector2Value.x ? "Pos X" : "Left"));
        NodeEditorGUILayout.PropertyField(yOrTopProp, new GUIContent(anchorMinProp.vector2Value.y == anchorMaxProp.vector2Value.y ? "Pos Y" : "Top"));
        NodeEditorGUILayout.PropertyField(widthOrRightProp, new GUIContent(anchorMinProp.vector2Value.x == anchorMaxProp.vector2Value.x ? "Width" : "Right"));
        NodeEditorGUILayout.PropertyField(heightOrBottomProp, new GUIContent(anchorMinProp.vector2Value.y == anchorMaxProp.vector2Value.y ? "Height" : "Bottom"));
        NodeEditorGUILayout.PropertyField(anchorMinProp);
        NodeEditorGUILayout.PropertyField(anchorMaxProp);
        NodeEditorGUILayout.PropertyField(pivotProp, new GUIContent("Pivot (raw)"));
    }
}
