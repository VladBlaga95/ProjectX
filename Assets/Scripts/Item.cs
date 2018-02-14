using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public Sprite img;
    public int count=1;
    public string nume;
    public Item()
    {
       
    }
    public Item(Sprite img,string nume)
    {
        this.img = img;
        this.nume = nume;
    }
}
