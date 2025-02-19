using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutlineInspektor : MonoBehaviour
{
    private Outline m_outline;
    public bool isoutlined = false;
    public GameObject Counter;
    public bool isInfo = false;

    private int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_outline = GetComponent<Outline>();
        m_outline.enabled = isoutlined;
    }

    // Update is called once per frame
    void Update()
    {

        if(isoutlined)
        {
            if(!isInfo && counter < Counter.GetComponent<InspectionCounter>().Papercounter)
            {
                m_outline.enabled = false;
                isoutlined = false;
                //Counter.GetComponent<InspectionCounter>().Papercounter -= 1;
               



            }
            if (isInfo && counter< Counter.GetComponent<InspectionCounter>().Infocounter)
            {
               // Counter.GetComponent<InspectionCounter>().Infocounter -= 1;
         
                m_outline.enabled = false;
                isoutlined = false;
            }
        }
    }
    private void OnMouseDown()
    {

       // m_outline.enabled = !(isoutlined);
        if(isoutlined == false && !isInfo) {
            Counter.GetComponent<InspectionCounter>().Papercounter += 1;

            counter = Counter.GetComponent<InspectionCounter>().Papercounter;
          //  counter += 1;

            m_outline.enabled = true;
            isoutlined = true;
           // counter = Counter.GetComponent<InspectionCounter>().Papercounter;
        }
        else if (isoutlined == false && isInfo)
        {
            Counter.GetComponent<InspectionCounter>().Infocounter += 1;
            counter = Counter.GetComponent<InspectionCounter>().Infocounter;

           // counter += 1;
            m_outline.enabled = true;
            isoutlined=true;
        }else if(isoutlined == true && isInfo)
        {
            m_outline.enabled = false;
            isoutlined = false;
            Counter.GetComponent<InspectionCounter>().Infocounter -= 1;

        }
        else if(isoutlined == true && !isInfo)
        {
            isoutlined = false;
            m_outline.enabled =false;   
            Counter.GetComponent<InspectionCounter>().Papercounter -= 1;

        }
       // if(counter ==2)
      //  {
      //      counter = 1;
      //  }
        
        
        //Debug.Log(isoutlined);

    }
}
