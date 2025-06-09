using UnityEngine;

public class Side2Switch : MonoBehaviour
{
    private Camera Cam;

    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;

        Player = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        Player.layer = 6;

        Cam.cullingMask = ~(1 << 7);

        Cam.cullingMask |= (1 << 6);
    }
}
