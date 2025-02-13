using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Paper_info : MonoBehaviour
{
    public Information[] informations;
    public Ofiara[] ofiary;
    public Image actorImage;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;

    Information[] currentMessages;
    Ofiara[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;
    // Start is called before the first frame update
    public void OpenDialogue(Information[] informations, Ofiara[] ofiary)
    {
        currentMessages = informations;
        currentActors = ofiary;
        activeMessage = 0;
        isActive = true;

        // Debug.Log("Started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f);
    }

    void DisplayMessage()
    {
        Information messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Ofiara actorToDisplay = currentActors[messageToDisplay.ofiaraId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            //  Debug.Log("Conversation ended");
            isActive = false;
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
        }
    }
    void AnimateTextColor()
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }
    private void OnMouseDown()
    {
        if (isActive)
        {
            NextMessage();
        }
    }     // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

}
public class Ofiara
{
    public string name;
    public Sprite sprite;
}
public class Information
{
    public string message;
    public int ofiaraId;
}
