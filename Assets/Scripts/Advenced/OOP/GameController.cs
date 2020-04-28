using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        public Transform pointA;
        public Transform pointB;
        public List<Humanoid> pupils = new List<Humanoid>();

        public GameObject prefbElf;
        public GameObject prefbGnome;
        public GameObject prefbDrenay;

        TypeRaсe Race;


        Vector3 RandomPosition()
        {
            float _x = Random.Range(pointA.position.x, pointB.position.x);
            float _y = Random.Range(pointA.position.y, pointB.position.y);
            float _z = Random.Range(pointA.position.z, pointB.position.z);
            return new Vector3(_x, _y, _z);
        }

        private void Awake()
        {
            for (int i = 0; i < 100; i++)
            {
                int _r = Random.Range(1, 4);

                switch (_r)
                {
                    case 1:
                        Race = TypeRaсe.drenay;
                        break;
                    case 2:
                        Race = TypeRaсe.elf;
                        break;
                    case 3:
                        Race = TypeRaсe.gnome;
                        break;
                }

                switch (Race)
                {
                    case TypeRaсe.elf:
                        AddHumanoid(prefbElf);
                        break;
                    case TypeRaсe.gnome:
                        AddHumanoid(prefbGnome);
                        break;
                    case TypeRaсe.drenay:
                        AddHumanoid(prefbDrenay);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        void AddHumanoid(GameObject pref)
        {
            GameObject _obj = Instantiate(pref);
            _obj.transform.position = RandomPosition();
            Humanoid _tempHuman = _obj.GetComponent<Humanoid>();
            pupils.Add(_tempHuman);
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var pupil in pupils)
                {
                    pupil.WinBehaviuor();
                }
            }

            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                foreach (var pupil in pupils)
                {
                    if (pupil.GetType() == typeof(Gnome))
                    {
                        pupil.WinBehaviuor();
                    }
                }
            }
        }
    }


    public enum TypeRaсe
    {
        elf, //0
        gnome, //1
        drenay //2
    }
}