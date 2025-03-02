using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startdialog : MonoBehaviour
{
    private Dialogtrigger Dialogtrigger;
    // Start is called before the first frame update
    void Start()
    {
        Dialogtrigger = GetComponent<Dialogtrigger>();
        Dialogtrigger.StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
