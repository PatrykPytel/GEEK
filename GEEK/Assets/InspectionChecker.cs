using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionChecker : MonoBehaviour
{
    public GameObject informacja;
    private Dialogtrigger m_dialogtrigger;
    public GameObject Paper;
    private bool done = true;
    // Start is called before the first frame update
    void Start()
    {
  
        m_dialogtrigger = GetComponent<Dialogtrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(informacja.GetComponent<OutlineInspektor>().isoutlined  && done)
        {            
             Paper.GetComponent<TextAnimation>().Animate();
            m_dialogtrigger.StartDialog();
             done = false;
             
        }
    }
}
