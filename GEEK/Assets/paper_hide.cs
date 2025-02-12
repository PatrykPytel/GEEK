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
            Vector3 currentPosition = paper.transform.position;
            currentPosition.x = curr.transform.position.x;
            curr.SetActive(false);
            paper.transform.position = currentPosition;
            paper.SetActive(true);
        }
    }
}
