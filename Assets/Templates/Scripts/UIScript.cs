using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    GameObject[] _gameOverObject;
    // Start is called before the first frame update
    void Start()
    {
        _gameOverObject = GameObject.FindGameObjectsWithTag("ShowOnGameOver");
        HideGameOver();
    }
    public void HideGameOver()
    {
        foreach (GameObject GO in _gameOverObject)
        {
            GO.SetActive(false);
        }
    }
    public void ShowGameOver()
    {
        Time.timeScale = 0;
        foreach (GameObject GO in _gameOverObject)
        {
            GO.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
