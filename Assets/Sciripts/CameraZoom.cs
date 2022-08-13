using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoom_value = 10.0f;
    Camera Camera;
    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Camerazoom();
    }


    public void Camerazoom()
    {
        Camera.orthographicSize = zoom_value;
        Camera.transform.position = new Vector3(5, 3, -10);
    }


    void Update()
    {
        //float scroll = Input.GetAxis("Mouse ScrollWheel") * speed;

        //if(Camera.orthographicSize <= 2.67f && scroll > 0)
        //{
        //    temp_value = Camera.orthographicSize;
        //    Camera.orthographicSize = temp_value;
        // }
        //else if(Camera.orthographicSize >= 7.03f && scroll < 0)
        //{
        //    temp_value = Camera.orthographicSize;
        //    Camera.orthographicSize = temp_value;
        //}
        //else
        //{
        //    Camera.orthographicSize -= scroll * 0.5f;
        //}
    }
}
