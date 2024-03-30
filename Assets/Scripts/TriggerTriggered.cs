using UnityEngine;
using System.Collections.Generic;
using Yarn.Unity;

public class TriggerTriggered : MonoBehaviour
{
    public List<GameObject> objectsToTrack;
    public DialogueRunner dialogueRunner;
    public string dialogueNodeName;

    private bool _played = false;

    private void Update()
    {
        bool allObjectsMatchColor = true;
        foreach (var obj in objectsToTrack)
        {
            var renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                if (renderer.sharedMaterial.color != new Color(0, 255, 0, 255))
                {
                    allObjectsMatchColor = false;
                    break;
                }
            }
        }

        if (allObjectsMatchColor && _played == false)
        {
            dialogueRunner.StartDialogue(dialogueNodeName);
            _played = true;
        }
    }
}