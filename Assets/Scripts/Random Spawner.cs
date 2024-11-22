using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> objects = new();
    public float minSpawnTime =5f;
    public float maxSpawnTime =10f;
    
    private float nextSpawnTime;
    IEnumerator coroutine;
    private void Start()
    {
        StartCoroutine(nameof(DelayedSpawn));
    }

    private IEnumerator DelayedSpawn()
    {
        yield return new WaitForSeconds(6f);
        
        int random = Random.Range(0, objects.Count);
        Vector3 randpos = new Vector3(Random.Range(-97, -12),39, Random.Range(-59, 27));
        Instantiate(objects[random], randpos, Quaternion.identity);
        Debug.Log("VAKİT GELDİ");
        StartCoroutine(nameof(DelayedSpawn));
    }
    

}
