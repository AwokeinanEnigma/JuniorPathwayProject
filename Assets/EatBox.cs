using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class EatBox : MonoBehaviour
    {
        public enum BoxType
        {
            Fragile,
            Generic
        }
        public BoxType Type;
        public void OnTriggerEnter(Collider other)
        {

            switch (Type)
            {
                case BoxType.Fragile:
                    FragileBox fragileBox = other.GetComponent<FragileBox>();
                    if (fragileBox)
                    {
                        Debug.Log("Fragile box");
                        GameTimer.AddTime(7);
                        Destroy(fragileBox.gameObject);
                        GameTimer.AddScore(4);
                    }
                    break;
                case BoxType.Generic:
                    GenericBox genericBox = other.GetComponent<GenericBox>();
                    genericBox = other.GetComponent<GenericBox>();
                    if (genericBox)
                    {
                        GameTimer.AddTime(3.5f);
                        GameTimer.AddScore(2);
                        Destroy(genericBox.gameObject);
                    }
                    break;
            }
        }
    }
}