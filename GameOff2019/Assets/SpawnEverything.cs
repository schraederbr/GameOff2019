using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEverything : MonoBehaviour
{
    
    public GameObject mine;
    public GameObject detector;
    public int NumberOfMines;
    public int DistanceToEdge;
    // Start is called before the first frame update
    void Awake()
    {
        //1st Quadrant
        for (int i = 0; i < DistanceToEdge; i++)
        {
            for (int j = 1; j < DistanceToEdge; j++)
            {
                Instantiate(detector);
                Vector3 NewPosition = new Vector3(i, 0, j);
                detector.transform.position = NewPosition;
            }
        }
        //2nd Quadrant
        for (int i = 1; i < DistanceToEdge; i++)
        {
            for (int j = 0; j < DistanceToEdge; j++)
            {
                Instantiate(detector);
                Vector3 NewPosition = new Vector3(-i, 0, j);
                detector.transform.position = NewPosition;
            }
        }
        //3rd Quadrant
        for (int i = 0; i < DistanceToEdge; i++)
        {
            for (int j = 1; j < DistanceToEdge; j++)
            {
                Instantiate(detector);
                Vector3 NewPosition = new Vector3(-i, 0, -j);
                detector.transform.position = NewPosition;
            }
        }
        //4th Quadrant
        for (int i = 1; i < DistanceToEdge; i++)
        {
            for (int j = 0; j < DistanceToEdge; j++)
            {
                Instantiate(detector);
                Vector3 NewPosition = new Vector3(i, 0, -j);
                detector.transform.position = NewPosition;
            }
        }
        ////Middle
        //for (int j = 0; j < DistanceToEdge; j++)
        //{
        //    Instantiate(detector);
        //    Vector3 NewPosition = new Vector3(0, 0, j);
        //    detector.transform.position = NewPosition;
        //}







        for (int i = 0; i < NumberOfMines; i++)
        {
            Instantiate(mine);
        }
    }
    void Start()
    {
        Instantiate(detector);
        Vector3 NewPosition = new Vector3(0, 0, 0);
        detector.transform.position = NewPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
