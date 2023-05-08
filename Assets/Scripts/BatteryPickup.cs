using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoredAngle = 10f;
    [SerializeField] float restoredIntensity = 20f;
    [SerializeField] FlashLightSystem flashLightSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            flashLightSystem.RestoreLightAngle(restoredAngle);
            flashLightSystem.RestoreLightIntensity(restoredIntensity);
            Destroy(gameObject);
        }
    }

}
