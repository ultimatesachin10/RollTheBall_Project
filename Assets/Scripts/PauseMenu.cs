using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PausedMenu;

    private void Start()
    {
        PausedMenu.SetActive(false);
    }
    public void Pause()
    {
        PausedMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PausedMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
