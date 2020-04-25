using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExampleAtrr : MonoBehaviour
{
    
    private GameObject Joe;

    [Header("Ниже представлены характеристики персонажа")]
    public string nameCharacter;

    [Tooltip("Количество урона от FireBall")]
    public float ForceFireball;

    [Tooltip("В каком месте на карте появляться игроку")]
    public Transform StartPosition;
   
    [Tooltip("Эта переменная отвечает за количество патронов")]
    public int CountBullet;

    [TextArea]
    public string HistoryPlayer;
    
    [Multiline]
    public string HistoryHouse;
    
    [Range(0,23)]
    public int Hour = 0;
    [Range(0,60)]
    public int Min = 0;


    [HideInInspector]
    public GameObject _testRoom;
    
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
    }
}