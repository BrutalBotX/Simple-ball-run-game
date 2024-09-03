using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class colli : MonoBehaviour
{
    public game movement;
    public Vector3 InitialPosition = new Vector3(0, 6, -33.7f);
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            Score.scoreCount -= 20;
            Reset();
        }
        else if (collision.collider.tag == "endgame"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        Debug.Log("Collision - " + collision.collider.name);
    }

    IEnumerator ResetGame()
    {
        movement.enabled = false;
        yield return new WaitForSeconds(0.1f);
        movement.Reset();
        yield return new WaitForSeconds(0.3f);
        movement.enabled = true;
    }

    public void Reset()
    {
        transform.position = InitialPosition;
    }
}
