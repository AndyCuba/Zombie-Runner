using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    bool isZoomed = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ToggleZoom();
        }

    }

    private void ToggleZoom()
    {
        if (!isZoomed)
        {
            isZoomed = true;
            fpsCamera.fieldOfView = zoomedInFOV;
        }
        else
        {
            isZoomed = false;
            fpsCamera.fieldOfView = zoomedOutFOV;
        }
    }
}
