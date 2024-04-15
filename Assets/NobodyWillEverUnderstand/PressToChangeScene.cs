using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToChangeScene : MonoBehaviour
{
    public string SceneName;

    private bool _laptopFound = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _laptopFound)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    public void PressToChangeToScene()
    {
        _laptopFound = true;
    }
}
