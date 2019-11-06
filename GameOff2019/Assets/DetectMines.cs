using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMines : MonoBehaviour
{
    public int MinesNearMe = 0;
    public GameObject[] Mines;
    public float Distance;
    public bool Stopper = true;
    public GameObject NumberBlock1;
    public GameObject NumberBlock2;
    public GameObject NumberBlock3;
    public GameObject NumberBlock4;
    public GameObject NumberBlock5;
    public GameObject NumberBlock6;
    public GameObject NumberBlock7;
    public GameObject NumberBlock8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Stopper)
        {
            Stopper = false;
            Mines = GameObject.FindGameObjectsWithTag("Mine");
            //Debug.Log("Mines Length: " + Mines.Length);
            //foreach (GameObject mine in Mines)
            //{
            //    Distance = Vector3.Distance(mine.transform.position, transform.position);
            //    //Debug.Log("Distance: " + Distance);
            //    if (Distance <= 1.5)
            //    {
            //        MinesNearMe++;
            //    }
            //}
            for (int i = 0; i < Mines.Length; i++)
            {
                Distance = Vector3.Distance(Mines[i].transform.position, transform.position);
                if (Distance <= 1.4142)
                {
                    MinesNearMe++;
                }
            }
            if (MinesNearMe > 0)
            {
                Debug.Log("MinesNear: " + MinesNearMe);
            }
            switch (MinesNearMe)
            {
                case 0:
                    break;
                case 1:
                    Instantiate(NumberBlock1, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 2:
                    Instantiate(NumberBlock2, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 3:
                    Instantiate(NumberBlock3, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 4:
                    Instantiate(NumberBlock4, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 5:
                    Instantiate(NumberBlock5, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 6:
                    Instantiate(NumberBlock6, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 7:
                    Instantiate(NumberBlock7, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;
                case 8:
                    Instantiate(NumberBlock8, transform.position, transform.rotation);
                    Destroy(gameObject);
                    break;


            }
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Mine")
        {
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "Detector")
        {
            Destroy(gameObject);
        }
    }
}
