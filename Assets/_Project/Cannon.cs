using UnityEngine;
using UnityEngine.InputSystem;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private float _force = 20f;
    [SerializeField] private float _lifetime = 5f;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Создаем в сцене копию префаба там, где стоит пушка, и с ее поворотом
            GameObject ball = Instantiate(_ballPrefab, transform.position, transform.rotation);

            // Толкаем шар вперед по направлению пушки
            ball.GetComponent<Rigidbody>().AddForce(transform.forward * _force, ForceMode.Impulse);

            // Уничтожаем шар через несколько секунд
            Destroy(ball, _lifetime);
        }
    }
}