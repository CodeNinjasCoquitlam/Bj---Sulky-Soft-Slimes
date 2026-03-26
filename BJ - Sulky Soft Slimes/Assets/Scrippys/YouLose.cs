using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    [Header("win")]
    public GameObject WeenScreen;
    [Header("Loose")]
    public GameObject LoseScreen;
    [Header("Die")]
    public GameObject DieScreen;

    private LivesManager liveScrip;
    void Start()
    {
        liveScrip = GameObject.Find("GameManager").GetComponent<LivesManager>();
        liveScrip.LivesContainer.SetActive(true);
        Time.timeScale = 1;
        LoseScreen.SetActive(false);
        WeenScreen.SetActive(false);
        DieScreen.SetActive(false);
    }
    public void YouLoser()
    {
        Time.timeScale = 0;
        LoseScreen.SetActive(true);
        liveScrip.LivesContainer.SetActive(false);

    }
    public void YouDie()
    {
        Time.timeScale = 0;
        DieScreen.SetActive(true);
        liveScrip.LivesContainer.SetActive(false);
    }
    public void YouWEENER()
    {
        Time.timeScale = 0;
        WeenScreen.SetActive(true);
        liveScrip.LivesContainer.SetActive(false);
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
