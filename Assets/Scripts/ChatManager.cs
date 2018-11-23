using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour {
    public int maxMessages = 25;

    [SerializeField]
    List<Message> messageList = new List<Message>();

	// Use this for initialization
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessageToChat("You pressed Space");
        }
	}

    public void SendMessageToChat(string text)
    {

        if(messageList.Count >= maxMessages)
        {
            messageList.Remove(messageList[0]);
        }
        Message newMessage = new Message();
        newMessage.text = text;
        messageList.Add(newMessage);
        Debug.Log(newMessage.text);
    }
}

[System.Serializable]
public class Message
{
    public string text;
}
