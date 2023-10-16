using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_Script : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }


    // pet the cat
    // for button
    public void Interact_Pet()
    {
        Debug.Log("Pet the cat");
        
    }

    public void Interact_Feed()
    {
        Debug.Log("Feed the cat");
    }

    public void Interact_Water()
    {
        Debug.Log("Water the cat");
    }

    public void Interact_Play()
    {
        Debug.Log("Play with the cat");
    }

    public void Interact_Potty()
    {
        Debug.Log("Potty the cat");
    }

    public void Interact_Groom()
    {
        Debug.Log("Groom the cat");
    }

    public void Interact_Wash()
    {
        Debug.Log("Wash the cat");
    }

    public void Interact_DressUp()
    {
        Debug.Log("Dress the cat");
    }
}
