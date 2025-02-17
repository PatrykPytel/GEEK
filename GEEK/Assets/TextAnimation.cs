using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public string strText;
   
    private TMP_Text m_TextComponent;
    private void Awake()
    {
        m_TextComponent = GetComponent<TMP_Text>();
        
    }
    void Start()
    {
       
        
         
        
      

    }

    IEnumerator AnimateText(string strComplete)
    {
        int i = 0;
        
        while (i < strComplete.Length)
        {
            m_TextComponent.text += strComplete[i++];
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    public void Animate()
    {
        StartCoroutine(AnimateText(strText)); 
    }
}
