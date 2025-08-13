using UnityEngine;

public class Jogador : Personagem
{


    
    
    void Start()
    {
        
    }

    
    void Update()

    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

          if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

          if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }

         if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }
    }

        private void OnCollisionEnter2D(Collision2D other)
        {
             if (other.gameObject.CompareTag ("Inimigo"))
             { 
                  int vidas = getVidas() - 1;
                  setVidas(vidas);
             }
        }

}