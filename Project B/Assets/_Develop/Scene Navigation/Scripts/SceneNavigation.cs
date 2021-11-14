using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProjectB.SceneNavigation
{

    public static class SceneNavigation
    {
        

        private static Scene activeScene;
        private static List<Scene> scenes;
        //public void 


        private static void ChangeScene(Scene scene)
        {
            if(activeScene)
                activeScene.SetActive(false);
            scene.SetActive(true);
            activeScene = scene;
        }


        public static void SetSceneList(List<Scene> sceneList) => scenes = sceneList;
        public static Scene GetActiveScene()
        {
            return activeScene;
        }

        public static void SetActiveScene(string name)
        {
            Scene scene = scenes.Find(x => x.Name == name);
            if (!scene)
            {
                Debug.LogError("Scene name not found");
                return;
            }

            ChangeScene(scene);
        }

        public static void SetActiveScene(int sceneIndex)
        {
            Scene scene = scenes.Find(x => x.Index == sceneIndex);
            if (!scene)
            {
                Debug.LogError("Scene index not found");
                return;
            }

            ChangeScene(scene);
        }

        public static void SetActiveScene(Scene targetScene)
        {
            Scene scene = scenes.Find(x => x == targetScene);
            if (!scene)
            {
                Debug.LogError("Scene does not exist");
                return;
            }

            ChangeScene(scene);
        }
    }

}