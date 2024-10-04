using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private readonly float netRotationPerSecond = -0.667f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, netRotationPerSecond * Time.deltaTime, 0);
    }
}
