using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;

public class InformationDisplay : MonoBehaviour
{
    [SerializeField] Transform targetPlayer;
    [SerializeField] TextMeshProUGUI titleTextObject;
    [SerializeField] TextMeshProUGUI descriptionTextObject;
    private bool isBlank = true;

    public void Start()
    {
        titleTextObject.text = "";
        descriptionTextObject.text = "";
        isBlank = true;
    }

    public void ResetInformation()
    {
        titleTextObject.text = "";
        descriptionTextObject.text = "";
        isBlank = true;
    }

    public void SetInformation(InformationData gameObjectData)
    {
        if (isBlank)
        {
            titleTextObject.text = gameObjectData.GetPlanetName();
            descriptionTextObject.text = gameObjectData.GetPlanetDescription();
            isBlank = false;
        }
    }
        
    public void SetPosition(Transform referenceTransform)
    {
        // The information panel moves closer to the player.
        transform.position = targetPlayer.position + targetPlayer.forward * 2.0f;
        // The information panel is looking at the player.
        transform.LookAt(targetPlayer);
        transform.Rotate(new Vector3(0, 180, 0));
    }
}
