using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
