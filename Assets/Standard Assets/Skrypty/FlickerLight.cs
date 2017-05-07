using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour {

    public GameObject Lights;
    public float timer;

    // Use this for initialization
    void Start () {
        StartCoroutine(FlickeringLight());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator FlickeringLight()
    {
        Lights.SetActive(true);
        timer = Random.Range(0.1f, 1);
        yield return new WaitForSeconds(timer);
        Lights.SetActive(false);
        timer = Random.Range(0.1f, 1);
        yield return new WaitForSeconds(timer);
        StartCoroutine(FlickeringLight());
    }
}
