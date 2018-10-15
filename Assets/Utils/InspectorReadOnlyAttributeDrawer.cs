//InspectorReadOnlyAttributeDrawer by SVerde
//contact@sverdegd.com
//https://github.com/sverdegd

using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(InspectorReadOnlyAttribute))]
public class InspectorReadOnlyAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        position.height = 16;
        InspectorReadOnlyAttribute inspectorReadOnly = attribute as InspectorReadOnlyAttribute;

        if (inspectorReadOnly.labelOverride != string.Empty)
            label.text = inspectorReadOnly.labelOverride;

        switch (property.propertyType)
        {
            case SerializedPropertyType.Vector3:
                EditorGUI.LabelField(position, label, new GUIContent(property.vector3Value.ToString()));
                break;
            case SerializedPropertyType.Vector3Int:
                EditorGUI.LabelField(position, label, new GUIContent(property.vector3IntValue.ToString()));
                break;
            case SerializedPropertyType.Vector2:
                EditorGUI.LabelField(position, label, new GUIContent(property.vector2Value.ToString()));
                break;
            case SerializedPropertyType.Vector2Int:
                EditorGUI.LabelField(position, label, new GUIContent(property.vector2IntValue.ToString()));
                break;
            case SerializedPropertyType.Float:
                EditorGUI.LabelField(position, label, new GUIContent(property.floatValue.ToString()));
                break;
            case SerializedPropertyType.Integer:
                EditorGUI.LabelField(position, label, new GUIContent(property.intValue.ToString()));
                break;
            case SerializedPropertyType.Quaternion:
                EditorGUI.LabelField(position, label, new GUIContent(property.quaternionValue.ToString()));
                break;
            case SerializedPropertyType.String:
                EditorGUI.LabelField(position, label, new GUIContent(property.stringValue));
                break;
            case SerializedPropertyType.Vector4:
                EditorGUI.LabelField(position, label, new GUIContent(property.vector4Value.ToString()));
                break;
            case SerializedPropertyType.Boolean:
                EditorGUI.LabelField(position, label, new GUIContent(property.boolValue.ToString()));
                break;
            case SerializedPropertyType.Color:
                EditorGUI.LabelField(position, label, new GUIContent(property.colorValue.ToString()));
                break;
            case SerializedPropertyType.Enum:
                EditorGUI.LabelField(position, label, new GUIContent(property.enumDisplayNames[property.enumValueIndex].ToString()));
                break;
            case SerializedPropertyType.Rect:
                EditorGUI.LabelField(position, label, new GUIContent(property.rectValue.ToString()));
                break;
            case SerializedPropertyType.RectInt:
                EditorGUI.LabelField(position, label, new GUIContent(property.rectIntValue.ToString()));
                break;
            case SerializedPropertyType.Bounds:
                EditorGUI.LabelField(position, label, new GUIContent(property.boundsValue.ToString()));
                break;
            case SerializedPropertyType.BoundsInt:
                EditorGUI.LabelField(position, label, new GUIContent(property.boundsIntValue.ToString()));
                break;
            default:
                EditorGUI.LabelField(position, label.text, "This property type is not supported");
                break;
        }
    }
}
