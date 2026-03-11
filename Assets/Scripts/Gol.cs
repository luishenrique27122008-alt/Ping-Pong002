using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool Parede1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Parede1 == true)
        {
            FindObjectOfType<GameManager>().AumentarPontuacao2();
            other.gameObject.transform.position = Vector2.zero;
        }

        else
        {
            FindObjectOfType<GameManager>().AumentarPontuacao1();
            other.gameObject.transform.position = Vector2.zero;
        }
    }

}
