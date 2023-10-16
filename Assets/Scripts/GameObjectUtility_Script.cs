using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectUtility_Script : MonoBehaviour
{

    // Toggle the game object depending on if its active or not
    public void ToggleGameObject()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

}
