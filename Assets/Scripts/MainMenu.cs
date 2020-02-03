using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject transition;
    public Animator transitionAnim;

    private void Awake()
    {
        transition.SetActive(true);
    }
    public void PlayGame()
    {
        transitionAnim.SetTrigger("end");
        Invoke("CallGame", 1.5f);
    }
    public void QuitGame()
    {
        transitionAnim.SetTrigger("end");
        Invoke("CallQuitGame", 1f);
    }

    public void CallQuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void CallGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
