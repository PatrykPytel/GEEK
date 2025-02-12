using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karta_inter : MonoBehaviour
{
    public GameObject paper_closed;
    public GameObject paper_opened;
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
        paper_closed.SetActive(false);
        paper_opened.transform.position = new Vector3(0, 0, 0);
        paper_opened.SetActive(true);
    }
}