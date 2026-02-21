using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("mous info")]
    public Vector3 clickStartLocation;
    [Header("Physic")]
    public Vector3 LaunchVector;
    public float LaunchForce;
    [Header("slimed out")]
    public Transform SlimeTransform;
    public Rigidbody slimeRigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            LaunchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
                );
            //SlimeTransform.position = originalSlimePosition - LaunchVector / 400;
            LaunchVector.Normalize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(LaunchVector * LaunchForce, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
