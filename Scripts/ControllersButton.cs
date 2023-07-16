using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllersButton : MonoBehaviour
{
    public GameObject controllersPanel;
    public bool controllersPanelCheck;
    public CreditsButton CreditsButtonDoubleCheck;

    public void ButtonFunction()
    {
        if (CreditsButtonDoubleCheck.creditsPanelCheck)
        {
            CreditsButtonDoubleCheck.ButtonFunction();
        }
        bool isActive = controllersPanel.activeSelf;

        controllersPanel.SetActive(!isActive);
        controllersPanelCheck = !isActive;
    }
}

/*
public class ControllersButton : MonoBehaviour
{
    public GameObject controllersPanel;
    [SerializeField] private float count = 0;

    public void ShowControllersPanel()
    {
        controllersPanel.SetActive(true);
    }

    public void HideControllersPanel()
    {
        controllersPanel.SetActive(false);
    }

    public void ButtonFunction()
{
    Button buton = GetComponent<Button>();
    buton.onClick.AddListener(delegate {
        if (count % 2 == 0) {
            HideControllersPanel();            
        } else {
            ShowControllersPanel();
        }
    });
    count++;
}

}
*/
