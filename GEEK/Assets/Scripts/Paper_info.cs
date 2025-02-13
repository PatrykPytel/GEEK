using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper_info : MonoBehaviour
{
    public Information[] informations;
    public Ofiara[] ofiary;
     // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
public class Ofiara
{
    public string name;
    public Sprite zdj;
}
public class Information
{
    public string message;
    public int ofiaraId;
}
