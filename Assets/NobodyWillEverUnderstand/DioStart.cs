using UnityEngine;
using Yarn.Unity;

public class DioStart : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public string dialogueNodeName;

    public void Dialog()
    {
        dialogueRunner.StartDialogue(dialogueNodeName);
    }
}
