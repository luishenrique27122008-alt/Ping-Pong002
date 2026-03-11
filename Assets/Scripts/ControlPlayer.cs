using UnityEngine;

public class ControlPlayer : MonoBehaviour
{


    public float Vplayer;

    public bool player1;

    public float yMinimo;
    public float yMaximo;
    
    void Start()
    {

    }


    void Update()
    {
        if (player1 == true)
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }

    }

    private void MoverJogador1()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Time.deltaTime * Vplayer * Vector2.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Time.deltaTime * Vplayer * Vector2.down);
        }
    }

    private void MoverJogador2()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Time.deltaTime * Vplayer * Vector2.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Time.deltaTime * Vplayer * Vector2.down);
        }
    }


}
