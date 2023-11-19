using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SameColour : MonoBehaviour
{
    public GameObject backGroundColour;
    public SpriteRenderer backspriterender;
    public SpriteRenderer selfspriterender;
    public BoxCollider2D boxCollider2D;

    private void Awake()
    {
        backspriterender = backGroundColour.GetComponent<SpriteRenderer>();
        selfspriterender = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        if (ColorUtility.Equals(backspriterender.color , selfspriterender.color))
        {
            Debug.Log("se");
            boxCollider2D.enabled = false;
        }
        else
            boxCollider2D.enabled = true;
    }
}
