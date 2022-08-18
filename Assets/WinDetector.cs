using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetector : MonoBehaviour
{
    public GameObject winMessage;

    private void Start()
    {
        winMessage.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MainCamera"))
        {
            //we won
            if(!winMessage.activeInHierarchy)
            {
                winMessage.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update

}
