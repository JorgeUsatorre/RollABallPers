using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f; // Velocidad del enemigo
    private Transform player; // Referencia al transform del jugador

    void Start()
    {
        // Buscar el objeto con la etiqueta "Player" y obtener su transform
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Calcular la dirección hacia la posición actual del jugador
        Vector3 targetDirection = player.position - transform.position;
        // Normalizar la dirección para obtener una velocidad constante
        targetDirection.Normalize();
        // Mover el enemigo hacia el jugador con la velocidad especificada
        transform.Translate(targetDirection * speed * Time.deltaTime);
    }
}



