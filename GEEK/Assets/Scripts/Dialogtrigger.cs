using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogtrigger : MonoBehaviour
{
 //   public GameObject dialogmenadzer;
    public Message[] messages;
    public Actor[] actors;

    public void StartDialog() { 
        FindObjectOfType<DialogMenadzer>().OpenDialogue(messages, actors);
    }
}
[System.Serializable]
public class Message { 
    public int actorId;
    public string message;
}
[System.Serializable]
public class Actor { 
    public string name;
    public Sprite sprite;
}