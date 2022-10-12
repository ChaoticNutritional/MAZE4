using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealTrap : MonoBehaviour
{
    [SerializeField]
    private BoxCollider enterBox;

    [SerializeField]
    private GameObject falseFloors;

    [SerializeField]
    private GameObject playerObject;

    [SerializeField]
    private GameObject crossingPlank; //object required to be a child of player

    public void OnCollisionEnter(Collision collision)
    {
        //if player enters and floor has not yet been revealed
        if (collision.gameObject == playerObject && falseFloors.activeSelf)
        {
            falseFloors.SetActive(false);
        }

        //if player enters and the floor has already been revealed
        else if (collision.gameObject == playerObject && !falseFloors.activeSelf)
        {
            //if player doesn't have plank
            if (collision.gameObject.GetComponent<>())
            //output text that says "if only I had something I could use to cross this"

            //if player has plank
            crossingPlank.SetActive(true);
        }
    }
}
