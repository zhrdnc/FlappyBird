using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawnScript : MonoBehaviour
{
    public GameObject column;
    public float spawnRate= 1.3f;
    private float timer=0;
    public float heightOffset=10;
    void Start()
    {
        spawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnColumn();
            timer=0;
        }
        
    }
  
    void spawnColumn()
    {
        float lowestPoint = transform.position.y-heightOffset;
        float highestPoint= transform.position.y+heightOffset;

        Instantiate(column, new Vector3(transform.position.x, Random.Range (lowestPoint,highestPoint),0),  transform.rotation);
    }
}
