using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_Page : MonoBehaviour
{
    public GameObject currentpage;
    public GameObject nextpage;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextPage()
    {
        currentpage.SetActive(false);
        nextpage.SetActive(true);

    }
    private void OnMouseDown()
    {
        currentpage.SetActive(false);
        nextpage.SetActive(true);
    }

}
