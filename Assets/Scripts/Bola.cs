using NUnit.Framework.Constraints;
using UnityEngine;

public class Bola : MonoBehaviour

{
    public float velocidadeBola;

    public float DirecaoAleatoriaX;

    public float DirecaoAleatoriaY;


    public Rigidbody2D oRigidbody2D;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(velocidadeBola, velocidadeBola);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        oRigidbody2D.linearVelocity += new Vector2(DirecaoAleatoriaX, DirecaoAleatoriaY);
    }


}
