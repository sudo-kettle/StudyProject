using UnityEngine;

public class Spinner : MonoBehaviour
{
    void Update()
    {
        // Поворачиваем объект вокруг вертикальной оси на 90 градусов в секунду
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}
