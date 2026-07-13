using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject startingPos;
    public GameObject endingPos;

    public float speed = 0.1f;
    public float direction = -1f;


    void Start()
    {
        
    }

    void Update()
    {
        if (this.gameObject.transform.position.x > endingPos.transform.position.x)
        {
            direction *= -1;
        }
        if (this.gameObject.transform.position.x < startingPos.transform.position.x)
        {
            direction *= -1;
        }
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + speed * Time.deltaTime * direction, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
