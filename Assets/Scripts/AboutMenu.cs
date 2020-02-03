using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMenu : MonoBehaviour
{
    [SerializeField] private GameObject AboutMenuUI;


    [SerializeField] private GameObject mainMenuUI;

    



    public void ActivateMenu()
    {

        AboutMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);

    }

    public void DeactivateMenu()
    {

        AboutMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);

    }
}