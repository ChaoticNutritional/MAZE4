using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChecker : MonoBehaviour
{
    //public GameObject winMessage;
    private bool isOpen;
    public GameObject doorPivot;

    private void Start()
    {
        isOpen = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            //we won
            if(!isOpen)
            {
                isOpen = true;
                doorPivot.transform.Rotate(Vector3.up, 150f);
            }
        }
    }
    // Start is called before the first frame update

}
