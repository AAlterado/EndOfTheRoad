using UnityEngine;
using TMPro;

public class DistanceTracker : MonoBehaviour
{
    public Transform player; // your car or vehicle object
    public TextMeshProUGUI distanceText;

    private float startZ;

    void Start()
    {
        if (player != null)
        {
            startZ = player.position.z;
        }
    }

    void Update()
    {
        if (player != null)
        {
            float distance = (player.position.z - startZ) * 0.5f;
            distanceText.text = "DISTANCE: " + distance.ToString("F2") + " m";
        }
    }
}

