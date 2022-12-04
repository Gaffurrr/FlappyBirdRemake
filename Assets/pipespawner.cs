using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pipespawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Pipe;
    public float height;
    public bool pause; 

    void Start()
    {
        GameObject newPipe = Instantiate(Pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
