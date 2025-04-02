using UnityEngine;
using UnityEditor;

public class NPCWindow : EditorWindow
{
    [MenuItem("Window/NPC Window")]
    static void Initilize()
    {
        NPCWindow newWindow = EditorWindow.GetWindow(typeof(NPCWindow)) as NPCWindow;
        newWindow.Show();
    }

    Object currentNPC;
    private void OnGUI()
    {
        EditorGUILayout.LabelField("WOW a window");
        currentNPC = EditorGUILayout.ObjectField(currentNPC, typeof(NonplayerCharacter), false);

        if(currentNPC != null)
        {
            NonplayerCharacter npcInfo = currentNPC as NonplayerCharacter;
            EditorGUILayout.LabelField(npcInfo.name);
        }
    }
}
