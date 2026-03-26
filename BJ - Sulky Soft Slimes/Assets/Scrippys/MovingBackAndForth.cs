using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackAndForth : MonoBehaviour
{
    public GameObject[] Points;

    public float distanceToMove;
    public float direction = -1f;
    public float speedToMove = 0.1f;

    public Vector3 startingPos;
    public Vector3 endingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = Points[1].transform.position;
        endingPos = Points[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(speedToMove * direction * Time.deltaTime, 0, 0);

        if (Vector3.Distance(transform.position, endingPos) < 0.5f)
        {
            direction *= -1;
        } else if (Vector3.Distance(transform.position, startingPos) < 0.5f)
        {
            direction *= -1;
        }
    }
}
