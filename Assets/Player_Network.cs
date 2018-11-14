using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

namespace City_Virtual
{
    public class Player_Network : NetworkBehaviour
    {
        public GameObject firstPersonCharacter;
        public GameObject[] characterModel;

        public override void OnStartLocalPlayer()
        {
            GetComponent<FirstPersonController>().enabled = true;
            firstPersonCharacter.SetActive(true);

            foreach(GameObject go in characterModel)
            {
                go.SetActive(false);
            }
        }

    }
}