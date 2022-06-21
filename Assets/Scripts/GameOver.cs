using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public void Setup(int _count)
    {
        gameObject.SetActive(true);
        pointsText.text = _count.ToString();

    }
}
