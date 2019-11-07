using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    public int DistanceToEdge;
    public Vector3 NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        //NewPosition.x = Random.Range(-DistanceToEdge + 1, DistanceToEdge);
        //NewPosition.z = Random.Range(-DistanceToEdge + 1, DistanceToEdge);

        //NewPosition.y = 0;




        //float radius = 0.4f;
        //int LayerMask =  1 << 10;
        //while (Physics.CheckSphere(NewPosition, radius, LayerMask))
        //{
        //    Debug.Log(gameObject.name + " Checked!");
        //    //ImperfectSystem, doesn't change z at all
        //    if (NewPosition.x < DistanceToEdge)
        //    {
        //        NewPosition.x++;
        //    }
        //    else
        //    {
        //        NewPosition.x--;
        //    }
        //}
        
        //    // spot is empty, we can spawn
        //    transform.position = NewPosition;
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        //if (collider.gameObject.tag == "Mine")
        //{
        //    NewPosition.x = Random.Range(-DistanceToEdge + 1, DistanceToEdge);
        //    NewPosition.z = Random.Range(-DistanceToEdge + 1, DistanceToEdge);
        //    NewPosition.y = 0;
        //    transform.position = NewPosition;
        //}
    }
}
