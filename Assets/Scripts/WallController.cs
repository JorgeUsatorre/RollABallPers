using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject wallToMove; // Referencia al GameObject de la pared que se elevará
    public float moveDistance = 10f; // Distancia que la pared se elevará
    private bool isRaised = false; // Estado actual de la pared

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isRaised) // Suponiendo que el jugador tiene un tag "Player"
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null && playerController.GetCoinCount() >= 8) // Comprobar si el jugador ha recogido al menos 8 monedas
            {
                RaiseWall(); // Elevar la pared si el jugador ha recogido al menos 8 monedas
            }
        }
    }

    void RaiseWall()
    {
        // Obtener la posición actual de la pared
        Vector3 currentPosition = wallToMove.transform.position;
        // Calcular la nueva posición elevada de la pared
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + moveDistance, currentPosition.z);
        // Establecer la nueva posición de la pared
        wallToMove.transform.position = newPosition;
        isRaised = true; // Actualizar el estado de la pared
    }
}



