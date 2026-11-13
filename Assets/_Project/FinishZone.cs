using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private bool _isFinished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_isFinished)
        {
            _isFinished = true;
            Debug.Log("Уровень пройден за: " + Time.timeSinceLevelLoad + " сек.");
        }
    }
}
