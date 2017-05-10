using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {

    public Light obLight;
    private float[] smoothing = new float[20];

    void Start()
    {
        for (int i = 0; i < smoothing.Length; i++)
            smoothing[i] = .0f;
    }

    void Update()
    {
        if (Input.GetButtonDown("Latarka"))
            obLight.enabled = !obLight.enabled;

        if (obLight.enabled)
        {
            float sum = .0f;
            for (int i = 1; i < smoothing.Length; i++)
            {
                smoothing[i - 1] = smoothing[i];
                sum += smoothing[i - 1];
            }

            smoothing[smoothing.Length - 1] = Random.value;
            sum += smoothing[smoothing.Length - 1];

            obLight.intensity = (sum / smoothing.Length)+2;
        }
    }
}
