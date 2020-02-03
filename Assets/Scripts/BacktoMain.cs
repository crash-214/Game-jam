using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMain : MonoBehaviour
{
    public Animator transitionAnim;
    
    public void PrevScene()
    {
        transitionAnim.SetTrigger("end");
        Invoke("CallPrevScene", 1.5f);
    }

    public void CallPrevScene()
    {
        SceneManager.LoadScene(0);
    }
}

