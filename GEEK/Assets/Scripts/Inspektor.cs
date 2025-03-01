using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspektor : MonoBehaviour
{
    public GameObject Paper;
    private Dialogtrigger  m_dialogtrigger;
    public bool correct = false;
    private bool done = true;

    // Start is called before the first frame update
    private void Awake()
    {
        m_dialogtrigger = GetComponent<Dialogtrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(done)
        {
            if (correct)
            {
                Paper.GetComponent<TextAnimation>().Animate();
               // m_dialogtrigger.StartDialog();
                correct = false;
                done = false;
    
            }
        }
    }

}
