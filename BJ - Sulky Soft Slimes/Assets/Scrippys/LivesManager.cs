using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public int lives = 6;
    public GameObject[] hearts;

    public void RemoveLife()
    {
        lives -= 1;

        hearts[lives].SetActive(false);

        if (lives <= 0)
        {
            this.gameObject.GetComponent<YouLose>().YouLoser();
        }
    }
}
