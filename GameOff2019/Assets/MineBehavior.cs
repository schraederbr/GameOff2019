using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MineBehavior : MonoBehaviour
{
    public bool IsFlagged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (FlagChangerBehavior.HasFlag == false && IsFlagged == false) {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync(scene.name);
        }
        else if(FlagChangerBehavior.HasFlag == true && IsFlagged == false)
        {
            Renderer MyRenderer = GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            MyRenderer.material.SetColor("_Color", Color.red);
            IsFlagged = true;
        }
        else if (FlagChangerBehavior.HasFlag == true && IsFlagged == true)
        {
            Renderer MyRenderer = GetComponent<Renderer>();
            MyRenderer.material.SetColor("_Color", Color.white);
            IsFlagged = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
