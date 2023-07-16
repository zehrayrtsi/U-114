using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreditsButton : MonoBehaviour
{
    public GameObject creditsPanel;
    public ControllersButton controllersButtonDoubleCheck;
    public bool creditsPanelCheck;
    public void ButtonFunction()
    {
        if (controllersButtonDoubleCheck.controllersPanelCheck)
        {
            controllersButtonDoubleCheck.ButtonFunction();
        }

        bool isActive = creditsPanel.activeSelf;
        creditsPanel.SetActive(!isActive);
        creditsPanelCheck = !isActive;
    }
}



/*
public class CreditsButton : MonoBehaviour
{
    public GameObject creditsPanel;
    [SerializeField] private float count = 0;
    

    public void ShowCreditsPanel()
    {
        creditsPanel.SetActive(true);
    }

    public void HideCreditsPanel()
    {
        creditsPanel.SetActive(false);
    }

        public void ButtonFunction()
{
    Button buton = GetComponent<Button>();
    buton.onClick.AddListener(delegate {
        if (count % 2 == 0) {
            HideCreditsPanel();
        } else {
            ShowCreditsPanel();
        }
    });
    count++;
}
}
*/