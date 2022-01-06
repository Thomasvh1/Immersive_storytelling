using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    
    public void OpenPanel()
    {
        if (Panel.active)
        {
            Panel.SetActive(false);
        }
        else if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
