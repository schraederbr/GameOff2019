using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Random = UnityEngine.Random;

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
                Instantiate(detector, new Vector3(i, 0, j), transform.rotation);
                //Vector3 NewPosition = new Vector3(i, 0, j);
                //detector.transform.position = NewPosition;
            }
        }
        //2nd Quadrant
        for (int i = 1; i < DistanceToEdge; i++)
        {
            for (int j = 0; j < DistanceToEdge; j++)
            {
                Instantiate(detector, new Vector3(-i, 0, j), transform.rotation);
                //Vector3 NewPosition = new Vector3(-i, 0, j);
                //detector.transform.position = NewPosition;
            }
        }
        //3rd Quadrant
        for (int i = 0; i < DistanceToEdge; i++)
        {
            for (int j = 1; j < DistanceToEdge; j++)
            {
                Instantiate(detector, new Vector3(-i, 0, -j), transform.rotation);
                //Vector3 NewPosition = new Vector3(-i, 0, -j);
                //detector.transform.position = NewPosition;
            }
        }
        //4th Quadrant
        for (int i = 1; i < DistanceToEdge; i++)
        {
            for (int j = 0; j < DistanceToEdge; j++)
            {
                Instantiate(detector, new Vector3(i, 0, -j), transform.rotation);
                //Vector3 NewPosition = ;
                //detector.transform.position = NewPosition;
            }
        }
        ////Middle
        //for (int j = 0; j < DistanceToEdge; j++)
        //{
        //    Instantiate(detector);
        //    Vector3 NewPosition = new Vector3(0, 0, j);
        //    detector.transform.position = NewPosition;
        //}

        Instantiate(detector, new Vector3(0, 0, 0), transform.rotation);
        //Vector3 MiddlePosition = new Vector3(0, 0, 0);
        //detector.transform.position = MiddlePosition;



        //Spawn mines at their correct positions here
        int TimesChecked = 0;
        int MinesSpawned = 0;
        int TotalSpaces = (int) (((DistanceToEdge-1) * 2)+1) * (((DistanceToEdge - 1) * 2)+1);
        Debug.Log("Total Spaces: " + TotalSpaces);
        for (int i = -DistanceToEdge + 1; i < DistanceToEdge; i++)
        {
            for (int j = -DistanceToEdge + 1; j < DistanceToEdge; j++)                                                                                                                         
            {
                TimesChecked++;
                if (Random.Range(0,TotalSpaces) <= NumberOfMines)
                {
                    if (MinesSpawned < NumberOfMines) {
                        Instantiate(mine, new Vector3(-i, 0, -j), transform.rotation);
                        MinesSpawned++;
                    }
                }
            }
        }
        Debug.Log("MinesSpawned: " + MinesSpawned);
        Debug.Log("TimesChecked" + TimesChecked);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
