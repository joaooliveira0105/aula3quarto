using UnityEngine;

public class seguircamera : MonoBehaviour
{
    public Transform jogador;
    public Vector3 offset = new Vector3(0, 8, -10);
    public float suavidade = 10f;

    void Start()
    {
        if (jogador == null)
        {
            GameObject obj = GameObject.Find("jogador");
            if (obj != null)
                jogador = obj.transform;
        }
    }

    void LateUpdate()
    {
        if (jogador != null)
        {
            // Posição desejada (sempre fixa em relação ao jogador)
            Vector3 posicaoDesejada = jogador.position + offset;
            
            // Movimento suave
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavidade * Time.deltaTime);
            
            // Rotação fixa olhando para o jogador
            Vector3 direcao = jogador.position - transform.position;
            Quaternion rotacaoDesejada = Quaternion.LookRotation(direcao);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotacaoDesejada, suavidade * Time.deltaTime);
        }
    }
}