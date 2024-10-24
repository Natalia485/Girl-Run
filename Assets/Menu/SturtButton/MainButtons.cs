using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    [SerializeField] private GameObject _PausePanel;

    public void Pause()
    {
        Time.timeScale = 0f;
        _PausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        _PausePanel.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _PausePanel.SetActive(false);
    }
}
