using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int activeScene;
    public int nextScene;

    public bool paused = false;

    public GameObject PauseMenYouScren;

    void Start()
    {
        activeScene = SceneManager.GetActiveScene().buildIndex;
        nextScene = activeScene + 1;
    }

    void Update()
    {
        if (paused)
        {
            Time.timeScale = 0;
            PauseMenYouScren.SetActive(true);
        }
        else if (paused == false)
        {
            Time.timeScale = 1;
            PauseMenYouScren.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Redo()
    {
        SceneManager.LoadScene(activeScene);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void ClickPause()
    {
        if (paused)
        {
            paused = false;
        }
        else if (paused == false)
        {
            paused = true;
        }
    }

}