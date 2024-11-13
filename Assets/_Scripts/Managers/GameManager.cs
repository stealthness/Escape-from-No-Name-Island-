using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

namespace _Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager InstanceDescriptor;
        


        private void Awake()
        {
            if (InstanceDescriptor == null)
            {
                InstanceDescriptor = this;
            }
            else
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(this);
        }

        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("GM : Game Started");
        }


    }
}
