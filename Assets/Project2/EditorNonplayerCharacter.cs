using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NonplayerCharacter))]
public class EditorNonplayerCharacter : Editor
{
    SerializedProperty name;
    SerializedProperty routeArray;
    private void OnEnable()
    {
        name = serializedObject.FindProperty("name");
        routeArray = serializedObject.FindProperty("route");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        name.stringValue = EditorGUILayout.TextField(name.stringValue);

        for (int i = 0; i < routeArray.arraySize; i++)
        {
            routeArray.GetArrayElementAtIndex(i).vector3Value = EditorGUILayout.Vector3Field(i.ToString(), routeArray.GetArrayElementAtIndex(i).vector3Value);
        }

        if (GUILayout.Button("Add Point"))
        {
            routeArray.arraySize += 1;
        }

        if (GUILayout.Button("Remove Point"))
        {
            routeArray.arraySize -= 1;
        }

        serializedObject.ApplyModifiedProperties();

    }

    private void OnSceneGUI()
    {
        serializedObject.Update();

        for (int i = 0; i < routeArray.arraySize; i++)
        {
            routeArray.GetArrayElementAtIndex(i).vector3Value = 
                Handles.PositionHandle(
                    routeArray.GetArrayElementAtIndex(i).vector3Value, 
                    Quaternion.identity
                    );
        }

        Event currentEvent = Event.current;

        if(currentEvent.type == EventType.MouseDown && 
            currentEvent.button == 0)
        {
            Debug.Log("click!");
        }

        serializedObject.ApplyModifiedProperties();
    }
}
