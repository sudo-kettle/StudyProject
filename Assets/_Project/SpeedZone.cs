using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    [SerializeField] private float _multiplier = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController player = other.GetComponent<FirstPersonController>();
            if (player != null)
            {
                player.MultiplySpeed(_multiplier);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController player = other.GetComponent<FirstPersonController>();
            if (player != null)
            {
                player.MultiplySpeed(1f / _multiplier);
            }
        }
    }
}
