using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
   [SerializeField] Text _roomName;

   public void OnClick_CreateRoom()
   {
      if (!PhotonNetwork.IsConnected)
      {
         Debug.Log("Cannot create room. Currently not connected to the Photon Network...");
         return;
      }

      RoomOptions options = new RoomOptions();
      options.MaxPlayers = 2;
      PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
   }

   public override void OnCreatedRoom()
   {
      base.OnCreatedRoom();

      Debug.Log("Created room successfully." + this);
   }

   public override void OnCreateRoomFailed(short returnCode, string message)
   {
      base.OnCreateRoomFailed(returnCode, message);

      Debug.Log("Room created failed: " + message + this);
   }
}
