using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float cameraSpeed = 5.0f;

    public GameObject player;
    public GameObject ufo;

    private void Update()
    {
        if (GameMng.GetIns.CameraPlayerView)
        {
            Vector3 dir = player.transform.position - this.transform.position;
            Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
            this.transform.Translate(moveVector);
        }

        if (GameMng.GetIns.CameraUFOView)
        {
            Vector3 dir = ufo.transform.position - this.transform.position;
            Vector3 moveVector = new Vector3(dir.x * cameraSpeed  * Time.deltaTime, dir.y * cameraSpeed  * Time.deltaTime, 0.0f);
            this.transform.Translate(moveVector);
        }
    }
}
