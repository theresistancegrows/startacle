using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    [SerializeField] float speed = 8;
    [SerializeField] Rigidbody rb;
    [SerializeField] Text textScore;
    float horizontalInput;
    bool alive = true;
    long score = 0;

    void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * 2;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        Invoke("AddSpeed", 60);
    }

    private void AddSpeed() {
        speed += 5;
    }

     private void Update () {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5) {
            die();
        }
     }

     private void OnCollisionEnter(UnityEngine.Collision collision) {
        if (collision.collider.tag == "obstacle") {
            die();
        }
    }

     public void die() {
         alive = false;
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }

     private void OnTriggerEnter(Collider other) {
         if (other.gameObject.name != "star" && other.gameObject.name != "jelly") {
             return;
         } 
         else if (other.gameObject.name == "star") {
             score += 20;
         }
         else if (other.gameObject.name == "jelly") {
             score += 50;
         }
         textScore.text = score.ToString("0");
         Destroy(other.gameObject);  
     }
}
