using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leveltwo : MonoBehaviour
{
    private float move;
    private float move2;
    private float maxSpeedx = 20f;
    private int points = 0;
    private Rigidbody2D rb;
    public int numSelectors = 9;

    public GameObject[] selectorArr;

    //public GameObject selector; //selected in the editor
    [SerializeField] private GameObject coinss;

    [SerializeField] Transform spawnPoint;


    public int currentscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        //random fallen helmets
        rb = GetComponent<Rigidbody2D>();
        selectorArr = new GameObject[3];
        for (int i = 0; i < 3; i++)
        {

            Vector3 coinsposition = new Vector3(Random.Range(-7f, -2f), Random.Range(5f, 4f), 0f);
            Instantiate(coinss, coinsposition, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move2 = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(move * maxSpeedx, rb.velocity.y); }

    private void FixedUpdate()
//fire bullets
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet =
                Instantiate(Resources.Load("bullet"), spawnPoint.position, transform.rotation) as GameObject;
            bullet.SetActive(true);
       
        }
    }
//collect points(fallen helmets)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.tag == "points")
        {
            Destroy(GameObject.FindWithTag("points"));
            points += 1;

        }

//win scene
        if (collision.gameObject.tag == "end" && points >2)
        {
            SceneManager.LoadScene("win");

        }
        
        
        
    }
}
