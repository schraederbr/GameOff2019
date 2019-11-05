using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderScore : MonoBehaviour
{
    public GameObject ScoreText;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ring")
        {
            
            string CurrentText = ScoreText.GetComponent<Text>().text;
            Score = int.Parse(CurrentText);
            Score++;
            ScoreText.GetComponent<Text>().text = Score.ToString();
            Destroy(collider.gameObject);
        }
    }
}
