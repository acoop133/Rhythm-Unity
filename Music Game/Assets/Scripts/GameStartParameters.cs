﻿using UnityEngine;

namespace Assets.Scripts
{
    public class GameStartParameters : MonoBehaviour {

        public static StartMapJson MapJson = new StartMapJson();
        // Use this for initialization

        public class StartMapJson : MapJson
        {
            public AudioClip audioClip;
         


        }
    }
}
