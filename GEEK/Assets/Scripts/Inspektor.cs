using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspektor : MonoBehaviour
{
    public GameObject Paper;
    private Dialogtrigger  m_dialogtrigger;
    public bool isUsefull = false;


    // Start is called before the first frame update
    private void Awake()
    {
        m_dialogtrigger = GetComponent<Dialogtrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(isUsefull)
        {
            Paper.GetComponent<TextAnimation>().Animate();
        }
        m_dialogtrigger.StartDialog();
    }
}
