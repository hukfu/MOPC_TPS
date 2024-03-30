using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //переписать это чудо для всех типов переключения сцен
    public Animator Animator;
    public string SceneName;

    private bool _canFade = false;

    private void Update()
    {
        PressToFade();
    }

    public void CanFade()
    {
        _canFade = true;
    }
    public void CanNotFade()
    {
        _canFade = false;
    }

    public void Fade()
    {
        Animator.SetTrigger("FadeOut");
    }
    public void PressToFade()
    {
        if (Input.GetKeyDown(KeyCode.E) && _canFade)
        {
            Animator.SetTrigger("FadeOut");
        }
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SceneName);
    }
}