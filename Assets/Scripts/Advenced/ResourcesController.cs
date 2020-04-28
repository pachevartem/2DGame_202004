using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesController : MonoBehaviour
{
    private Image InternetAvatar;
    private Sprite woodpanel;

    private void Start()
    {
        InternetAvatar = GameObject.Find("Image").GetComponent<Image>();
        woodpanel = Resources.Load<Sprite>("wood");
        InternetAvatar.sprite = woodpanel;
    }
    
  
    
}
