using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;  // Velocidad de movimiento del jugador

    void Update()
    {
        // Obtener entrada del usuario en los ejes horizontal y vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento en 3D
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical).normalized;

        // Aplicar movimiento al transform del objeto
        transform.Translate(movimiento * velocidad * Time.deltaTime);

        // Mostrar en la consola la dirección en la que se mueve el jugador
        if (movimiento != Vector3.zero)
        {
            Debug.Log("Moviendo en dirección: " + movimiento);
        }
    }
}
