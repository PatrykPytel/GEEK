using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionChecker : MonoBehaviour
{
    public GameObject informacja;
    public GameObject wrong_response;
    public GameObject counter;
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
        if(informacja.GetComponent<OutlineInspektor>().isoutlined == true)
        {
            informacja.GetComponent<Inspektor>().correct = true;
        }
    }
}
