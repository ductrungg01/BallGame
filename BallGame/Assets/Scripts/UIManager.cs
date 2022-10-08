using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public GameObject gameoverPanel;

    public void setScoreText(string s)
    {
        if (score != null)
        {
            score.text = s;
        }
    }

    public void showGameOverPanel(bool isShow)
    {
        if (gameoverPanel)
        {
            gameoverPanel.SetActive(isShow);
        }
    }
}
