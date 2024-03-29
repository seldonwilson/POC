﻿using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks {

   private void Start() {
      print("Connecting to server...");
      PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
      PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
      PhotonNetwork.ConnectUsingSettings();
   }

   public override void OnConnectedToMaster() {
      base.OnConnectedToMaster();
      print("Connected to server : )");
      print(PhotonNetwork.LocalPlayer.NickName);

         // Room listings can only occur from within a lobby
      PhotonNetwork.JoinLobby();
      if (PhotonNetwork.InLobby) {
         print("Joined lobby. Updating room listings...");
      }
   }

   public override void OnDisconnected(DisconnectCause cause) {
      base.OnDisconnected(cause);
      print("Disconnected from server for reason " + cause.ToString());
   }
}
