using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] GameObject referenceObject;
    float orbitTime;
    float orbitRadius;

    void Start()
    {
        orbitRadius = Vector3.Distance(
            transform.position, referenceObject.transform.position);
        orbitTime = 10.0f;
    }

    void Update()
    {
        float netDegreeChange = 15f / orbitRadius * Time.deltaTime; 
        Vector3 rotationChange = new Vector3(0, netDegreeChange, 0);
        transform.Rotate(rotationChange);
        // The new rotation of the Game Object is returned.
        Vector3 rotation = transform.rotation.eulerAngles;
        // The new relative X and Z coordinates are calculated.
        float x = Mathf.Cos(rotation.y);
        float z = Mathf.Sin(rotation.y);
        Vector3 position = new (x, 0, z);
        // The position of the Game Object is transformed relative to the reference object.
        transform.position = referenceObject.transform.position + position * orbitRadius;
    }
}