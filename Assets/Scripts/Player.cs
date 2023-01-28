using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public GameObject gameOverPanel;

    public float force;

    private bool canJump;

    public GameObject scoreManager;

    void Start()
    {
        canJump = true;

        StartCoroutine(MakePlayerFallable());
    }

    IEnumerator MakePlayerFallable()
    {
        yield return new WaitForSeconds(1);

        player.GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (canJump)
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector3(0, force, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameOver();
    }

    void GameOver()
    {
        scoreManager.GetComponent<ScoreManager>().StopScoring();
        canJump = false;
        StartCoroutine(ShowGameOverPanel());
    }

    IEnumerator ShowGameOverPanel()
    {
        yield return new WaitForSeconds(0.01f);
        gameOverPanel.SetActive(true);
    }
}
