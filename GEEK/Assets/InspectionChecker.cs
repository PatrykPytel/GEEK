using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionChecker : MonoBehaviour
{
    public GameObject informacja;
    public GameObject dialog;
    public GameObject counter;
    private Outline m_outline;
    // Start is called before the first frame update
    void Start()
    {
        m_outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(informacja.GetComponent<OutlineInspektor>().isoutlined == true &&  m_outline.enabled == true)
        {
             dialog.GetComponent<Inspektor>().correct = true;
        }
    }
}
