using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChatManager : MonoBehaviour {
    public int maxMessages = 25;
    public GameObject chatPanel, textObject;
    public InputField chatBox;
    public Color playerMessage;
    public Color otherMessage;
    [SerializeField]
    List<Message> messageList = new List<Message>();

	// Use this for initialization
	void Update () {
        if(chatBox.text != "")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SendMessageToChat(chatBox.text, Message.MessageType.playerMessage);
                chatBox.text = "";
                Debug.Log("Fuck yeah!");
            }
        }
        else
        {
            if(!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return))
            {
                chatBox.ActivateInputField();
            }
        }
       
       
	}

    public void SendMessageToChat(string text, Message.MessageType messageType)
    {

        if(messageList.Count >= maxMessages)
        {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage = new Message();
        newMessage.text = text;
        GameObject newText = Instantiate(textObject, chatPanel.transform);
        newMessage.textObject = newText.GetComponent<Text>();
        newMessage.textObject.text = newMessage.text;
        //newMessage.textObject.color = MessageTypeColor(messageType);
        messageList.Add(newMessage);
        
    }

    Color MessageTypeColor(Message.MessageType messageType)
    {
        Color color = otherMessage;
        switch (messageType)
        {
            case Message.MessageType.playerMessage:
                color = playerMessage;
                break;
        }
        return color;
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;

    public MessageType messageType;
    public enum MessageType
    {
        playerMessage,
        otherMessage
    }
}
