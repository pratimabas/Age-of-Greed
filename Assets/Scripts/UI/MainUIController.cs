using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    /// <summary>
    /// A simple controller for switching between UI panels.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        public void LoadScene0()
        {
            SceneManager.LoadSceneAsync(0);
        }

        public void LoadScene1()
        {
            SceneManager.LoadSceneAsync(1);
        }

        public void LoadScene2()
        {
            SceneManager.LoadSceneAsync(2);
        }

        public void LoadScene3()
        {
            SceneManager.LoadSceneAsync(3);
        }

        public void LoadScene4()
        {
            SceneManager.LoadSceneAsync(4);
        }

        public void LoadScene5()
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}