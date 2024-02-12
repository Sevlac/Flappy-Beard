using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazorGenerator : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject razor;
    public float height;

    private float timer;

    void Start()
    {
        timer = maxTime;
    }


    void Update()
    {
        if (timer > maxTime)
        {
            CreateRazors();
        }

        timer += Time.deltaTime;
    }

    void CreateRazors()
    {
        GameObject newRazor = Instantiate(razor);
        newRazor.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newRazor, 15);
        timer = 0;

    }
}
