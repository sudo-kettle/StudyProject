using UnityEngine;
using UnityEngine.InputSystem;

public class ComponentAccess : MonoBehaviour
{
    void Update()
    {
        // Кнопка F1: подбрасываем объект через Rigidbody
        if (Keyboard.current.f1Key.wasPressedThisFrame)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 300f);
            Debug.Log("Объект подброшен!");
        }

        // Кнопка F2: безопасно получаем Renderer и меняем цвет
        if (Keyboard.current.f2Key.wasPressedThisFrame)
        {
            if (TryGetComponent(out Renderer objectRenderer))
            {
                objectRenderer.material.color = Color.red;
                Debug.Log("Цвет изменен на красный!");
            }
        }

        // Кнопка F3: включаем и выключаем коллайдер
        if (Keyboard.current.f3Key.wasPressedThisFrame)
        {
            Collider col = GetComponent<Collider>();
            col.enabled = !col.enabled;
            Debug.Log(col.enabled ? "Коллизия: включена" : "Коллизия: выключена");
        }
    }
}