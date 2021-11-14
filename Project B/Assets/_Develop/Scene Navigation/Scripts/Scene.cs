using UnityEngine;

namespace ProjectB.SceneNavigation
{
    public class Scene : MonoBehaviour
    {
        public string Name;
        public int Index;
        public bool IsActive;

        private Transform sceneHolder;

        private void Reset()
        {
            if(Name == string.Empty)
            {
                Name = gameObject.name; 
            }
        }

        private void Awake()
        {
            // Create a game object that will hold the objects inside the scene object
            sceneHolder = new GameObject("Scene Holder").transform;
            sceneHolder.SetParent(transform);
            sceneHolder.SetSiblingIndex(0);

            for(int i = transform.childCount-1; i > 0; i--)
            {
                Transform child = transform.GetChild(i);

                if (child == sceneHolder) continue;

                child.SetParent(sceneHolder);

            }
        }


        public GameObject FindGameObject(string name, bool caseSensitive = true)
        {
            foreach (Transform child in sceneHolder)
            {
                if (caseSensitive)
                {
                    if (child.name == name)
                    {
                        return child.gameObject;
                    }
                }
                else
                {
                    if(child.name.ToLower() == name.ToLower())
                    {
                        return child.gameObject;
                    }
                }
            }
            return null;
        }

        public void SetActive(bool state)
        {
            IsActive = state;
            sceneHolder.gameObject.SetActive(IsActive);
        }

        public void AddGameObject(GameObject obj)
        {
            obj.transform.SetParent(sceneHolder);
        }
    }

}