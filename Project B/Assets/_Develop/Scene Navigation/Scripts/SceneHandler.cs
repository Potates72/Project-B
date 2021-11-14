using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProjectB.SceneNavigation
{
    public class SceneHandler : MonoBehaviour
    {
        public Scene StartScene;

        public void Start()
        {
            List<Scene> scenes = FindObjectsOfType<Scene>().ToList();
            SceneNavigation.SetSceneList(scenes);

            foreach (Scene scene in scenes)
            {
                scene.SetActive(false);
            }

            if (StartScene)
                SceneNavigation.SetActiveScene(StartScene);
            else
                scenes.Find(x => x.Index == 0).SetActive(true);
        }
    }

}