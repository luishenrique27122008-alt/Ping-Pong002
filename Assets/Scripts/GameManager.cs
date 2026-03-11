using UnityEngine;

public class GameManager : MonoBehaviour

{
    public int pontuacao1;
    public int pontuacao2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AumentarPontuacao1()
    {
        pontuacao1 += 1;
    }



    public void AumentarPontuacao2()
    { 
        pontuacao2 += 2;
    }
}
