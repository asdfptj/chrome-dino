using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float spawnTime = 1f;
    [SerializeField]
    private GameObject[] spawnList;
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= spawnTime)
        {
            GameObject spawnPrefab = spawnList[Random.Range(0, spawnList.Length)];
            Instantiate(spawnPrefab, transform.position, transform.rotation, transform);
        }
    }
}
