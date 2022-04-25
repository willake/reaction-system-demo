using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class GameManager : MonoBehaviour
    {
        public const string LAYER_INTERACTABLE = "Interactable";
        public Camera gameCamera;

        private Camera GetGameCamera()
        {
            return gameCamera ?? (gameCamera = Camera.main);
        }


        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                HandleMouseClick();
            }
        }

        private void HandleMouseClick()
        {
            Vector3 pos = gameCamera.ScreenToWorldPoint(
                Input.mousePosition
            );

            RaycastHit2D hit = Physics2D.Raycast(
                pos,
                gameCamera.transform.forward,
                LayerMask.NameToLayer(LAYER_INTERACTABLE)
            );

            if (hit.collider != null)
            {
                Clickable clickable = hit.collider.GetComponent<Clickable>();

                if (clickable)
                {
                    clickable.OnClick();
                }
            }
        }
    }
}