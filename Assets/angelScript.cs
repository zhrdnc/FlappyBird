using UnityEngine;

public class AngelScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 12; 
    public LogicScript logic;
    public bool angelIsAlive = true;

    private float screenLimit;

    void Start()
    {

        GameObject logicObj = GameObject.FindGameObjectWithTag("Logic");
        if (logicObj != null)
        {
            logic = logicObj.GetComponent<LogicScript>();
        }

        screenLimit = Camera.main.orthographicSize;
    }

    void Update()
    {
        if (angelIsAlive)
        {
            // Zıplama kontrolü
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }

            if (transform.position.y > screenLimit || transform.position.y < -screenLimit)
            {
                KillAngel();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        KillAngel();
    }

    void KillAngel()
    {
        if (angelIsAlive)
        {
            angelIsAlive = false;
            logic.gameOver();
            myRigidbody.velocity = Vector2.zero; 
        }
    }
}