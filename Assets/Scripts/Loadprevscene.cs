using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadprevscene : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    public void PrevScene()
    {
        transitionAnim.SetTrigger("end");
        Invoke("CallPrevScene", 1.5f);
    }

    public void CallPrevScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
