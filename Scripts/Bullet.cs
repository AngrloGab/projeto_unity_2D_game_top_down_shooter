using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask layerParedes;
    public LayerMask layerInimigos;
    [SerializeField] float speed;

    [SerializeField] ParticleSystem effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right *Time.deltaTime * speed);

    }

    private void OnTriggerEnter2D(Collider2D collision){
         if ((((1 << collision.gameObject.layer) & layerParedes) != 0) || (((1 << collision.gameObject.layer) & layerInimigos) != 0) )
        {
            // Destroi apenas se a camada da colisão está na máscara de camada permitida
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
