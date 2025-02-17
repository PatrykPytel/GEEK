using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspektor : MonoBehaviour
{
    public GameObject Paper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Paper.GetComponent<TextAnimation>().Animate();
    }
}
