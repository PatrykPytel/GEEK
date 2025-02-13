using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper_hide : MonoBehaviour
{
    public GameObject curr;
    public GameObject paper;
    public float granica_y = -4f;
    public float granica_x = -8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseUp()
    {
        if (transform.position.y < granica_y) {
            Vector3 currentPosition = paper.transform.position;
            if (transform.position.x < granica_x)
            {
                currentPosition.x = granica_x;
            }else if(transform.position.x > (granica_x * -1))
            {
                currentPosition.x = granica_x*-1;
            }
            else
            {
                currentPosition.x = curr.transform.position.x;
            }
            curr.SetActive(false);
            paper.transform.position = currentPosition;
            paper.SetActive(true);


        }



    }
}
