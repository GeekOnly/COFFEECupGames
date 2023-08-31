using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    public Transform Point;

    public float SpawnRate = 2;

    void Start()
    {
        StartCoroutine(SpawnBall());
    }
    
    IEnumerator SpawnBall()
    {
        while (true)
        {
            Vector3 RandomPos = new Vector3(Random.Range(-18f, 18f), Point.transform.position.y, Point.transform.position.z);
            GameObject ball = Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], RandomPos,Quaternion.identity);
            yield return new WaitForSeconds(SpawnRate * 0.98f);
        }
    }
}
