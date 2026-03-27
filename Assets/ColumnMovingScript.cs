using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovingScript : MonoBehaviour
{
   public float moveSpeed = 5;
   public float deadZone = -30;
   AngelScript angel;
  void Start() {
    GameObject birdObj = GameObject.FindGameObjectWithTag("Player");
    if (birdObj != null) {
        angel = birdObj.GetComponent<AngelScript>();
    }
    
}

    // Update is called once per frame
    void Update()
    {  
         if (angel.angelIsAlive) { 
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Debug.Log("Column Deleted");
            Destroy(gameObject);
        }
    }
}
