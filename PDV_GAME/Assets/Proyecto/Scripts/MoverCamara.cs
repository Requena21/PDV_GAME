
using UnityEngine;

public class MoverCamara : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}