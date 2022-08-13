using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    List<GameObject> list = new List<GameObject>();
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    // Start is called before the first frame update
    void Start()
    {
        list.Add(Image1);
        list.Add(Image2);
        list.Add(Image3);
        list.Add(Image4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
