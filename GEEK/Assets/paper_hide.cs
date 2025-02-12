using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper_hide : MonoBehaviour
{
    public GameObject curr;
    public GameObject paper;
    public float granica = -4f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseUp()
    {
        if (transform.position.y < granica) {
            curr.SetActive(false);
            paper.SetActive(true);
        }
    }
}
