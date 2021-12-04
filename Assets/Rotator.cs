using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotator : MonoBehaviour
{
    [SerializeField]  public static float speed = 100f;

    public bool canRotate = true;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canRotate)
            transform.Rotate(0f, 0f, Time.deltaTime * speed);
    }

    public void GameOverAnimation()
    {
        SceneManager.LoadScene(Random.Range(0, 4));
    }
}
