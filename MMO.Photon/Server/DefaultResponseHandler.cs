using MMO.Photon.Application;

namespace MMO.Photon.Server
{
	public abstract class DefaultResponseHandler : PhotonServerHandler
	{
		protected DefaultResponseHandler(PhotonApplication application) : base(application) { }
	}
}
