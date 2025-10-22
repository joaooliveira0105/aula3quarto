using UnityEngine;
using UnityEngine.InputSystem;

public class moverjogador : MonoBehaviour
{
    public Rigidbody jogador;
    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1;
        }

        // Aplicar movimento
        Vector3 movimento = new Vector3(horizontal, 0, vertical) * velocidade * Time.deltaTime;
        jogador.MovePosition(jogador.position + movimento);
    }
}