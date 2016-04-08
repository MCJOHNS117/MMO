using MMO.Photon.Application;

namespace MMO.Photon.Server
{
	public abstract class DefaultRequestHandler : PhotonServerHandler
	{
		protected DefaultRequestHandler(PhotonApplication application) : base(application) { }
	}
}
