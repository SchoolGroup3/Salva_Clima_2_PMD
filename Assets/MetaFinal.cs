using UnityEngine;

public class MetaFinal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ControladorPuntuacion controlador = FindObjectOfType<ControladorPuntuacion>();
            if (controlador != null)
            {
                if (controlador.HaRecogidoTodos())
                {
                    Debug.Log("�Nivel completado!");
                    // Aqu� puedes cargar siguiente escena, mostrar UI, etc.
                }
                else
                {
                    Debug.Log("�A�n faltan coleccionables!");
                }
            }
        }
    }
}
