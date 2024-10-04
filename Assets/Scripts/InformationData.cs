using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationData : MonoBehaviour
{
    [SerializeField] string planetName;
    [SerializeField] string planetDescription;

    public string GetPlanetName() {
        return planetName;
    }

    public string GetPlanetDescription() {
        return planetDescription;
    }
}
