using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minAngle = 30f;

    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }
    private void Update()
    {
        DecreaseLightIntensity();
        DecreaseLightAngle();
    }

    public void RestoreLightIntensity(float restore)
    {
        myLight.intensity += restore;
    }

    public void RestoreLightAngle(float restore)
    {
        myLight.spotAngle = restore;
    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= Time.deltaTime * lightDecay;
    }

    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle >= minAngle)
        {
            myLight.intensity -= Time.deltaTime * angleDecay;
        }
    }
}