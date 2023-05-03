using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomLerp = 0.1f;

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            fpsCamera.m_Lens.FieldOfView = Mathf.Lerp(fpsCamera.m_Lens.FieldOfView, zoomedInFOV, zoomLerp);
        }
        else
        {
            fpsCamera.m_Lens.FieldOfView = Mathf.Lerp(fpsCamera.m_Lens.FieldOfView, zoomedOutFOV, zoomLerp);
        }

    }
}
