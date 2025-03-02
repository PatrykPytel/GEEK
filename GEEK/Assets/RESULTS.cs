using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESULTS : MonoBehaviour
{
    public int NumberOFINFO;
    public int CURRENTINFO = 0;
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
        if(CURRENTINFO != NumberOFINFO)
        {
            SceneManager.LoadScene("GameOver");
        }else
        {
            SceneManager.LoadScene("Lobby2");
        }
    }
}
