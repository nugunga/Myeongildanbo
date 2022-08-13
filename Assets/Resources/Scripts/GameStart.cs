using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public GameObject Back;
    public GameObject m_Text;

    public Image Fade;
    public float colorSpeed = 0.01f;
    float colora;
    bool IsFade = false;
    bool Color255 = false;
    float TimeCheck;
    bool IsTimeCheck = false;
    bool Key = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameMng.GetIns.GameStart && Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            if (Key == false)
            {

                IsFade = true;
                Key = true;

            }
        }

        if (IsFade && !Color255)
        {
            colora += Time.deltaTime;
            Fade.color = new Color(0, 0, 0, colora);
            if (colora >= 2)
            {
                Back.SetActive(false);
                //m_Text.SetActive(false);
                colora = 1;
                IsFade = false;
                IsTimeCheck = true;
            }
        }

        if (!IsFade && IsTimeCheck)
        {
            colora -= Time.deltaTime;
            Fade.color = new Color(0, 0, 0, colora);
            if (colora <= 0)
            {
                GameMng.GetIns.GameStart = true;
                GameMng.GetIns.CameraPlayerView = true;
                GameMng.GetIns.CameraUFOView = false;

                gameObject.SetActive(false);
            }
        }
    }

}
