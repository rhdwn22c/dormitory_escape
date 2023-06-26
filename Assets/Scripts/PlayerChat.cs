using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerchat : MonoBehaviour
{
    public Player player;
    public Text[] playerText;

    int i = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown) {
            Destroy(playerText[i]);
            Instantiate(playerText[i + 1], new Vector3(0, 0, 0), Quaternion.identify);
            i++;
        }

    }
}
