using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace AdvancedRenderPipeline.Editor {
	[CreateAssetMenu(fileName = "ARP Editor Asset", menuName = "Advanced Render Pipeline/ARP Editor Asset", order = 0)]
	public class ARPEditorAsset : ScriptableObject {
		[Range(128, 1024)]
		public int iblLutResolution = 1024;
		public GraphicsFormat iblLutFormat = GraphicsFormat.R16G16B16A16_UNorm;
		public bool displayLutRefereces;
		public Texture referenceLut1;
		public Texture referenceLut2;
		public ComputeShader iblLutGenerationShader;
	}
}