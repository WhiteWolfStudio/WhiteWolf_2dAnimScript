using UnityEngine;
using System.IO;

namespace WhiteWolf {

    public class WW_2dAnimScript : MonoBehaviour {

        /* folder/file */
        public string resourcePath;
        public Sprite[] animFrames;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        SpriteRenderer sr;
        int frame;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        void Start(){

            sr = this.gameObject.GetComponent<SpriteRenderer>();
            animFrames = Resources.LoadAll<Sprite>( resourcePath );
            
        }

        void Update() => sr.sprite = animFrames[ frame ];

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void SetFrame( int frame ) => this.frame = frame;
        public void PlusFrame() => this.frame += 1;

        public void AnimEnd() => frame = 0;
        public void AnimEndN( int frame ) => this.frame = frame;

    }

}
