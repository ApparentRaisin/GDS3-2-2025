using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

[CustomEditor(typeof(MenuController))]
public class EditorMenuController : Editor
{
    SerializedProperty pauseKey, startEnabled, quitEnabled;

    private void OnEnable()
    {
        pauseKey = serializedObject.FindProperty("pauseKey");
        startEnabled = serializedObject.FindProperty("startEnabled");
        quitEnabled = serializedObject.FindProperty("quitEnabled");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(pauseKey, true);

        startEnabled.boolValue = EditorGUILayout.Toggle(startEnabled.boolValue);
        quitEnabled.boolValue = EditorGUILayout.Toggle(quitEnabled.boolValue);

        if (startEnabled.boolValue)
        {
            serializedObject.
                targetObject.
                GameObject().
                transform.
                Find("Start").
                gameObject.SetActive(true);
        }
        else
        {
            serializedObject.
                targetObject.
                GameObject().
                transform.
                Find("Start").
                gameObject.SetActive(false);
        }

        serializedObject.
                targetObject.
                GameObject().
                transform.
                Find("Quit").
                gameObject.SetActive(quitEnabled.boolValue);

        serializedObject.ApplyModifiedProperties();
    }
}
