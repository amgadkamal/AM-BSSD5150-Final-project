using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPoint ;
    private float move;
    private float move2;
    private float maxSpeedx = 20f;
    private float maxSpeedy = 20f;
    private float jump = 150f;
    private Rigidbody2D rb;


    public int currentscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move2 = Input.GetAxis("Vertical"); }

    //move player
    private void FixedUpdate()

    {
        rb.velocity = new Vector2(move * maxSpeedx, move2 * maxSpeedy);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(move * maxSpeedx, rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x +jump,rb.velocity.y + jump); } }

//if player touches poison tress you will lose
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "hazard")
        {
            SceneManager.LoadScene("lose"); } }

     
}