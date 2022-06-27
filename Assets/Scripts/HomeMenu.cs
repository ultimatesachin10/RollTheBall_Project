using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using DG.Tweening;

public class HomeMenu : MonoBehaviour
{
     [SerializeField] private RectTransform _playbuttton;
    [SerializeField] private RectTransform _quitbuttton;
    [SerializeField] private GameObject _joystick;

    private void Start()
     {
        _playbuttton.DOAnchorPos(new Vector2(0, 121.0343f),1f);
        
        _quitbuttton.DOAnchorPos(new Vector2(-3.2033f, -56f),1f);

     }

    #region On Click Methods

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene(1);
    }

    public void EnableJoystick()
    {
        if (_joystick.activeInHierarchy == false)
            _joystick.SetActive(true);
        else
            _joystick.SetActive(false);        
    }

    #endregion

}
