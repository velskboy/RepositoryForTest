using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovenment : MonoBehaviour
{

    public float moveSpeed = 5.0f; // Скорость движения персонажа
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Замораживаем вращение Rigidbody
    }

    void Update()
    {
        // Получите ввод с клавиатуры
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Рассчитайте вектор движения
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        Vector3 movement = moveDirection * moveSpeed;

        // Примените движение
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }

}
