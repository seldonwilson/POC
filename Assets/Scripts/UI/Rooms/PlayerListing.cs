﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class PlayerListing : MonoBehaviour
{
   [SerializeField]
   private Text _text = null;

   public Player Player { get; private set; }

   public void SetPlayerInfo(Player player)
   {
      Player = player;
      _text.text = player.NickName;
   }
}
