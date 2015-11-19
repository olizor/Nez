using Newtonsoft.Json;


namespace Nez
{
	public class TexturePackerSize
	{
		[JsonProperty( "w" )]
		public int Width;

		[JsonProperty( "h" )]
		public int Height;

		public override string ToString()
		{
			return string.Format( "{0} {1}", Width, Height );
		}
	}
}