using UnityEngine;
using Yarn.Unity;

public sealed class ColliderTrigger : MonoBehaviour
{
    [SerializeField] private DialogueRunner _dialogueRunner;
    [SerializeField] private string _startNode;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController PlayerController))
        {
            _dialogueRunner.StartDialogue(_startNode);
        }
    }
}

