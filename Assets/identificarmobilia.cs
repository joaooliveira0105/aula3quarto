using UnityEngine;

public class identificarmobilia : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Mostra o nome do objeto que colidiu no Debug
        Debug.Log("Bateu em: " + collision.gameObject.name);
    }
}